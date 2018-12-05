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
    public partial class FormAddResult : Form
    {
        private Question m_question;

        public bool Solved { get; private set; }
        public List<Tuple<string,bool>> Answers { get; private set; }

        public FormAddResult(Question a_question)
        {
            Solved = false;
            Answers = new List<Tuple<string, bool>>();
            m_question = a_question;

            InitializeComponent();

            if ((-1 != Properties.Settings.Default.FormAddResult_PosX) && (-1 != Properties.Settings.Default.FormAddResult_PosY))
                this.Location = new Point(Properties.Settings.Default.FormAddResult_PosX, Properties.Settings.Default.FormAddResult_PosY);
            else
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            if ((-1 != Properties.Settings.Default.FormAddResult_SizeHeight) && (-1 != Properties.Settings.Default.FormAddResult_SizeWidth))
                this.Size = new Size(Properties.Settings.Default.FormAddResult_SizeWidth, Properties.Settings.Default.FormAddResult_SizeHeight);


            m_edtQuestion.Text = m_question.Text;
            if (m_question.Solved)
                m_edtQuestion.BackColor = Color.LightGreen;
            m_ckSolved.Checked = m_question.Solved;

            var answer = m_question.GetSolutionOrChoices();
            foreach (var choice in answer)
            {
                m_listAnswers.Items.Add(choice.Item1, choice.Item2);
            }
        }

        private void m_btnOK_Click(object sender, EventArgs e)
        {
            Solved = m_ckSolved.Checked;
            for( int idx = 0; idx < m_listAnswers.Items.Count; idx++)
            {
                var text = m_listAnswers.Items[idx].ToString();
                var check = m_listAnswers.GetItemChecked(idx);
                Answers.Add(new Tuple<string, bool>(text, check));
            }
        }

        private void m_btnClose_Click(object sender, EventArgs e)
        {

        }

        private void FormAddResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormAddResult_PosX = this.Location.X;
            Properties.Settings.Default.FormAddResult_PosY = this.Location.Y;
            Properties.Settings.Default.FormAddResult_SizeWidth = this.Size.Width;
            Properties.Settings.Default.FormAddResult_SizeHeight = this.Size.Height;
            Properties.Settings.Default.Save();
        }
    }
}
