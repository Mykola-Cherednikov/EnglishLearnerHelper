namespace EnglishLearnerHelper
{
    partial class MainForm
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
            panel2 = new Panel();
            label1 = new Label();
            NumOfQuestionsTextBox = new TextBox();
            QuizButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            TranslationTable = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TranslationTable).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(NumOfQuestionsTextBox);
            panel2.Controls.Add(QuizButton);
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(EditButton);
            panel2.Controls.Add(AddButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 461);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(0, 383);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 5;
            label1.Text = "Num of questions:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NumOfQuestionsTextBox
            // 
            NumOfQuestionsTextBox.Dock = DockStyle.Bottom;
            NumOfQuestionsTextBox.Location = new Point(0, 406);
            NumOfQuestionsTextBox.Name = "NumOfQuestionsTextBox";
            NumOfQuestionsTextBox.Size = new Size(136, 23);
            NumOfQuestionsTextBox.TabIndex = 4;
            NumOfQuestionsTextBox.Text = "20";
            NumOfQuestionsTextBox.TextAlign = HorizontalAlignment.Center;
            NumOfQuestionsTextBox.KeyPress += NumOfQuestionsTextBox_KeyPress;
            // 
            // QuizButton
            // 
            QuizButton.Dock = DockStyle.Bottom;
            QuizButton.Font = new Font("Segoe UI", 14F);
            QuizButton.Location = new Point(0, 429);
            QuizButton.Name = "QuizButton";
            QuizButton.Size = new Size(136, 32);
            QuizButton.TabIndex = 3;
            QuizButton.Text = "Quiz";
            QuizButton.UseVisualStyleBackColor = true;
            QuizButton.Click += QuizButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Top;
            DeleteButton.Font = new Font("Segoe UI", 14F);
            DeleteButton.Location = new Point(0, 64);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(136, 32);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Top;
            EditButton.Font = new Font("Segoe UI", 14F);
            EditButton.Location = new Point(0, 32);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(136, 32);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Top;
            AddButton.Font = new Font("Segoe UI", 14F);
            AddButton.Location = new Point(0, 0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(136, 32);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // TranslationTable
            // 
            TranslationTable.AllowUserToAddRows = false;
            TranslationTable.AllowUserToDeleteRows = false;
            TranslationTable.Dock = DockStyle.Fill;
            TranslationTable.Location = new Point(136, 0);
            TranslationTable.MultiSelect = false;
            TranslationTable.Name = "TranslationTable";
            TranslationTable.ReadOnly = true;
            TranslationTable.Size = new Size(668, 461);
            TranslationTable.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(TranslationTable);
            Controls.Add(panel2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TranslationTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private Button QuizButton;
        private Label label1;
        private TextBox NumOfQuestionsTextBox;
        private DataGridView TranslationTable;
    }
}