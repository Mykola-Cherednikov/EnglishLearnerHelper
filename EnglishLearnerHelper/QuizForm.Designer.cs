namespace EnglishLearnerHelper
{
    partial class QuizForm
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
            ShowButton = new Button();
            panel2 = new Panel();
            FourthButton = new Button();
            ThirdButton = new Button();
            panel3 = new Panel();
            SecondButton = new Button();
            FirstButton = new Button();
            SentenceLabel = new Label();
            WordLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(SentenceLabel);
            panel1.Controls.Add(WordLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // ShowButton
            // 
            ShowButton.Font = new Font("Segoe UI", 12F);
            ShowButton.Location = new Point(344, 179);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(88, 32);
            ShowButton.TabIndex = 3;
            ShowButton.Text = "Show";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(FourthButton);
            panel2.Controls.Add(ThirdButton);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 200);
            panel2.TabIndex = 2;
            // 
            // FourthButton
            // 
            FourthButton.Dock = DockStyle.Top;
            FourthButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FourthButton.Location = new Point(388, 99);
            FourthButton.Name = "FourthButton";
            FourthButton.Size = new Size(388, 99);
            FourthButton.TabIndex = 2;
            FourthButton.Text = "Fourth";
            FourthButton.UseVisualStyleBackColor = true;
            // 
            // ThirdButton
            // 
            ThirdButton.Dock = DockStyle.Top;
            ThirdButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ThirdButton.Location = new Point(388, 0);
            ThirdButton.Name = "ThirdButton";
            ThirdButton.Size = new Size(388, 99);
            ThirdButton.TabIndex = 1;
            ThirdButton.Text = "Third";
            ThirdButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(SecondButton);
            panel3.Controls.Add(FirstButton);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 200);
            panel3.TabIndex = 0;
            // 
            // SecondButton
            // 
            SecondButton.Dock = DockStyle.Top;
            SecondButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SecondButton.Location = new Point(0, 99);
            SecondButton.Name = "SecondButton";
            SecondButton.Size = new Size(388, 99);
            SecondButton.TabIndex = 1;
            SecondButton.Text = "Second";
            SecondButton.UseVisualStyleBackColor = true;
            // 
            // FirstButton
            // 
            FirstButton.Dock = DockStyle.Top;
            FirstButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstButton.Location = new Point(0, 0);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new Size(388, 99);
            FirstButton.TabIndex = 0;
            FirstButton.Text = "First";
            FirstButton.UseVisualStyleBackColor = true;
            // 
            // SentenceLabel
            // 
            SentenceLabel.Dock = DockStyle.Top;
            SentenceLabel.Font = new Font("Segoe UI", 12F);
            SentenceLabel.Location = new Point(0, 80);
            SentenceLabel.Name = "SentenceLabel";
            SentenceLabel.Size = new Size(776, 80);
            SentenceLabel.TabIndex = 1;
            SentenceLabel.Text = "Sentence";
            SentenceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WordLabel
            // 
            WordLabel.Dock = DockStyle.Top;
            WordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WordLabel.Location = new Point(0, 0);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(776, 80);
            WordLabel.TabIndex = 0;
            WordLabel.Text = "Word";
            WordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QuizForm";
            Text = "QuizForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label SentenceLabel;
        private Label WordLabel;
        private Button ShowButton;
        private Button FourthButton;
        private Button ThirdButton;
        private Button SecondButton;
        private Button FirstButton;
    }
}