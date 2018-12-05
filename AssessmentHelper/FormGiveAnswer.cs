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
    public partial class FormGiveAnswer : Form
    {
        private Question m_question;
        private FormGiveAnswer(Question question)
        {
            m_question = question;
            InitializeComponent();

            if ((-1 != Properties.Settings.Default.FormGiveAnswer_PosX) && (-1 != Properties.Settings.Default.FormGiveAnswer_PosY))
                this.Location = new Point(Properties.Settings.Default.FormGiveAnswer_PosX, Properties.Settings.Default.FormGiveAnswer_PosY);
            else
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;

            if ((-1 != Properties.Settings.Default.FormGiveAnswer_SizeHeight) && (-1 != Properties.Settings.Default.FormGiveAnswer_SizeWidth))
                this.Size = new Size(Properties.Settings.Default.FormGiveAnswer_SizeWidth, Properties.Settings.Default.FormGiveAnswer_SizeHeight);

            m_edtQuestion.Text = m_question.Text;
            if (m_question.Solved)
                m_edtQuestion.BackColor = Color.LightGreen;
            DisplayAnswer();
        }

        public static void ShowFormGiveAnswer( Question a_question )
        {
            var form = new FormGiveAnswer(a_question);
            form.ShowDialog();
        }
        
        private void DisplayAnswer()
        {
            m_listAnswers.Items.Clear();
            var answer = m_question.GetRandomAnswer();
            foreach( var choice in answer)
            {
                if (choice.Item2)
                    m_listAnswers.Items.Add(choice.Item1, choice.Item2);
            }
            foreach (var choice in answer)
            {
                if (!choice.Item2)
                    m_listAnswers.Items.Add(choice.Item1, choice.Item2);
            }
        }

        private void m_btnOther_Click(object sender, EventArgs e)
        {
            DisplayAnswer();
        }

        private void FormGiveAnswer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormGiveAnswer_PosX = this.Location.X;
            Properties.Settings.Default.FormGiveAnswer_PosY = this.Location.Y;
            Properties.Settings.Default.FormGiveAnswer_SizeWidth = this.Size.Width;
            Properties.Settings.Default.FormGiveAnswer_SizeHeight = this.Size.Height;
            Properties.Settings.Default.Save();
        }
    }
}
