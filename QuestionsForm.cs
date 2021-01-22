using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizShowApplication
{
    public partial class QuestionsForm : Form
    {

        Admin ad = new Admin();

        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            AddQuestion form = new AddQuestion();
            form.Show();
        }

        private void editQuestionBtn_Click(object sender, EventArgs e)
        {
            ad.QsNumber = Convert.ToInt32(questionNumberCmb.SelectedItem);
            ad.QuestionText = question.Text;
            ad.QsLevel = Convert.ToInt32(questionPrize.SelectedItem);
            ad.A = a.Text;
            ad.B = b.Text;
            ad.C = c.Text;
            ad.D = d.Text;
            ad.CorrectAnswer = textBox1.Text;

            ad.UpdateQuestion(ad.QsNumber, ad.QuestionText, ad.QsLevel, ad.A, ad.B, ad.C, ad.D, ad.CorrectAnswer);
        }

        private void questionNumberkCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCon sql = new SqlCon();
            SqlCommand command = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + questionNumberCmb.Text + "'", sql.GetSet);
            sql.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                ad.QuestionText = dr["question"].ToString();
                question.Text = ad.QuestionText;

                ad.A = dr["a"].ToString();
                a.Text = ad.A;

                ad.B = dr["b"].ToString();
                b.Text = ad.B;

                ad.C = dr["c"].ToString();
                c.Text = ad.C;

                ad.D = dr["d"].ToString();
                d.Text = ad.D;

                ad.CorrectAnswer = dr["correctanswer"].ToString();
                textBox1.Text = ad.CorrectAnswer;

                ad.QsNumber = Convert.ToInt32(dr["questionlevel"].ToString());
                questionPrize.Text = Convert.ToString(ad.QsNumber);
                

            }
            sql.CloseConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            SqlCon sql = new SqlCon();
            sql.OpenConnection();

            SqlCommand command = new SqlCommand("SELECT questionnumber FROM QuestionTable", sql.GetSet);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                questionNumberCmb.Items.Add(dr["questionnumber"]).ToString();
            }
            sql.CloseConnection();
        }

        private void deleteQuestionBtn_Click(object sender, EventArgs e)
        {
            //Deletion Method
            Admin ad = new Admin();
            ad.QsNumber = Convert.ToInt32(questionNumberCmb.SelectedItem);
            ad.DeleteQs(ad.QsNumber);

            a.Clear();
            b.Clear();
            c.Clear();
            d.Clear();
            textBox1.Clear();
            question.Clear();
   
        }
    }
}
