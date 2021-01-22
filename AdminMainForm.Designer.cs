namespace QuizShowApplication
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.DisplayContestantsBtn = new System.Windows.Forms.Button();
            this.DisplayQuestionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayContestantsBtn
            // 
            this.DisplayContestantsBtn.Location = new System.Drawing.Point(536, 159);
            this.DisplayContestantsBtn.Name = "DisplayContestantsBtn";
            this.DisplayContestantsBtn.Size = new System.Drawing.Size(284, 151);
            this.DisplayContestantsBtn.TabIndex = 0;
            this.DisplayContestantsBtn.Text = "Display Contestants";
            this.DisplayContestantsBtn.UseVisualStyleBackColor = true;
            this.DisplayContestantsBtn.Click += new System.EventHandler(this.DisplayContestantsBtn_Click);
            // 
            // DisplayQuestionsBtn
            // 
            this.DisplayQuestionsBtn.Location = new System.Drawing.Point(153, 159);
            this.DisplayQuestionsBtn.Name = "DisplayQuestionsBtn";
            this.DisplayQuestionsBtn.Size = new System.Drawing.Size(284, 151);
            this.DisplayQuestionsBtn.TabIndex = 0;
            this.DisplayQuestionsBtn.Text = "Display Questions";
            this.DisplayQuestionsBtn.UseVisualStyleBackColor = true;
            this.DisplayQuestionsBtn.Click += new System.EventHandler(this.DisplayQuestionsBtn_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 509);
            this.Controls.Add(this.DisplayQuestionsBtn);
            this.Controls.Add(this.DisplayContestantsBtn);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayContestantsBtn;
        private System.Windows.Forms.Button DisplayQuestionsBtn;
    }
}