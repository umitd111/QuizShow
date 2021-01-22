using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizShowApplication
{

    public abstract class User
    {
        public virtual void WeCanShareThisMethod()
        {
            Console.WriteLine("This is parent class");
        }
    }

    public class Admin: User
    {
        //User Variables
        private String username;
        private String password;
        private String mail;
        
        //Question's Variables
        private String question;
        private int questionNumber;
        private int qslevel;
        private String opA;
        private String opB;
        private String opC;
        private String opD;
        private String correctAns;

        //To add new qs to db
        public void AddNewQs(String a, int b, String c, String d, String e, String f, string correct, int questionNum)
        {
            SqlCon con = new SqlCon();
            con.OpenConnection();

            using (SqlCommand addQs = con.CreateCmd())
            {
                addQs.CommandText = 
                "INSERT INTO QuestionTable (question,questionlevel,a,b,c,d,correctanswer,questionnumber) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";
                addQs.Parameters.Add(new SqlParameter("@p1", a));
                addQs.Parameters.Add(new SqlParameter("@p2", b));
                addQs.Parameters.Add(new SqlParameter("@p3", c));
                addQs.Parameters.Add(new SqlParameter("@p4", d));
                addQs.Parameters.Add(new SqlParameter("@p5", e));
                addQs.Parameters.Add(new SqlParameter("@p6", f));
                addQs.Parameters.Add(new SqlParameter("@p7", correct));
                addQs.Parameters.Add(new SqlParameter("@p8", questionNum));
                addQs.ExecuteNonQuery();
            }

            con.CloseConnection();
        }

        //Get Set for question parameters
        public String QuestionText
        {
            get { return question; }
            set { question = value; }
        }

        public virtual int QsLevel
        {
            get { return qslevel; }
            set { qslevel = value; }
        }
        public virtual int QsNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }
        public virtual String A
        {
            get { return opA; }
            set { opA = value; }
        }
        public virtual String B
        {
            get { return opB; }
            set { opB = value; }
        }
        public virtual String C
        {
            get { return opC; }
            set { opC = value; }
        }
        public virtual String D
        {
            get { return opD; }
            set { opD = value; }
        }
        public virtual String CorrectAnswer
        {
            get { return correctAns; }
            set { correctAns = value; }
        }
        //For deletion func
        public void DeleteQs(int delete)
        {
            SqlCon sql = new SqlCon();
            sql.OpenConnection();
            using (SqlCommand update = sql.CreateCmd())
            {

                update.CommandText =
                ("DELETE QuestionTable WHERE questionnumber='" + delete + "'");
                update.ExecuteNonQuery();
                MessageBox.Show("The Question Has Been Deleted.");

            }
            sql.CloseConnection();
        }

        //Update func
        public void UpdateQuestion(int qsnum, String qs, int qslvl, String opa, String opb, String opc, String opd, String correct)
        {
            SqlCon sql = new SqlCon();
            sql.OpenConnection();
            using (SqlCommand update = sql.CreateCmd())
            {
                
                update.CommandText =
                ("UPDATE QuestionTable SET question = @a, questionlevel = @b, a = @opa, b = @opb, c = @opc, d = @opd, correctanswer= @correct WHERE questionnumber='" + qsnum + "'");
                update.Parameters.AddWithValue("@a", qs);
                update.Parameters.AddWithValue("@b", qslvl);
                update.Parameters.AddWithValue("@opa", opa);
                update.Parameters.AddWithValue("@opb", opb);
                update.Parameters.AddWithValue("@opc", opc);
                update.Parameters.AddWithValue("@opd", opd);
                update.Parameters.AddWithValue("@correct", correct);
                update.ExecuteNonQuery();
                MessageBox.Show("The Question Has Been Updated.");

            }
            sql.CloseConnection();
        }

        public virtual String Email
        {
            get { return mail; }
            set { mail = value; }
        }

        public virtual String Password
        {
            get { return password; }
            set { password = value; }
        }   

        public virtual String Username
        {
            get { return username; }
            set { username = value; }
        }

        public override void WeCanShareThisMethod()
        {
            Console.WriteLine("This is Admin's Method");
        }
    }

    

    public class Contestant : Admin
    {
        private String name;
        private String surname;
        private String email;
        private String password;
        private String username;
        private int age;
        private String phonenumber;
        private int money;

        //Quiz values
        //private String question;
        private int questionNumber;
        private int qslevel;
        private String opA;
        private String opB;
        private String opC;
        private String opD;
        private String correctAns;

        public override int QsLevel
        {
            get { return qslevel; }
            set { qslevel = value; }
        }
        public override int QsNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }
        public override String A
        {
            get { return opA; }
            set { opA = value; }
        }
        public override String B
        {
            get { return opB; }
            set { opB = value; }
        }
        public override String C
        {
            get { return opC; }
            set { opC = value; }
        }
        public override String D
        {
            get { return opD; }
            set { opD = value; }
        }
        public override String CorrectAnswer
        {
            get { return correctAns; }
            set { correctAns = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public override String Email
        {
            get { return email; }
            set { email = value; }
        }

        public override String Password
        {
            get { return password; }
            set { password = value; }
        }

        public override String Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public override void WeCanShareThisMethod()
        {
            Console.WriteLine("This is Contester's Method");
        }
    }


}
