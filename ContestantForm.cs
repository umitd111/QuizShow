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
    public partial class ContestantForm : Form
    {
        public ContestantForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.label4.Text = label1.Text;
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCon con = new SqlCon();

            SqlCommand command = new SqlCommand("SELECT SUM(earnedmoney) AS sumMoney FROM RegContestant", con.GetSet);
            con.OpenConnection();
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                button2.Text = dr["sumMoney"].ToString();
            }
            con.CloseConnection();
        }

        private void ContestantForm_Load(object sender, EventArgs e)
        {
            int alreadyJoined;
            SqlCon sql = new SqlCon();
            sql.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT alreadyjoined FROM RegContestant WHERE username = '" + label1.Text + "'", sql.GetSet);
            SqlDataReader dr;

            dr = command.ExecuteReader();
            dr.Read();
            alreadyJoined = Convert.ToInt32(dr["alreadyjoined"].ToString());
                
            if(alreadyJoined == 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            
            sql.CloseConnection();

        }
    }
}
