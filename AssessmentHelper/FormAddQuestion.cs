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

namespace AssessmentHelper
{
    public partial class FormAddQuestion : Form
    {
        private Question m_question = null;

        public FormAddQuestion()
        {
            InitializeComponent();

            if ((-1 != Properties.Settings.Default.FormAddQuestion_PosX) && (-1 != Properties.Settings.Default.FormAddQuestion_PosY))
                this.Location = new Point(Properties.Settings.Default.FormAddQuestion_PosX, Properties.Settings.Default.FormAddQuestion_PosY);
            else
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            if ((-1 != Properties.Settings.Default.FormAddQuestion_SizeHeight) && (-1 != Properties.Settings.Default.FormAddQuestion_SizeWidth))
                this.Size = new Size(Properties.Settings.Default.FormAddQuestion_SizeWidth, Properties.Settings.Default.FormAddQuestion_SizeHeight);

            m_edtNbAnswers.Enabled = false;
            m_btnDelete.Enabled = false;
        }

        public static Question ShowAddQuestionDialog()
        {
            var form = new FormAddQuestion();
            form.ShowDialog();
            return form.m_question;
        }



        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(m_editAnswer.Text))
                return;

            var answer = m_editAnswer.Text.Trim();
            foreach( ListViewItem choice in m_listAnswers.Items)
            {
                if (0 == string.Compare(choice.Text,answer, StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show(this, "Diese Antwort steht schon in der Liste der möglichen Antworten", "Frage Hinzufügen");
                    return;
                }
            }

            m_listAnswers.Items.Add(m_editAnswer.Text.Trim());
            m_editAnswer.Text = "";
        }

        private void m_btnDelete_Click(object sender, EventArgs e)
        {
            var idx = m_listAnswers.SelectedIndices[0];
            m_editAnswer.Text = m_listAnswers.Items[idx].Text;
            m_listAnswers.Items.RemoveAt(idx);
        }

        private void m_btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(m_edtText.Text))
            {
                MessageBox.Show(this, "Die Frage muss formuliert werden.", "Frage Hinzufügen");
                return;
            }

            if (0 >= m_listAnswers.Items.Count)
            {
                MessageBox.Show(this, "Es müssen mögliche Antworten hinzugefügt werden.", "Frage Hinzufügen");
                return;
            }


            int nbChoices = -1;
            if ( m_rbNbAnswers.Checked )
            {
                if (!int.TryParse(m_edtNbAnswers.Text, out nbChoices))
                {
                    MessageBox.Show(this, "Die Anzahl richtiger Antworten muss angegeben werden.", "Frage Hinzufügen");
                    return;
                }
                if (nbChoices < 0 || nbChoices > m_listAnswers.Items.Count)
                {
                    MessageBox.Show(this, "Die Anzahl richtiger Antworten muss größer oder gleich null und kleiner oder gleich der Anzahl der zur Auswahl stehenden Antworten sein.", "Frage Hinzufügen");
                    return;
                }
            }

            var choices = new List<string>();
            foreach (ListViewItem choice in m_listAnswers.Items)
                choices.Add(choice.Text);

            m_question = new Question(m_edtText.Text, choices, nbChoices);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void m_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void m_rbNbAnswers_CheckedChanged(object sender, EventArgs e)
        {
            if (m_rbNbAnswers.Checked)
                m_edtNbAnswers.Enabled = true;
            else
                m_edtNbAnswers.Enabled = false;
        }

        private void m_listAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_btnDelete.Enabled = 0 != m_listAnswers.SelectedIndices.Count;
        }

        private void FormAddQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormAddQuestion_PosX = this.Location.X;
            Properties.Settings.Default.FormAddQuestion_PosY = this.Location.Y;
            Properties.Settings.Default.FormAddQuestion_SizeWidth = this.Size.Width;
            Properties.Settings.Default.FormAddQuestion_SizeHeight = this.Size.Height;
            Properties.Settings.Default.Save();
        }
    }
}
