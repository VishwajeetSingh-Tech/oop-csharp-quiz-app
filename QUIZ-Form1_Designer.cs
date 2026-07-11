namespace QuizApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestionNumber = new Label();
            lblQuestion = new Label();
            radioOptionA = new RadioButton();
            radioOptionB = new RadioButton();
            radioOptionC = new RadioButton();
            radioOptionD = new RadioButton();
            btnStart = new Button();
            btnNext = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(22, 19);
            lblQuestionNumber.Margin = new Padding(6, 0, 6, 0);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(153, 32);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "Question 0/0";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(22, 75);
            lblQuestion.Margin = new Padding(6, 0, 6, 0);
            lblQuestion.MaximumSize = new Size(742, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(111, 32);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question";
            // 
            // radioOptionA
            // 
            radioOptionA.AutoSize = true;
            radioOptionA.Location = new Point(27, 171);
            radioOptionA.Margin = new Padding(6, 6, 6, 6);
            radioOptionA.Name = "radioOptionA";
            radioOptionA.Size = new Size(141, 36);
            radioOptionA.TabIndex = 2;
            radioOptionA.TabStop = true;
            radioOptionA.Text = "Option A";
            radioOptionA.UseVisualStyleBackColor = true;
            // 
            // radioOptionB
            // 
            radioOptionB.AutoSize = true;
            radioOptionB.Location = new Point(27, 224);
            radioOptionB.Margin = new Padding(6, 6, 6, 6);
            radioOptionB.Name = "radioOptionB";
            radioOptionB.Size = new Size(140, 36);
            radioOptionB.TabIndex = 3;
            radioOptionB.TabStop = true;
            radioOptionB.Text = "Option B";
            radioOptionB.UseVisualStyleBackColor = true;
            radioOptionB.CheckedChanged += radioOptionB_CheckedChanged;
            // 
            // radioOptionC
            // 
            radioOptionC.AutoSize = true;
            radioOptionC.Location = new Point(27, 277);
            radioOptionC.Margin = new Padding(6, 6, 6, 6);
            radioOptionC.Name = "radioOptionC";
            radioOptionC.Size = new Size(141, 36);
            radioOptionC.TabIndex = 4;
            radioOptionC.TabStop = true;
            radioOptionC.Text = "Option C";
            radioOptionC.UseVisualStyleBackColor = true;
            // 
            // radioOptionD
            // 
            radioOptionD.AutoSize = true;
            radioOptionD.Location = new Point(27, 331);
            radioOptionD.Margin = new Padding(6, 6, 6, 6);
            radioOptionD.Name = "radioOptionD";
            radioOptionD.Size = new Size(143, 36);
            radioOptionD.TabIndex = 5;
            radioOptionD.TabStop = true;
            radioOptionD.Text = "Option D";
            radioOptionD.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(27, 427);
            btnStart.Margin = new Padding(6, 6, 6, 6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(139, 50);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(178, 427);
            btnNext.Margin = new Padding(6, 6, 6, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(139, 50);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 593);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 8;
            label1.Text = "Interactive Quiz Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 853);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(btnStart);
            Controls.Add(radioOptionD);
            Controls.Add(radioOptionC);
            Controls.Add(radioOptionB);
            Controls.Add(radioOptionA);
            Controls.Add(lblQuestion);
            Controls.Add(lblQuestionNumber);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Interactive Quiz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestionNumber;
        private Label lblQuestion;
        private RadioButton radioOptionA;
        private RadioButton radioOptionB;
        private RadioButton radioOptionC;
        private RadioButton radioOptionD;
        private Button btnStart;
        private Button btnNext;
        private Label label1;
    }
}