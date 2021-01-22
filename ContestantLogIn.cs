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

    
    public partial class contesterloginForm : Form
    {
        public contesterloginForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCon sql = new SqlCon();
            sql.OpenConnection();

            Contestant contest = new Contestant();
            contest.Username = userusernameTxt.Text;
            contest.Password = userpasswordTxt.Text;

            SqlCommand userpassCheck =
            new SqlCommand("SELECT username, password FROM RegContestant WHERE username='" + contest.Username + "' AND password ='" + contest.Password + "'" , sql.GetSet);
            SqlDataReader reader = userpassCheck.ExecuteReader();
            if (reader.Read())
            {
                ContestantForm conForm = new ContestantForm();
                conForm.label1.Text = contest.Username;
                conForm.Show();
                this.Hide();
            } 
            else { MessageBox.Show("Please Check Your Username Or Password And Try Again"); }
            sql.CloseConnection();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void userforgotBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void usenameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userregisterBtn_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
