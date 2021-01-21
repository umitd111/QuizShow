using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuizShowApplication
{
    class SqlCon
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-CA4DUS3\\SQLEXPRESS;Initial Catalog=quizapp;Integrated Security=True");
        public void OpenConnection()
        {
            connect.Open();
        }

        public void CloseConnection()
        {
            connect.Close();
        }

        public SqlCommand CreateCmd()
        {
            return connect.CreateCommand();
        }

        public SqlConnection GetSet
        {
            get { return connect; }
            set { connect = value; }
        }
    }
}
