namespace AssessmentHelper
{
    partial class FormAddQuestion
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
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_edtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_editAnswer = new System.Windows.Forms.TextBox();
            this.m_btnAdd = new System.Windows.Forms.Button();
            this.m_listAnswers = new System.Windows.Forms.ListView();
            this.columnAnswers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_edtNbAnswers = new System.Windows.Forms.TextBox();
            this.m_rbNbAnswers = new System.Windows.Forms.RadioButton();
            this.m_rbUnknownAnswers = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(631, 476);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 0;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.m_btnOK_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(712, 476);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 1;
            this.m_btnCancel.Text = "Abbrechen";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.m_btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frage:";
            // 
            // m_edtText
            // 
            this.m_edtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_edtText.Location = new System.Drawing.Point(81, 9);
            this.m_edtText.Multiline = true;
            this.m_edtText.Name = "m_edtText";
            this.m_edtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_edtText.Size = new System.Drawing.Size(707, 50);
            this.m_edtText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Antwort:";
            // 
            // m_editAnswer
            // 
            this.m_editAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_editAnswer.Location = new System.Drawing.Point(81, 75);
            this.m_editAnswer.Multiline = true;
            this.m_editAnswer.Name = "m_editAnswer";
            this.m_editAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_editAnswer.Size = new System.Drawing.Size(707, 44);
            this.m_editAnswer.TabIndex = 5;
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.Location = new System.Drawing.Point(81, 125);
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Size = new System.Drawing.Size(75, 23);
            this.m_btnAdd.TabIndex = 6;
            this.m_btnAdd.Text = "Hinzufügen";
            this.m_btnAdd.UseVisualStyleBackColor = true;
            this.m_btnAdd.Click += new System.EventHandler(this.m_btnAdd_Click);
            // 
            // m_listAnswers
            // 
            this.m_listAnswers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAnswers});
            this.m_listAnswers.Location = new System.Drawing.Point(81, 155);
            this.m_listAnswers.MultiSelect = false;
            this.m_listAnswers.Name = "m_listAnswers";
            this.m_listAnswers.Size = new System.Drawing.Size(707, 204);
            this.m_listAnswers.TabIndex = 7;
            this.m_listAnswers.UseCompatibleStateImageBehavior = false;
            this.m_listAnswers.View = System.Windows.Forms.View.Details;
            this.m_listAnswers.SelectedIndexChanged += new System.EventHandler(this.m_listAnswers_SelectedIndexChanged);
            // 
            // columnAnswers
            // 
            this.columnAnswers.Text = "Antworten";
            this.columnAnswers.Width = 702;
            // 
            // m_btnDelete
            // 
            this.m_btnDelete.Location = new System.Drawing.Point(162, 126);
            this.m_btnDelete.Name = "m_btnDelete";
            this.m_btnDelete.Size = new System.Drawing.Size(75, 23);
            this.m_btnDelete.TabIndex = 8;
            this.m_btnDelete.Text = "Löschen";
            this.m_btnDelete.UseVisualStyleBackColor = true;
            this.m_btnDelete.Click += new System.EventHandler(this.m_btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_edtNbAnswers);
            this.groupBox1.Controls.Add(this.m_rbNbAnswers);
            this.groupBox1.Controls.Add(this.m_rbUnknownAnswers);
            this.groupBox1.Location = new System.Drawing.Point(81, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anzahl auszuwählender Antworten";
            // 
            // m_edtNbAnswers
            // 
            this.m_edtNbAnswers.Location = new System.Drawing.Point(98, 43);
            this.m_edtNbAnswers.Name = "m_edtNbAnswers";
            this.m_edtNbAnswers.Size = new System.Drawing.Size(95, 20);
            this.m_edtNbAnswers.TabIndex = 2;
            // 
            // m_rbNbAnswers
            // 
            this.m_rbNbAnswers.AutoSize = true;
            this.m_rbNbAnswers.Location = new System.Drawing.Point(7, 44);
            this.m_rbNbAnswers.Name = "m_rbNbAnswers";
            this.m_rbNbAnswers.Size = new System.Drawing.Size(60, 17);
            this.m_rbNbAnswers.TabIndex = 1;
            this.m_rbNbAnswers.Text = "Anzahl:";
            this.m_rbNbAnswers.UseVisualStyleBackColor = true;
            this.m_rbNbAnswers.CheckedChanged += new System.EventHandler(this.m_rbNbAnswers_CheckedChanged);
            // 
            // m_rbUnknownAnswers
            // 
            this.m_rbUnknownAnswers.AutoSize = true;
            this.m_rbUnknownAnswers.Checked = true;
            this.m_rbUnknownAnswers.Location = new System.Drawing.Point(7, 20);
            this.m_rbUnknownAnswers.Name = "m_rbUnknownAnswers";
            this.m_rbUnknownAnswers.Size = new System.Drawing.Size(78, 17);
            this.m_rbUnknownAnswers.TabIndex = 0;
            this.m_rbUnknownAnswers.TabStop = true;
            this.m_rbUnknownAnswers.Text = "Unbekannt";
            this.m_rbUnknownAnswers.UseVisualStyleBackColor = true;
            // 
            // FormAddQuestion
            // 
            this.AcceptButton = this.m_btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnDelete);
            this.Controls.Add(this.m_listAnswers);
            this.Controls.Add(this.m_btnAdd);
            this.Controls.Add(this.m_editAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_edtText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOK);
            this.Name = "FormAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frage hinzufügen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddQuestion_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_edtText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_editAnswer;
        private System.Windows.Forms.Button m_btnAdd;
        private System.Windows.Forms.ListView m_listAnswers;
        private System.Windows.Forms.ColumnHeader columnAnswers;
        private System.Windows.Forms.Button m_btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_edtNbAnswers;
        private System.Windows.Forms.RadioButton m_rbNbAnswers;
        private System.Windows.Forms.RadioButton m_rbUnknownAnswers;
    }
}