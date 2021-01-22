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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void DisplayQuestionsBtn_Click(object sender, EventArgs e)
        {
            QuestionsForm form = new QuestionsForm();
            form.Show();
        }

        private void DisplayContestantsBtn_Click(object sender, EventArgs e)
        {
            ContestantInformationForm form = new ContestantInformationForm();
            form.Show();
            this.Hide();
        }
    }
}
