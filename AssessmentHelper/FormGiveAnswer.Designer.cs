namespace AssessmentHelper
{
    partial class FormGiveAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_edtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_listAnswers = new System.Windows.Forms.CheckedListBox();
            this.m_btnOther = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_btnClose
            // 
            this.m_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnClose.Location = new System.Drawing.Point(713, 415);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(75, 23);
            this.m_btnClose.TabIndex = 0;
            this.m_btnClose.Text = "Schließen";
            this.m_btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frage:";
            // 
            // m_edtQuestion
            // 
            this.m_edtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_edtQuestion.Enabled = false;
            this.m_edtQuestion.Location = new System.Drawing.Point(134, 10);
            this.m_edtQuestion.Multiline = true;
            this.m_edtQuestion.Name = "m_edtQuestion";
            this.m_edtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_edtQuestion.Size = new System.Drawing.Size(654, 39);
            this.m_edtQuestion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antwortsvorschlag:";
            // 
            // m_listAnswers
            // 
            this.m_listAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_listAnswers.FormattingEnabled = true;
            this.m_listAnswers.Location = new System.Drawing.Point(134, 61);
            this.m_listAnswers.Name = "m_listAnswers";
            this.m_listAnswers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.m_listAnswers.Size = new System.Drawing.Size(654, 334);
            this.m_listAnswers.TabIndex = 4;
            // 
            // m_btnOther
            // 
            this.m_btnOther.Location = new System.Drawing.Point(12, 77);
            this.m_btnOther.Name = "m_btnOther";
            this.m_btnOther.Size = new System.Drawing.Size(94, 34);
            this.m_btnOther.TabIndex = 5;
            this.m_btnOther.Text = "anderer Vorschlag";
            this.m_btnOther.UseVisualStyleBackColor = true;
            this.m_btnOther.Click += new System.EventHandler(this.m_btnOther_Click);
            // 
            // FormGiveAnswer
            // 
            this.AcceptButton = this.m_btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_btnOther);
            this.Controls.Add(this.m_listAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_edtQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnClose);
            this.Name = "FormGiveAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Antwort vorschlagen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGiveAnswer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_edtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox m_listAnswers;
        private System.Windows.Forms.Button m_btnOther;
    }
}