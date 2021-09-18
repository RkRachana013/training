using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFramworkApp
{
    class Details
    {
        public static void SignUp()
        {

            Dictionary<string, string> users = new Dictionary<string, string>();
            //for (int i = 0; i < 4; i++)
            //{
                string uname = MyConsole.GetString("enter the UserName");
               string pwd = MyConsole.GetString("Ennter the password");
               if (users.ContainsKey(uname))
                  Console.WriteLine("Eser name already exists.please entr other name");
              else
                users.Add(uname, pwd);
            Console.WriteLine("SignUp Successfull");

           // }
        }


        public static void Signin()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            string loginName = MyConsole.GetString("Enter your Login Id");
            string loginPwd = MyConsole.GetString("Enter the password");
            if (users.ContainsKey(loginName))
            {
                if (users[loginName] == loginPwd)

                    Console.WriteLine("Welcome to the user");
                else
                    Console.WriteLine("Invalid password");
            }
            else
            { Console.WriteLine("User nameof is not valid"); }
        }

    }
    class DictionaryDemo : Details
    {
        const string menu = "            WelCome            \nIf You are a new use ,To SignUp         PRESS 1\nIfyou already have account to signin         PRESS 2\n";
        static void Main(string[] args)
        {

            bool processing = true;
            do
            {
                var choice = MyConsole.GetNumber(menu);
                processing = processMenu(choice);
            } while (processing);

        }
        private static bool processMenu(uint choice)
        {
            switch (choice)
            {
                case 1:
                    SignUp();
                    return true;
                case 2:
                    Signin();
                    return true;


            }
            return false;
        }

    }
}


  

    
    

