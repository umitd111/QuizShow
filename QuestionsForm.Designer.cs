﻿namespace QuizShowApplication
{
    partial class QuestionsForm
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
            this.question = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionNumberkCmb = new System.Windows.Forms.ComboBox();
            this.deleteQuestionBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionPrize = new System.Windows.Forms.ComboBox();
            this.qslvllbl = new System.Windows.Forms.Label();
            this.editQuestionBtn = new System.Windows.Forms.Button();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(167, 48);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(394, 22);
            this.question.TabIndex = 0;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(167, 240);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 22);
            this.d.TabIndex = 9;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(167, 212);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 22);
            this.c.TabIndex = 10;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(167, 184);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 11;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(167, 156);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "D)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "B)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "A)";
            // 
            // questionNumberkCmb
            // 
            this.questionNumberkCmb.FormattingEnabled = true;
            this.questionNumberkCmb.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.questionNumberkCmb.Location = new System.Drawing.Point(235, 76);
            this.questionNumberkCmb.Name = "questionNumberkCmb";
            this.questionNumberkCmb.Size = new System.Drawing.Size(92, 24);
            this.questionNumberkCmb.TabIndex = 4;
            // 
            // deleteQuestionBtn
            // 
            this.deleteQuestionBtn.Location = new System.Drawing.Point(461, 268);
            this.deleteQuestionBtn.Name = "deleteQuestionBtn";
            this.deleteQuestionBtn.Size = new System.Drawing.Size(100, 49);
            this.deleteQuestionBtn.TabIndex = 13;
            this.deleteQuestionBtn.Text = "Delete Question";
            this.deleteQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(164, 79);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(65, 17);
            this.questionLbl.TabIndex = 14;
            this.questionLbl.Text = "Question";
            // 
            // questionPrize
            // 
            this.questionPrize.FormattingEnabled = true;
            this.questionPrize.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "30000"});
            this.questionPrize.Location = new System.Drawing.Point(450, 157);
            this.questionPrize.Name = "questionPrize";
            this.questionPrize.Size = new System.Drawing.Size(111, 24);
            this.questionPrize.TabIndex = 4;
            // 
            // qslvllbl
            // 
            this.qslvllbl.AutoSize = true;
            this.qslvllbl.BackColor = System.Drawing.SystemColors.Control;
            this.qslvllbl.Location = new System.Drawing.Point(333, 160);
            this.qslvllbl.Name = "qslvllbl";
            this.qslvllbl.Size = new System.Drawing.Size(115, 17);
            this.qslvllbl.TabIndex = 15;
            this.qslvllbl.Text = "Question\'s Prize:";
            // 
            // editQuestionBtn
            // 
            this.editQuestionBtn.Location = new System.Drawing.Point(167, 268);
            this.editQuestionBtn.Name = "editQuestionBtn";
            this.editQuestionBtn.Size = new System.Drawing.Size(100, 49);
            this.editQuestionBtn.TabIndex = 13;
            this.editQuestionBtn.Text = "Edit Question";
            this.editQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Location = new System.Drawing.Point(314, 268);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(100, 49);
            this.addQuestionBtn.TabIndex = 13;
            this.addQuestionBtn.Text = "Add Question";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 419);
            this.Controls.Add(this.qslvllbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.editQuestionBtn);
            this.Controls.Add(this.deleteQuestionBtn);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionPrize);
            this.Controls.Add(this.questionNumberkCmb);
            this.Controls.Add(this.question);
            this.Name = "QuestionsForm";
            this.Text = "QuestionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox questionNumberkCmb;
        private System.Windows.Forms.Button deleteQuestionBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.ComboBox questionPrize;
        private System.Windows.Forms.Label qslvllbl;
        private System.Windows.Forms.Button editQuestionBtn;
        private System.Windows.Forms.Button addQuestionBtn;
    }
}