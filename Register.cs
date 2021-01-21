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
    public partial class Register : Form
    {

        
        public Register()
        {
            InitializeComponent();
        }


        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            SqlCon sql = new SqlCon();
            

                Contestant c = new Contestant();
            c.Username = usernameTxt.Text;
            c.Password = passwordTxt.Text;
            c.Email = emailTxt.Text;
            c.Age = Convert.ToInt32(ageTxt.Text);
            c.Phonenumber = phoneNumberTxt.Text;
            
            if (usernameTxt.Text == "" || passwordTxt.Text == "" || emailTxt.Text == "" || ageTxt.Text == "" || phoneNumberTxt.Text == "")
            {
                MessageBox.Show("You should fill all the blanks.");
            }
            else
            {

                String username;
                username = usernameTxt.Text;
                //Started connection db

                SqlCommand usernameCheck = new SqlCommand("SELECT * FROM RegContester WHERE username='" + username + "'", sql.GetSet);
                
                sql.OpenConnection();
                SqlDataReader check = usernameCheck.ExecuteReader();
                
                if (check.Read())
                {
                    MessageBox.Show("This name is already taken. Please choose different name.");
                }
                else
                {
                    
                    //Starting store data
                    check.Close();
                    using (SqlCommand register = sql.CreateCmd())
                    {
                        register.CommandText = "INSERT INTO RegContester (username,password,email,age,phonenumber) values (@p1,@p2,@p3,@p4,@p5);";
                        register.Parameters.Add(new SqlParameter("@p1", c.Username));
                        register.Parameters.Add(new SqlParameter("@p2", c.Password));
                        register.Parameters.Add(new SqlParameter("@p3", c.Email));
                        register.Parameters.Add(new SqlParameter("@p4", c.Age));
                        register.Parameters.Add(new SqlParameter("@p5", c.Phonenumber));
                        register.ExecuteNonQuery();
                    }

                    Register r = new Register();
                    r.Show();
                    this.Hide();
                }
                sql.CloseConnection();
            }

            
        }
        private void ageTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Just Accepts Characters
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phoneNumberTxt_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Just Accepts Characters
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        