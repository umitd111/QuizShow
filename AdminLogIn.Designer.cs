namespace QuizShowApplication
{
    partial class adminuserForm
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
            this.adminforgotBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usenameLabel = new System.Windows.Forms.Label();
            this.adminsigninBtn = new System.Windows.Forms.Button();
            this.adminpasswordTxt = new System.Windows.Forms.TextBox();
            this.adminusernameTxt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // adminforgotBtn
            // 
            this.adminforgotBtn.Location = new System.Drawing.Point(343, 280);
            this.adminforgotBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminforgotBtn.Name = "adminforgotBtn";
            this.adminforgotBtn.Size = new System.Drawing.Size(157, 28);
            this.adminforgotBtn.TabIndex = 16;
            this.adminforgotBtn.Text = "I forgot my password";
            this.adminforgotBtn.UseVisualStyleBackColor = true;
            this.adminforgotBtn.Click += new System.EventHandler(this.adminforgotBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(254, 216);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password:";
            // 
            // usenameLabel
            // 
            this.usenameLabel.AutoSize = true;
            this.usenameLabel.Location = new System.Drawing.Point(254, 174);
            this.usenameLabel.Name = "usenameLabel";
            this.usenameLabel.Size = new System.Drawing.Size(83, 17);
            this.usenameLabel.TabIndex = 14;
            this.usenameLabel.Text = "User Name:";
            // 
            // adminsigninBtn
            // 
            this.adminsigninBtn.Location = new System.Drawing.Point(344, 246);
            this.adminsigninBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsigninBtn.Name = "adminsigninBtn";
            this.adminsigninBtn.Size = new System.Drawing.Size(156, 28);
            this.adminsigninBtn.TabIndex = 12;
            this.adminsigninBtn.Text = "Sign In";
            this.adminsigninBtn.UseVisualStyleBackColor = true;
            // 
            // adminpasswordTxt
            // 
            this.adminpasswordTxt.Location = new System.Drawing.Point(344, 213);
            this.adminpasswordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminpasswordTxt.Name = "adminpasswordTxt";
            this.adminpasswordTxt.Size = new System.Drawing.Size(156, 22);
            this.adminpasswordTxt.TabIndex = 11;
            // 
            // adminusernameTxt
            // 
            this.adminusernameTxt.Location = new System.Drawing.Point(344, 171);
            this.adminusernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminusernameTxt.Name = "adminusernameTxt";
            this.adminusernameTxt.Size = new System.Drawing.Size(156, 22);
            this.adminusernameTxt.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Hello admin. Please sign in with your username and password."});
            this.listBox1.Location = new System.Drawing.Point(195, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 20);
            this.listBox1.TabIndex = 17;
            // 
            // adminuserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adminforgotBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usenameLabel);
            this.Controls.Add(this.adminsigninBtn);
            this.Controls.Add(this.adminpasswordTxt);
            this.Controls.Add(this.adminusernameTxt);
            this.Name = "adminuserForm";
            this.Text = "Admin Log In";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminforgotBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usenameLabel;
        private System.Windows.Forms.Button adminsigninBtn;
        private System.Windows.Forms.TextBox adminpasswordTxt;
        private System.Windows.Forms.TextBox adminusernameTxt;
        private System.Windows.Forms.ListBox listBox1;
    }
}