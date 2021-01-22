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
    public partial class ContestantInformationForm : Form
    {
        public ContestantInformationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ContestantInformationForm_Load(object sender, EventArgs e)
        {
            SqlCon con = new SqlCon();
            Contestant test = new Contestant();
            
            SqlCommand command = new SqlCommand("SELECT * FROM RegContestant", con.GetSet);
            con.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["username"]).ToString();

            }
            con.CloseConnection();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCon sql = new SqlCon();
            Contestant test = new Contestant();
            test.Username = Convert.ToString(comboBox1.SelectedItem);
            SqlCommand command = new SqlCommand("SELECT * FROM RegContestant WHERE username='" + test.Username + "'", sql.GetSet);
            sql.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                test.Name = dr["name"].ToString();
                nameInfoLbl.Text = test.Name;

                test.Surname = dr["surname"].ToString();
                surnameInfoLbl.Text = test.Surname;

                test.Email = dr["email"].ToString();
                emailLbl.Text = test.Email;

                test.Phonenumber = dr["phonenumber"].ToString();
                phonenumberLbl.Text = test.Phonenumber;

                test.Money = Convert.ToInt32(dr["earnedmoney"].ToString());
                moneyLbl.Text = Convert.ToString(test.Money);
  
            }
            sql.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCon con = new SqlCon();
     
            SqlCommand command = new SqlCommand("SELECT SUM(earnedmoney) AS sumMoney FROM RegContestant", con.GetSet);
            con.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                label6.Text = dr["sumMoney"].ToString();
            }

            con.CloseConnection();
        }
    }
}
