namespace AssessmentHelper
{
    partial class FormAddResult
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
            this.m_listAnswers = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_edtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_ckSolved = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // m_listAnswers
            // 
            this.m_listAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_listAnswers.CheckOnClick = true;
            this.m_listAnswers.FormattingEnabled = true;
            this.m_listAnswers.Location = new System.Drawing.Point(134, 77);
            this.m_listAnswers.Name = "m_listAnswers";
            this.m_listAnswers.Size = new System.Drawing.Size(654, 319);
            this.m_listAnswers.Sorted = true;
            this.m_listAnswers.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Antworten:";
            // 
            // m_edtQuestion
            // 
            this.m_edtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_edtQuestion.Enabled = false;
            this.m_edtQuestion.Location = new System.Drawing.Point(134, 11);
            this.m_edtQuestion.Multiline = true;
            this.m_edtQuestion.Name = "m_edtQuestion";
            this.m_edtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_edtQuestion.Size = new System.Drawing.Size(654, 39);
            this.m_edtQuestion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frage:";
            // 
            // m_btnClose
            // 
            this.m_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnClose.Location = new System.Drawing.Point(713, 416);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(75, 23);
            this.m_btnClose.TabIndex = 6;
            this.m_btnClose.Text = "Abbrechen";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.m_btnClose_Click);
            // 
            // m_btnOK
            // 
            this.m_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(632, 416);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 11;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.m_btnOK_Click);
            // 
            // m_ckSolved
            // 
            this.m_ckSolved.AutoSize = true;
            this.m_ckSolved.Location = new System.Drawing.Point(134, 56);
            this.m_ckSolved.Name = "m_ckSolved";
            this.m_ckSolved.Size = new System.Drawing.Size(202, 17);
            this.m_ckSolved.TabIndex = 12;
            this.m_ckSolved.Text = "Die Frage wurde korrekt beantwortet.";
            this.m_ckSolved.UseVisualStyleBackColor = true;
            // 
            // FormAddResult
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_ckSolved);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_listAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_edtQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnClose);
            this.Name = "FormAddResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ergebnis eingeben";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddResult_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox m_listAnswers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_edtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.CheckBox m_ckSolved;
    }
}