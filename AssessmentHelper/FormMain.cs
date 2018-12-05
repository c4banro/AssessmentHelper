using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssessmentHelperLib;
using System.IO;
using System.Threading;

namespace AssessmentHelper
{
    public partial class FormMain : Form
    {
        private Assessment m_assessment;

        public FormMain()
        {
            InitializeComponent();

            if ((-1 != Properties.Settings.Default.MainForm_PosX) && (-1 != Properties.Settings.Default.MainForm_PosY))
                this.Location = new Point(Properties.Settings.Default.MainForm_PosX, Properties.Settings.Default.MainForm_PosY);
            else
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            if ((-1 != Properties.Settings.Default.MainForm_SizeHeight) && (-1 != Properties.Settings.Default.MainForm_SizeWidth))
                this.Size = new Size(Properties.Settings.Default.MainForm_SizeWidth, Properties.Settings.Default.MainForm_SizeHeight);

            m_btnDeleteQuestion.Enabled = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                m_assessment = FileDatabase.Read();
                m_edtAssessmentName.Text = m_assessment.Name;
                m_btnSynchrinise.Enabled = true;
            }
            catch ( Exception ex)
            {
                m_btnSynchrinise.Enabled = false;
                MessageBox.Show(this, string.Format("Fehler beim Lesen des Assessments: {0}", ex), "AssessmentHelper");
            }
            UpdateAssessment();
        }

        private void m_edtFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateAssessment();
        }

        private void SaveAssessment()
        {
            try
            {
                FileDatabase.Write(m_assessment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Fehler beim Schreiben des Assessments: {0}", ex), "AssessmentHelper");
            }
        }


        private void UpdateAssessment()
        {
            m_listQuestions.Items.Clear();
            if (m_assessment == null)
                return;
            var questions = m_assessment.GetMatchingQuestions(m_edtFilter.Text);
            foreach(var question in questions)
            {
                var listItem = new ListViewItem();
                listItem.Tag = question;
                listItem.Text = question.Text;
                if (question.Solved)
                    listItem.BackColor = Color.LightGreen;
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, question.Solved.ToString()));
                listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, question.NbAnswersOpen.ToString()));
                m_listQuestions.Items.Add(listItem);
            }

            m_btnDeleteQuestion.Enabled = false;
            m_btnGiveAnswer.Enabled = false;
            m_btnEnterResult.Enabled = false;

            if (m_listQuestions.Items.Count > 0)
            {
                m_listQuestions.Items[0].Selected = true;
                /*
                m_btnDeleteQuestion.Enabled = true;
                m_btnGiveAnswer.Enabled = true;
                m_btnEnterResult.Enabled = true;
                */
            }
        }

        private void m_btnAddQuestion_Click(object sender, EventArgs e)
        {
            var question = FormAddQuestion.ShowAddQuestionDialog();
            if (question == null)
                return;
            m_assessment.AddQuestion(question);
            UpdateAssessment();
            SaveAssessment();
        }

        private void m_btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show(this, "Die Frage wirklich löschen", "Frage löschen", MessageBoxButtons.OKCancel))
                return;

            int idx = m_listQuestions.SelectedIndices[0];
            m_assessment.DeleteQuestion(m_listQuestions.Items[idx].Text);
            UpdateAssessment();
            SaveAssessment();
        }

        private void m_listQuestions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            m_btnDeleteQuestion.Enabled = 0 != m_listQuestions.SelectedIndices.Count;
            m_btnGiveAnswer.Enabled = 0 != m_listQuestions.SelectedIndices.Count;
            m_btnEnterResult.Enabled = 0 != m_listQuestions.SelectedIndices.Count;
        }

        private void m_btnGiveAnswer_Click(object sender, EventArgs e)
        {
            var item = m_listQuestions.SelectedItems[0];
            FormGiveAnswer.ShowFormGiveAnswer(item.Tag as Question);
            UpdateAssessment();
            SaveAssessment();
        }

        private void m_btnEnterResult_Click(object sender, EventArgs e)
        {
            var question = m_listQuestions.SelectedItems[0].Tag as Question;
            var form = new FormAddResult(question);

            if ( DialogResult.OK == form.ShowDialog())
            {
                try
                {
                    question.AddResult(form.Solved, form.Answers);
                    UpdateAssessment();
                    SaveAssessment();
                }
                catch( Exception ex)
                {
                    MessageBox.Show(this, string.Format("Ergebnis konnte nicht hinzugefügt werden: {0}", ex), "Ergebnis hinzufügen");
                }
            }
        }

        private void m_btnInsertClipboard_Click(object sender, EventArgs e)
        {
            m_edtFilter.Text = "";
            m_edtFilter.Text = Clipboard.GetText();
        }

        private void m_btnClear_Click(object sender, EventArgs e)
        {
            m_edtFilter.Text = "";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainForm_PosX = this.Location.X;
            Properties.Settings.Default.MainForm_PosY = this.Location.Y;
            Properties.Settings.Default.MainForm_SizeWidth = this.Size.Width;
            Properties.Settings.Default.MainForm_SizeHeight = this.Size.Height;
            Properties.Settings.Default.Save();
        }

        private void m_btnSynchronize_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Properties.Settings.Default.SharedPath;
                if (string.IsNullOrEmpty(path))
                    throw new Exception("SharedPath nicht konfiguriert");

                var syncFile = Path.Combine(path, "locked");
                var assessmentFile = Path.Combine(path, "assessment.asm");

                int tries = 5;
                while ( tries > 0 )
                {
                    try
                    {
                        using (var snyc = new FileStream(syncFile, FileMode.CreateNew))
                        {
                            var remoteAssessment = FileDatabase.Read(assessmentFile);
                            m_assessment.MergeAssessment(remoteAssessment);
                            FileDatabase.Write(m_assessment, assessmentFile);
                        }
                        File.Delete(syncFile);
                        FileDatabase.Write(m_assessment);
                        UpdateAssessment();
                        return;
                    }
                    catch( IOException ex)
                    {
                        Thread.Sleep(new Random().Next(100, 500));
                    }
                    tries--;
                }
                MessageBox.Show(this, "Assessment konnte nicht synchronisiert werden.", "AssessmentHelper");
            }
            catch( Exception ex)
            {
                MessageBox.Show(this, string.Format("Fehler beim Synchronisieren des Assessments: {0}", ex), "AssessmentHelper");
            }
        }
    }
}
