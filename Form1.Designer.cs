
namespace Proiect_CSharp
{
    partial class Form1
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
            this.ExitTab = new System.Windows.Forms.TabPage();
            this.tabPageQuiz = new System.Windows.Forms.TabPage();
            this.startQuizButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.quizWordLabel = new System.Windows.Forms.Label();
            this.tabPageVocabulary = new System.Windows.Forms.TabPage();
            this.ImportListButton = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TextBoxMeaning = new System.Windows.Forms.TextBox();
            this.TextBoxWord = new System.Windows.Forms.TextBox();
            this.vocabularyListView = new System.Windows.Forms.ListView();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageQuiz.SuspendLayout();
            this.tabPageVocabulary.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitTab
            // 
            this.ExitTab.Location = new System.Drawing.Point(4, 25);
            this.ExitTab.Name = "ExitTab";
            this.ExitTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExitTab.Size = new System.Drawing.Size(480, 401);
            this.ExitTab.TabIndex = 3;
            this.ExitTab.Text = "Exit and Save";
            this.ExitTab.UseVisualStyleBackColor = true;
            // 
            // tabPageQuiz
            // 
            this.tabPageQuiz.Controls.Add(this.startQuizButton);
            this.tabPageQuiz.Controls.Add(this.submitButton);
            this.tabPageQuiz.Controls.Add(this.answerTextBox);
            this.tabPageQuiz.Controls.Add(this.quizWordLabel);
            this.tabPageQuiz.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuiz.Size = new System.Drawing.Size(480, 401);
            this.tabPageQuiz.TabIndex = 1;
            this.tabPageQuiz.Text = "Quiz";
            this.tabPageQuiz.UseVisualStyleBackColor = true;
            // 
            // startQuizButton
            // 
            this.startQuizButton.Location = new System.Drawing.Point(93, 26);
            this.startQuizButton.Name = "startQuizButton";
            this.startQuizButton.Size = new System.Drawing.Size(75, 23);
            this.startQuizButton.TabIndex = 3;
            this.startQuizButton.Text = "Start Quiz";
            this.startQuizButton.UseVisualStyleBackColor = true;
            this.startQuizButton.Click += new System.EventHandler(this.startQuizButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(93, 216);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(96, 26);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(48, 172);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(194, 22);
            this.answerTextBox.TabIndex = 1;
            // 
            // quizWordLabel
            // 
            this.quizWordLabel.AutoSize = true;
            this.quizWordLabel.Location = new System.Drawing.Point(45, 79);
            this.quizWordLabel.Name = "quizWordLabel";
            this.quizWordLabel.Size = new System.Drawing.Size(0, 17);
            this.quizWordLabel.TabIndex = 0;
            // 
            // tabPageVocabulary
            // 
            this.tabPageVocabulary.Controls.Add(this.ImportListButton);
            this.tabPageVocabulary.Controls.Add(this.buttonUpdate);
            this.tabPageVocabulary.Controls.Add(this.buttonDelete);
            this.tabPageVocabulary.Controls.Add(this.buttonEdit);
            this.tabPageVocabulary.Controls.Add(this.buttonAdd);
            this.tabPageVocabulary.Controls.Add(this.TextBoxMeaning);
            this.tabPageVocabulary.Controls.Add(this.TextBoxWord);
            this.tabPageVocabulary.Controls.Add(this.vocabularyListView);
            this.tabPageVocabulary.Location = new System.Drawing.Point(4, 25);
            this.tabPageVocabulary.Name = "tabPageVocabulary";
            this.tabPageVocabulary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVocabulary.Size = new System.Drawing.Size(480, 401);
            this.tabPageVocabulary.TabIndex = 0;
            this.tabPageVocabulary.Text = "Vocabulary";
            this.tabPageVocabulary.UseVisualStyleBackColor = true;
            // 
            // ImportListButton
            // 
            this.ImportListButton.Location = new System.Drawing.Point(283, 361);
            this.ImportListButton.Name = "ImportListButton";
            this.ImportListButton.Size = new System.Drawing.Size(75, 23);
            this.ImportListButton.TabIndex = 5;
            this.ImportListButton.Text = "Import List";
            this.ImportListButton.UseVisualStyleBackColor = true;
            this.ImportListButton.Click += new System.EventHandler(this.ImportListButton_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(97, 248);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(48, 332);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(6, 248);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(48, 167);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TextBoxMeaning
            // 
            this.TextBoxMeaning.Location = new System.Drawing.Point(20, 114);
            this.TextBoxMeaning.Name = "TextBoxMeaning";
            this.TextBoxMeaning.Size = new System.Drawing.Size(135, 22);
            this.TextBoxMeaning.TabIndex = 1;
            // 
            // TextBoxWord
            // 
            this.TextBoxWord.Location = new System.Drawing.Point(20, 64);
            this.TextBoxWord.Name = "TextBoxWord";
            this.TextBoxWord.Size = new System.Drawing.Size(135, 22);
            this.TextBoxWord.TabIndex = 0;
            // 
            // vocabularyListView
            // 
            this.vocabularyListView.FullRowSelect = true;
            this.vocabularyListView.HideSelection = false;
            this.vocabularyListView.Location = new System.Drawing.Point(188, 18);
            this.vocabularyListView.Name = "vocabularyListView";
            this.vocabularyListView.Size = new System.Drawing.Size(252, 337);
            this.vocabularyListView.TabIndex = 3;
            this.vocabularyListView.UseCompatibleStateImageBehavior = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPageVocabulary);
            this.TabControl1.Controls.Add(this.tabPageQuiz);
            this.TabControl1.Controls.Add(this.ExitTab);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(488, 430);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ExitTab_Selecting);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 474);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPageQuiz.ResumeLayout(false);
            this.tabPageQuiz.PerformLayout();
            this.tabPageVocabulary.ResumeLayout(false);
            this.tabPageVocabulary.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ExitTab;
        private System.Windows.Forms.TabPage tabPageQuiz;
        private System.Windows.Forms.Button startQuizButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label quizWordLabel;
        private System.Windows.Forms.TabPage tabPageVocabulary;
        private System.Windows.Forms.Button ImportListButton;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox TextBoxMeaning;
        private System.Windows.Forms.TextBox TextBoxWord;
        private System.Windows.Forms.ListView vocabularyListView;
        private System.Windows.Forms.TabControl TabControl1;
    }
}