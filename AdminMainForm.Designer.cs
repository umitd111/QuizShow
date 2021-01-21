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
            this.DisplayContestantsBtn = new System.Windows.Forms.Button();
            this.DisplayQuestionsBtn = new System.Windows.Forms.Button();
            this.DisplayMoneyBtn = new System.Windows.Forms.Button();
            this.moneyLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayContestantsBtn
            // 
            this.DisplayContestantsBtn.Location = new System.Drawing.Point(621, 196);
            this.DisplayContestantsBtn.Name = "DisplayContestantsBtn";
            this.DisplayContestantsBtn.Size = new System.Drawing.Size(163, 59);
            this.DisplayContestantsBtn.TabIndex = 0;
            this.DisplayContestantsBtn.Text = "Display Contestants";
            this.DisplayContestantsBtn.UseVisualStyleBackColor = true;
            // 
            // DisplayQuestionsBtn
            // 
            this.DisplayQuestionsBtn.Location = new System.Drawing.Point(621, 112);
            this.DisplayQuestionsBtn.Name = "DisplayQuestionsBtn";
            this.DisplayQuestionsBtn.Size = new System.Drawing.Size(163, 59);
            this.DisplayQuestionsBtn.TabIndex = 0;
            this.DisplayQuestionsBtn.Text = "Display Questions";
            this.DisplayQuestionsBtn.UseVisualStyleBackColor = true;
            // 
            // DisplayMoneyBtn
            // 
            this.DisplayMoneyBtn.Location = new System.Drawing.Point(621, 285);
            this.DisplayMoneyBtn.Name = "DisplayMoneyBtn";
            this.DisplayMoneyBtn.Size = new System.Drawing.Size(163, 59);
            this.DisplayMoneyBtn.TabIndex = 0;
            this.DisplayMoneyBtn.Text = "Display Total Amount Of Given Money";
            this.DisplayMoneyBtn.UseVisualStyleBackColor = true;
            // 
            // moneyLbl
            // 
            this.moneyLbl.AutoSize = true;
            this.moneyLbl.Location = new System.Drawing.Point(621, 363);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(20, 17);
            this.moneyLbl.TabIndex = 1;
            this.moneyLbl.Text = "fe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display Admins";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 537);
            this.Controls.Add(this.moneyLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayQuestionsBtn);
            this.Controls.Add(this.DisplayMoneyBtn);
            this.Controls.Add(this.DisplayContestantsBtn);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayContestantsBtn;
        private System.Windows.Forms.Button DisplayQuestionsBtn;
        private System.Windows.Forms.Button DisplayMoneyBtn;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Button button1;
    }
}