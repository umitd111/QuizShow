namespace QuizShowApplication
{
    partial class ContestantInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContestantInformationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.moneyInfoLbl = new System.Windows.Forms.Label();
            this.moneyLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameInfoLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.surnameInfoLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phonenumberLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select The Contestant";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // moneyInfoLbl
            // 
            this.moneyInfoLbl.AutoSize = true;
            this.moneyInfoLbl.Location = new System.Drawing.Point(288, 307);
            this.moneyInfoLbl.Name = "moneyInfoLbl";
            this.moneyInfoLbl.Size = new System.Drawing.Size(262, 17);
            this.moneyInfoLbl.TabIndex = 2;
            this.moneyInfoLbl.Text = "That Contestant Earn This Much Money:";
            // 
            // moneyLbl
            // 
            this.moneyLbl.AutoSize = true;
            this.moneyLbl.Location = new System.Drawing.Point(557, 307);
            this.moneyLbl.Name = "moneyLbl";
            this.moneyLbl.Size = new System.Drawing.Size(50, 17);
            this.moneyLbl.TabIndex = 3;
            this.moneyLbl.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contestant\'s Information:";
            // 
            // nameInfoLbl
            // 
            this.nameInfoLbl.AutoSize = true;
            this.nameInfoLbl.Location = new System.Drawing.Point(557, 154);
            this.nameInfoLbl.Name = "nameInfoLbl";
            this.nameInfoLbl.Size = new System.Drawing.Size(13, 17);
            this.nameInfoLbl.TabIndex = 3;
            this.nameInfoLbl.Text = "*";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(558, 121);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 17);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name:";
            this.nameLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(726, 121);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(69, 17);
            this.surnameLbl.TabIndex = 3;
            this.surnameLbl.Text = "Surname:";
            this.surnameLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // surnameInfoLbl
            // 
            this.surnameInfoLbl.AutoSize = true;
            this.surnameInfoLbl.Location = new System.Drawing.Point(726, 154);
            this.surnameInfoLbl.Name = "surnameInfoLbl";
            this.surnameInfoLbl.Size = new System.Drawing.Size(13, 17);
            this.surnameInfoLbl.TabIndex = 3;
            this.surnameInfoLbl.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-Mail:";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Money";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(558, 217);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(13, 17);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "*";
            // 
            // phonenumberLbl
            // 
            this.phonenumberLbl.AutoSize = true;
            this.phonenumberLbl.Location = new System.Drawing.Point(558, 278);
            this.phonenumberLbl.Name = "phonenumberLbl";
            this.phonenumberLbl.Size = new System.Drawing.Size(13, 17);
            this.phonenumberLbl.TabIndex = 3;
            this.phonenumberLbl.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Total Amount Of Given Money:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContestantInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.phonenumberLbl);
            this.Controls.Add(this.surnameInfoLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nameInfoLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyLbl);
            this.Controls.Add(this.moneyInfoLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ContestantInformationForm";
            this.Text = "ContestersInformationForm";
            this.Load += new System.EventHandler(this.ContestantInformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label moneyInfoLbl;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameInfoLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label surnameInfoLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phonenumberLbl;
        private System.Windows.Forms.Button button1;
    }
}