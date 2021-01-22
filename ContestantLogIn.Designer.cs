namespace QuizShowApplication
{
    partial class contesterloginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contesterloginForm));
            this.userusernameTxt = new System.Windows.Forms.TextBox();
            this.userpasswordTxt = new System.Windows.Forms.TextBox();
            this.usersigninBtn = new System.Windows.Forms.Button();
            this.userregisterBtn = new System.Windows.Forms.Button();
            this.usenameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // userusernameTxt
            // 
            this.userusernameTxt.Location = new System.Drawing.Point(349, 172);
            this.userusernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userusernameTxt.Name = "userusernameTxt";
            this.userusernameTxt.Size = new System.Drawing.Size(156, 22);
            this.userusernameTxt.TabIndex = 0;
            // 
            // userpasswordTxt
            // 
            this.userpasswordTxt.Location = new System.Drawing.Point(349, 214);
            this.userpasswordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userpasswordTxt.Name = "userpasswordTxt";
            this.userpasswordTxt.Size = new System.Drawing.Size(156, 22);
            this.userpasswordTxt.TabIndex = 1;
            this.userpasswordTxt.UseSystemPasswordChar = true;
            // 
            // usersigninBtn
            // 
            this.usersigninBtn.Location = new System.Drawing.Point(349, 244);
            this.usersigninBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersigninBtn.Name = "usersigninBtn";
            this.usersigninBtn.Size = new System.Drawing.Size(75, 28);
            this.usersigninBtn.TabIndex = 2;
            this.usersigninBtn.Text = "Sign In";
            this.usersigninBtn.UseVisualStyleBackColor = true;
            this.usersigninBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // userregisterBtn
            // 
            this.userregisterBtn.Location = new System.Drawing.Point(429, 244);
            this.userregisterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userregisterBtn.Name = "userregisterBtn";
            this.userregisterBtn.Size = new System.Drawing.Size(75, 28);
            this.userregisterBtn.TabIndex = 3;
            this.userregisterBtn.Text = "Register";
            this.userregisterBtn.UseVisualStyleBackColor = true;
            this.userregisterBtn.Click += new System.EventHandler(this.userregisterBtn_Click);
            // 
            // usenameLabel
            // 
            this.usenameLabel.AutoSize = true;
            this.usenameLabel.Location = new System.Drawing.Point(259, 175);
            this.usenameLabel.Name = "usenameLabel";
            this.usenameLabel.Size = new System.Drawing.Size(83, 17);
            this.usenameLabel.TabIndex = 4;
            this.usenameLabel.Text = "User Name:";
            this.usenameLabel.Click += new System.EventHandler(this.usenameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(259, 217);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "\tWelcome to the quiz show. Please enter yoru name and password to enter ",
            "the program. If you don\'t have an account, please left click on register button."});
            this.listBox1.Location = new System.Drawing.Point(156, 111);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(512, 36);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contesterloginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 447);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usenameLabel);
            this.Controls.Add(this.userregisterBtn);
            this.Controls.Add(this.usersigninBtn);
            this.Controls.Add(this.userpasswordTxt);
            this.Controls.Add(this.userusernameTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "contesterloginForm";
            this.Text = "Contestant Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userpasswordTxt;
        private System.Windows.Forms.Button usersigninBtn;
        private System.Windows.Forms.Button userregisterBtn;
        private System.Windows.Forms.Label usenameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox userusernameTxt;
    }
}

