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
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin addqs = new Admin();
            addqs.QuestionText = textBox1.Text;
            addqs.QsLevel = Convert.ToInt32(comboBox1.SelectedItem);
            addqs.A = textBox2.Text;
            addqs.B = textBox3.Text;
            addqs.C = textBox4.Text;
            addqs.D = textBox5.Text;
            addqs.CorrectAnswer = textBox6.Text;
            addqs.QsNumber = Convert.ToInt32(textBox7.Text);

            addqs.AddNewQs(addqs.QuestionText, addqs.QsLevel, addqs.A, addqs.B, addqs.C, addqs.D, addqs.CorrectAnswer, addqs.QsNumber);

            MessageBox.Show("The Question Has Been Added To The Database");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
