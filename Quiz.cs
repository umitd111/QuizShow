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
    public partial class QuizForm : Form
    {
        public QuizForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuizForm_Load(object sender, EventArgs e)
        {


            Contestant cont = new Contestant();
            cont.QsNumber = Convert.ToInt32(questionNumber.Text);

            SqlCon sql = new SqlCon();
            SqlCommand command = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + cont.QsNumber + "'", sql.GetSet);
            sql.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                cont.QuestionText = dr["question"].ToString();
                question.Text = cont.QuestionText;

                cont.A = dr["a"].ToString();
                a.Text = cont.A;

                cont.B = dr["b"].ToString();
                b.Text = cont.B;

                cont.C = dr["c"].ToString();
                c.Text = cont.C;

                cont.D = dr["d"].ToString();
                d.Text = cont.D;
              
                prize.Text = Convert.ToString(cont.QsNumber);

                //No need to get qs lvl. It already defined in prog

            }
            sql.CloseConnection();

        }

        private void a_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant();
            SqlCon connect = new SqlCon();

            contestant.QsNumber = Convert.ToInt32(questionNumber.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + contestant.QsNumber + "'", connect.GetSet);
            
            connect.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            dr.Read();
            contestant.CorrectAnswer = dr["correctanswer"].ToString();
            int nowValue = Convert.ToInt32(dr["questionnumber"]);
            String temp = contestant.CorrectAnswer; //Temporary variable to keep correct answer
            
            contestant.Money = Convert.ToInt32(label3.Text);
            int totalMoney = contestant.Money;
            connect.CloseConnection();
            connect.OpenConnection();
            SqlCommand command3 = new SqlCommand("SELECT COUNT(questionnumber) AS count FROM QuestionTable", connect.GetSet);
            command3.ExecuteNonQuery();
            SqlDataReader dr3;
            dr3 = command3.ExecuteReader();

            dr3.Read();

            int maxValue = Convert.ToInt32(dr3["count"]);
            connect.CloseConnection();

            //Checking all question conditions
            if (maxValue == nowValue)
            {
                MessageBox.Show("You Win This Game! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                this.Hide();
            }
            else if(temp == a.Text)
            {
                
                int control = Convert.ToInt32(questionNumber.Text);
                control++;
                questionNumber.Text = Convert.ToString(control);
                SqlCommand command2 = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + questionNumber.Text + "'", connect.GetSet);
                connect.OpenConnection();
                command2.ExecuteNonQuery();
                SqlDataReader dr2;
                dr2 = command2.ExecuteReader();
                while (dr2.Read())
                {
                    contestant.QuestionText = dr2["question"].ToString();
                    question.Text = contestant.QuestionText;

                    contestant.A = dr2["a"].ToString();
                    a.Text = contestant.A;

                    contestant.B = dr2["b"].ToString();
                    b.Text = contestant.B;

                    contestant.C = dr2["c"].ToString();
                    c.Text = contestant.C;

                    contestant.D = dr2["d"].ToString();
                    d.Text = contestant.D;

                    contestant.CorrectAnswer = dr2["correctanswer"].ToString();
                    String temp2 = contestant.CorrectAnswer; //Temporary variable to keep correct answer

                    contestant.QsLevel = Convert.ToInt32(dr2["questionlevel"].ToString());
                    prize.Text = Convert.ToString(contestant.QsLevel);

                    int addingtotalMoney = Convert.ToInt32(dr2["questionlevel"].ToString());
                    totalMoney = addingtotalMoney + totalMoney;
                    label3.Text = Convert.ToString(totalMoney);

                }
                connect.CloseConnection();        
            }
            else
            { 
                MessageBox.Show("This Answer Is Wrong!!! Your Reward Is: "+totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='"+totalMoney+"' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                connect.CloseConnection();
                this.Hide();
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant();
            SqlCon connect = new SqlCon();

            contestant.QsNumber = Convert.ToInt32(questionNumber.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + contestant.QsNumber + "'", connect.GetSet);

            connect.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            dr.Read();
            contestant.CorrectAnswer = dr["correctanswer"].ToString();
            int nowValue = Convert.ToInt32(dr["questionnumber"]);
            String temp = contestant.CorrectAnswer; //Temporary variable to keep correct answer

            contestant.Money = Convert.ToInt32(label3.Text);
            int totalMoney = contestant.Money;
            connect.CloseConnection();
            connect.OpenConnection();
            SqlCommand command3 = new SqlCommand("SELECT COUNT(questionnumber) AS count FROM QuestionTable", connect.GetSet);
            command3.ExecuteNonQuery();
            SqlDataReader dr3;
            dr3 = command3.ExecuteReader();

            dr3.Read();

            int maxValue = Convert.ToInt32(dr3["count"]);
            connect.CloseConnection();

            //Checking all question conditions
            if (maxValue == nowValue)
            {
                MessageBox.Show("You Win This Game! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                connect.CloseConnection();
                this.Hide();
            }
            else if (temp == c.Text)
            {

                int control = Convert.ToInt32(questionNumber.Text);
                control++;
                questionNumber.Text = Convert.ToString(control);
                SqlCommand command2 = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + questionNumber.Text + "'", connect.GetSet);
                connect.OpenConnection();
                command2.ExecuteNonQuery();
                SqlDataReader dr2;
                dr2 = command2.ExecuteReader();
                while (dr2.Read())
                {
                    contestant.QuestionText = dr2["question"].ToString();
                    question.Text = contestant.QuestionText;

                    contestant.A = dr2["a"].ToString();
                    a.Text = contestant.A;

                    contestant.B = dr2["b"].ToString();
                    b.Text = contestant.B;

                    contestant.C = dr2["c"].ToString();
                    c.Text = contestant.C;

                    contestant.D = dr2["d"].ToString();
                    d.Text = contestant.D;

                    contestant.CorrectAnswer = dr2["correctanswer"].ToString();
                    String temp2 = contestant.CorrectAnswer; //Temporary variable to keep correct answer

                    contestant.QsLevel = Convert.ToInt32(dr2["questionlevel"].ToString());
                    prize.Text = Convert.ToString(contestant.QsLevel);

                    int addingtotalMoney = Convert.ToInt32(dr2["questionlevel"].ToString());
                    totalMoney = addingtotalMoney + totalMoney;
                    label3.Text = Convert.ToString(totalMoney);

                }
                connect.CloseConnection();
            }
            else
            {
                MessageBox.Show("This Answer Is Wrong!!! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                connect.CloseConnection();
                this.Hide();
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant();
            SqlCon connect = new SqlCon();

            contestant.QsNumber = Convert.ToInt32(questionNumber.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + contestant.QsNumber + "'", connect.GetSet);

            connect.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            dr.Read();
            contestant.CorrectAnswer = dr["correctanswer"].ToString();
            int nowValue = Convert.ToInt32(dr["questionnumber"]);
            String temp = contestant.CorrectAnswer; //Temporary variable to keep correct answer

            contestant.Money = Convert.ToInt32(label3.Text);
            int totalMoney = contestant.Money;
            connect.CloseConnection();
            connect.OpenConnection();
            SqlCommand command3 = new SqlCommand("SELECT COUNT(questionnumber) AS count FROM QuestionTable", connect.GetSet);
            command3.ExecuteNonQuery();
            SqlDataReader dr3;
            dr3 = command3.ExecuteReader();

            dr3.Read();

            int maxValue = Convert.ToInt32(dr3["count"]);
            connect.CloseConnection();

            //Checking all question conditions
            if (maxValue == nowValue)
            {
                MessageBox.Show("You Win This Game! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                connect.CloseConnection();
                this.Hide();
            }
            else if (temp == b.Text)
            {

                int control = Convert.ToInt32(questionNumber.Text);
                control++;
                questionNumber.Text = Convert.ToString(control);
                SqlCommand command2 = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + questionNumber.Text + "'", connect.GetSet);
                connect.OpenConnection();
                command2.ExecuteNonQuery();
                SqlDataReader dr2;
                dr2 = command2.ExecuteReader();
                while (dr2.Read())
                {
                    contestant.QuestionText = dr2["question"].ToString();
                    question.Text = contestant.QuestionText;

                    contestant.A = dr2["a"].ToString();
                    a.Text = contestant.A;

                    contestant.B = dr2["b"].ToString();
                    b.Text = contestant.B;

                    contestant.C = dr2["c"].ToString();
                    c.Text = contestant.C;

                    contestant.D = dr2["d"].ToString();
                    d.Text = contestant.D;

                    contestant.CorrectAnswer = dr2["correctanswer"].ToString();
                    String temp2 = contestant.CorrectAnswer; //Temporary variable to keep correct answer

                    contestant.QsLevel = Convert.ToInt32(dr2["questionlevel"].ToString());
                    prize.Text = Convert.ToString(contestant.QsLevel);

                    int addingtotalMoney = Convert.ToInt32(dr2["questionlevel"].ToString());
                    totalMoney = addingtotalMoney + totalMoney;
                    label3.Text = Convert.ToString(totalMoney);

                }
                connect.CloseConnection();
            }
            else
            {
                MessageBox.Show("This Answer Is Wrong!!! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                connect.CloseConnection();
                this.Hide();
            }
        }

        private void d_Click(object sender, EventArgs e)
        {
            Contestant contestant = new Contestant();
            SqlCon connect = new SqlCon();

            contestant.QsNumber = Convert.ToInt32(questionNumber.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + contestant.QsNumber + "'", connect.GetSet);

            connect.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            dr.Read();
            contestant.CorrectAnswer = dr["correctanswer"].ToString();
            int nowValue = Convert.ToInt32(dr["questionnumber"]);
            String temp = contestant.CorrectAnswer; //Temporary variable to keep correct answer

            contestant.Money = Convert.ToInt32(label3.Text);
            int totalMoney = contestant.Money;
            connect.CloseConnection();
            connect.OpenConnection();
            SqlCommand command3 = new SqlCommand("SELECT COUNT(questionnumber) AS count FROM QuestionTable", connect.GetSet);
            command3.ExecuteNonQuery();
            SqlDataReader dr3;
            dr3 = command3.ExecuteReader();

            dr3.Read();

            int maxValue = Convert.ToInt32(dr3["count"]);
            connect.CloseConnection();

            //Checking all question conditions
            if (maxValue == nowValue)
            {
                MessageBox.Show("You Win This Game! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command6 = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" +questionNumber.Text+ "'", connect.GetSet);

                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                

                connect.CloseConnection();
                this.Hide();
            }
            else if (temp == d.Text)
            {

                int control = Convert.ToInt32(questionNumber.Text);
                control++;
                questionNumber.Text = Convert.ToString(control);
                SqlCommand command2 = new SqlCommand("SELECT * FROM QuestionTable WHERE questionnumber='" + questionNumber.Text + "'", connect.GetSet);
                connect.OpenConnection();
                command2.ExecuteNonQuery();
                SqlDataReader dr2;
                dr2 = command2.ExecuteReader();
                while (dr2.Read())
                {
                    contestant.QuestionText = dr2["question"].ToString();
                    question.Text = contestant.QuestionText;

                    contestant.A = dr2["a"].ToString();
                    a.Text = contestant.A;

                    contestant.B = dr2["b"].ToString();
                    b.Text = contestant.B;

                    contestant.C = dr2["c"].ToString();
                    c.Text = contestant.C;

                    contestant.D = dr2["d"].ToString();
                    d.Text = contestant.D;

                    contestant.CorrectAnswer = dr2["correctanswer"].ToString();
                    String temp2 = contestant.CorrectAnswer; //Temporary variable to keep correct answer

                    contestant.QsLevel = Convert.ToInt32(dr2["questionlevel"].ToString());
                    prize.Text = Convert.ToString(contestant.QsLevel);

                    int addingtotalMoney = Convert.ToInt32(dr2["questionlevel"].ToString());
                    totalMoney = addingtotalMoney + totalMoney;
                    label3.Text = Convert.ToString(totalMoney);

                }
                connect.CloseConnection();
            }
            else
            {
                MessageBox.Show("This Answer Is Wrong!!! Your Reward Is: " + totalMoney);
                connect.OpenConnection();
                SqlCommand command4 = new SqlCommand("UPDATE RegContestant SET earnedmoney='" + totalMoney + "' WHERE username='" + label4.Text + "'", connect.GetSet);
                command4.ExecuteNonQuery();
                SqlCommand command5 = new SqlCommand("UPDATE RegContestant SET alreadyjoined= '1' WHERE username='" + label4.Text + "'", connect.GetSet);
                command5.ExecuteNonQuery();
                connect.CloseConnection();
                ContestantForm myform = new ContestantForm();
                myform.button1.Enabled = false;
                this.Hide();
            }
        }
    }
}
