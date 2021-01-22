namespace QuizShowApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.label1 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.questionNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(176, 123);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(410, 22);
            this.question.TabIndex = 1;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(198, 180);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(168, 46);
            this.a.TabIndex = 2;
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(198, 273);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(168, 46);
            this.b.TabIndex = 2;
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(387, 180);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(168, 46);
            this.c.TabIndex = 2;
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(387, 273);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(168, 46);
            this.d.TabIndex = 2;
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // questionNumber
            // 
            this.questionNumber.AutoSize = true;
            this.questionNumber.Location = new System.Drawing.Point(242, 87);
            this.questionNumber.Name = "questionNumber";
            this.questionNumber.Size = new System.Drawing.Size(16, 17);
            this.questionNumber.TabIndex = 0;
            this.questionNumber.Text = "1";
            this.questionNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question Prize:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // prize
            // 
            this.prize.AutoSize = true;
            this.prize.Location = new System.Drawing.Point(570, 87);
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(48, 17);
            this.prize.TabIndex = 0;
            this.prize.Text = "10000";
            this.prize.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(62, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.question);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.questionNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prize;
        private System.Windows.Forms.Label questionNumber;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
    }
}