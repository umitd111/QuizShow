using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void userforgotBtn_Click(object sender, EventArgs e)
        {
            forgotpassForm f = new forgotpassForm();
            f.Show();
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
