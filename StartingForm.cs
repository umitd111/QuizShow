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
    public partial class selectForm : Form
    {
        Contestant s = new Contestant();
        

        public selectForm()
        {
            InitializeComponent();
            
        }

        private void selectPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminuserForm a = new adminuserForm(); //
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contesterloginForm b = new contesterloginForm();
            b.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
