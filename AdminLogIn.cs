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
    public partial class adminuserForm : Form
    {
        public adminuserForm()
        {
            InitializeComponent();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void adminforgotBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void adminsigninBtn_Click(object sender, EventArgs e)
        {
            SqlCon sql = new SqlCon();
            sql.OpenConnection();

            Admin ad = new Admin();
            ad.Username = adminusernameTxt.Text;
            ad.Password = adminpasswordTxt.Text;

            SqlCommand userpassCheck =
            new SqlCommand("SELECT username, password FROM AdminRegister WHERE username='" + ad.Username + "' AND password ='" + ad.Password + "'", sql.GetSet);
            SqlDataReader reader = userpassCheck.ExecuteReader();
            if (reader.Read())
            {
                AdminMainForm mainForm = new AdminMainForm();
                mainForm.Show();
                this.Hide();
            }
            else { MessageBox.Show("Please Check Your Username Or Password And Try Again"); }
            sql.CloseConnection();
        }
    }
}
