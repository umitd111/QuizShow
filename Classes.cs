using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizShowApplication
{

    public class User
    {
        public virtual void WeCanShareThisMethod()
        {
            Console.WriteLine("This is parent class");
        }
    }

    public class Admin: User
    {
        private String name;
        private String surname;
        private String mail;
        private String password;
        private String username;

        public void AddNewQs(String a, String b, String c, String d, String e, String f, int prize)
        {
            
        }

        public void DeleteQs()
        {
            
        }

        public void DetermineQsLevel()
        {

        }

        public void DisplayQs()
        {

        }

        public void DisplayContester()
        {

        }

        public void ShowResult()
        {
           
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

        public String Email
        {
            get { return mail; }
            set { mail = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public override void WeCanShareThisMethod()
        {
            Console.WriteLine("This is Admin's Method");
        }
    }

    

    public class Contestant : User
    {
        private String name;
        private String surname;
        private String email;
        private String password;
        private String username;
        private int age;
        private String phonenumber;

        public void ShowResult()
        {
            
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

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Username
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

        public override void WeCanShareThisMethod()
        {
            Console.WriteLine("This is Contester's Method");
        }
    }


}
