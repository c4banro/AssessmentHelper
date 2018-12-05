namespace AssessmentHelper
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.m_edtAssessmentName = new System.Windows.Forms.TextBox();
            this.m_btnSynchrinise = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_listQuestions = new System.Windows.Forms.ListView();
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnswered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRemainAnswers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_edtFilter = new System.Windows.Forms.TextBox();
            this.m_btnAddQuestion = new System.Windows.Forms.Button();
            this.m_btnDeleteQuestion = new System.Windows.Forms.Button();
            this.m_btnGiveAnswer = new System.Windows.Forms.Button();
            this.m_btnEnterResult = new System.Windows.Forms.Button();
            this.m_btnInsertClipboard = new System.Windows.Forms.Button();
            this.m_btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment:";
            // 
            // m_edtAssessmentName
            // 
            this.m_edtAssessmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_edtAssessmentName.Location = new System.Drawing.Point(123, 10);
            this.m_edtAssessmentName.Name = "m_edtAssessmentName";
            this.m_edtAssessmentName.ReadOnly = true;
            this.m_edtAssessmentName.Size = new System.Drawing.Size(665, 20);
            this.m_edtAssessmentName.TabIndex = 1;
            // 
            // m_btnSynchrinise
            // 
            this.m_btnSynchrinise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnSynchrinise.Location = new System.Drawing.Point(680, 415);
            this.m_btnSynchrinise.Name = "m_btnSynchrinise";
            this.m_btnSynchrinise.Size = new System.Drawing.Size(108, 23);
            this.m_btnSynchrinise.TabIndex = 2;
            this.m_btnSynchrinise.Text = "Synchronisieren";
            this.m_btnSynchrinise.UseVisualStyleBackColor = true;
            this.m_btnSynchrinise.Click += new System.EventHandler(this.m_btnSynchronize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter:";
            // 
            // m_listQuestions
            // 
            this.m_listQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_listQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnText,
            this.columnAnswered,
            this.columnRemainAnswers});
            this.m_listQuestions.FullRowSelect = true;
            this.m_listQuestions.HideSelection = false;
            this.m_listQuestions.Location = new System.Drawing.Point(16, 112);
            this.m_listQuestions.MultiSelect = false;
            this.m_listQuestions.Name = "m_listQuestions";
            this.m_listQuestions.Size = new System.Drawing.Size(772, 297);
            this.m_listQuestions.TabIndex = 4;
            this.m_listQuestions.UseCompatibleStateImageBehavior = false;
            this.m_listQuestions.View = System.Windows.Forms.View.Details;
            this.m_listQuestions.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.m_listQuestions_ItemSelectionChanged);
            // 
            // columnText
            // 
            this.columnText.Text = "Frage";
            this.columnText.Width = 646;
            // 
            // columnAnswered
            // 
            this.columnAnswered.Text = "Beantworted";
            // 
            // columnRemainAnswers
            // 
            this.columnRemainAnswers.Text = "Ausstehend";
            // 
            // m_edtFilter
            // 
            this.m_edtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_edtFilter.Location = new System.Drawing.Point(123, 84);
            this.m_edtFilter.Name = "m_edtFilter";
            this.m_edtFilter.Size = new System.Drawing.Size(590, 20);
            this.m_edtFilter.TabIndex = 5;
            this.m_edtFilter.TextChanged += new System.EventHandler(this.m_edtFilter_TextChanged);
            // 
            // m_btnAddQuestion
            // 
            this.m_btnAddQuestion.Location = new System.Drawing.Point(123, 37);
            this.m_btnAddQuestion.Name = "m_btnAddQuestion";
            this.m_btnAddQuestion.Size = new System.Drawing.Size(120, 23);
            this.m_btnAddQuestion.TabIndex = 6;
            this.m_btnAddQuestion.Text = "Frage hinzufügen";
            this.m_btnAddQuestion.UseVisualStyleBackColor = true;
            this.m_btnAddQuestion.Click += new System.EventHandler(this.m_btnAddQuestion_Click);
            // 
            // m_btnDeleteQuestion
            // 
            this.m_btnDeleteQuestion.Location = new System.Drawing.Point(249, 37);
            this.m_btnDeleteQuestion.Name = "m_btnDeleteQuestion";
            this.m_btnDeleteQuestion.Size = new System.Drawing.Size(111, 23);
            this.m_btnDeleteQuestion.TabIndex = 7;
            this.m_btnDeleteQuestion.Text = "Frage löschen";
            this.m_btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.m_btnDeleteQuestion.Click += new System.EventHandler(this.m_btnDeleteQuestion_Click);
            // 
            // m_btnGiveAnswer
            // 
            this.m_btnGiveAnswer.Location = new System.Drawing.Point(366, 37);
            this.m_btnGiveAnswer.Name = "m_btnGiveAnswer";
            this.m_btnGiveAnswer.Size = new System.Drawing.Size(128, 23);
            this.m_btnGiveAnswer.TabIndex = 8;
            this.m_btnGiveAnswer.Text = "Antwort vorschlagen";
            this.m_btnGiveAnswer.UseVisualStyleBackColor = true;
            this.m_btnGiveAnswer.Click += new System.EventHandler(this.m_btnGiveAnswer_Click);
            // 
            // m_btnEnterResult
            // 
            this.m_btnEnterResult.Location = new System.Drawing.Point(500, 36);
            this.m_btnEnterResult.Name = "m_btnEnterResult";
            this.m_btnEnterResult.Size = new System.Drawing.Size(131, 23);
            this.m_btnEnterResult.TabIndex = 9;
            this.m_btnEnterResult.Text = "Ergebnis eingeben";
            this.m_btnEnterResult.UseVisualStyleBackColor = true;
            this.m_btnEnterResult.Click += new System.EventHandler(this.m_btnEnterResult_Click);
            // 
            // m_btnInsertClipboard
            // 
            this.m_btnInsertClipboard.Location = new System.Drawing.Point(720, 84);
            this.m_btnInsertClipboard.Name = "m_btnInsertClipboard";
            this.m_btnInsertClipboard.Size = new System.Drawing.Size(28, 23);
            this.m_btnInsertClipboard.TabIndex = 10;
            this.m_btnInsertClipboard.Text = "^V";
            this.m_btnInsertClipboard.UseVisualStyleBackColor = true;
            this.m_btnInsertClipboard.Click += new System.EventHandler(this.m_btnInsertClipboard_Click);
            // 
            // m_btnClear
            // 
            this.m_btnClear.Location = new System.Drawing.Point(754, 84);
            this.m_btnClear.Name = "m_btnClear";
            this.m_btnClear.Size = new System.Drawing.Size(23, 24);
            this.m_btnClear.TabIndex = 11;
            this.m_btnClear.Text = "C";
            this.m_btnClear.UseVisualStyleBackColor = true;
            this.m_btnClear.Click += new System.EventHandler(this.m_btnClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_btnClear);
            this.Controls.Add(this.m_btnInsertClipboard);
            this.Controls.Add(this.m_btnEnterResult);
            this.Controls.Add(this.m_btnGiveAnswer);
            this.Controls.Add(this.m_btnDeleteQuestion);
            this.Controls.Add(this.m_btnAddQuestion);
            this.Controls.Add(this.m_edtFilter);
            this.Controls.Add(this.m_listQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_btnSynchrinise);
            this.Controls.Add(this.m_edtAssessmentName);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AssessmentHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_edtAssessmentName;
        private System.Windows.Forms.Button m_btnSynchrinise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView m_listQuestions;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.ColumnHeader columnAnswered;
        private System.Windows.Forms.ColumnHeader columnRemainAnswers;
        private System.Windows.Forms.TextBox m_edtFilter;
        private System.Windows.Forms.Button m_btnAddQuestion;
        private System.Windows.Forms.Button m_btnDeleteQuestion;
        private System.Windows.Forms.Button m_btnGiveAnswer;
        private System.Windows.Forms.Button m_btnEnterResult;
        private System.Windows.Forms.Button m_btnInsertClipboard;
        private System.Windows.Forms.Button m_btnClear;
    }
}

