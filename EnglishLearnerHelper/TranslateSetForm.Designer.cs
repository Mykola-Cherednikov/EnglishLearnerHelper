namespace EnglishLearnerHelper
{
    partial class TranslateSetForm
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
            panel1 = new Panel();
            ThisCancelButton = new Button();
            OkButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SentenceTextBox = new TextBox();
            TranslatedTextBox = new TextBox();
            OriginalTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ThisCancelButton);
            panel1.Controls.Add(OkButton);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 340);
            panel1.TabIndex = 0;
            // 
            // ThisCancelButton
            // 
            ThisCancelButton.Font = new Font("Segoe UI", 13F);
            ThisCancelButton.Location = new Point(205, 304);
            ThisCancelButton.Name = "ThisCancelButton";
            ThisCancelButton.Size = new Size(75, 33);
            ThisCancelButton.TabIndex = 2;
            ThisCancelButton.Text = "Cancel";
            ThisCancelButton.UseVisualStyleBackColor = true;
            ThisCancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Font = new Font("Segoe UI", 14F);
            OkButton.Location = new Point(3, 304);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 33);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(SentenceTextBox);
            panel2.Controls.Add(TranslatedTextBox);
            panel2.Controls.Add(OriginalTextBox);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 295);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 6;
            label3.Text = "Sentence";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 76);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 5;
            label2.Text = "Translated";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 4;
            label1.Text = "Original";
            // 
            // SentenceTextBox
            // 
            SentenceTextBox.Font = new Font("Segoe UI", 12F);
            SentenceTextBox.Location = new Point(100, 131);
            SentenceTextBox.Name = "SentenceTextBox";
            SentenceTextBox.Size = new Size(177, 29);
            SentenceTextBox.TabIndex = 3;
            // 
            // TranslatedTextBox
            // 
            TranslatedTextBox.Font = new Font("Segoe UI", 12F);
            TranslatedTextBox.Location = new Point(100, 73);
            TranslatedTextBox.Name = "TranslatedTextBox";
            TranslatedTextBox.Size = new Size(177, 29);
            TranslatedTextBox.TabIndex = 1;
            // 
            // OriginalTextBox
            // 
            OriginalTextBox.Font = new Font("Segoe UI", 12F);
            OriginalTextBox.Location = new Point(100, 15);
            OriginalTextBox.Name = "OriginalTextBox";
            OriginalTextBox.Size = new Size(177, 29);
            OriginalTextBox.TabIndex = 0;
            // 
            // TranslateSetForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ThisCancelButton;
            ClientSize = new Size(310, 364);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TranslateSetForm";
            Text = "TranslateSetForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button OkButton;
        private Panel panel2;
        private Button ThisCancelButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox SentenceTextBox;
        private TextBox TranslatedTextBox;
        private TextBox OriginalTextBox;
    }
}