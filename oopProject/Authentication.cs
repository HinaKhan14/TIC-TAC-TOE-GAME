using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    class Authentication
    {
        private string user;
        private string password;
        StreamReader reader;
        StreamWriter writer;

        //null Constructor
        public Authentication()
        {
            user = "";
            password = "";
        }

        public void SignUp()
        {
            bool valid = false;

            while(!valid)
            {
                Console.WriteLine("\n\n");
                reader = new StreamReader("user.txt");
                Console.Write("Username: ");
                user = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                Console.Write("Confirm Password: ");
                string conf = Console.ReadLine();

                string[] UserList = new string[20];

                bool UserAlready = false;

                string user1 = "";
                int i = 0;

                while ((user1 = reader.ReadLine()) != null)
                {
                    string[] arr = user1.Split(' ');        //splitting name and password
                    user1 = arr[0];
                    if (user1 == user)
                    {
                        UserAlready = true;
                        break;
                    }
                    UserList[i] = user1;
                    i++;
                }
                if (!UserAlready)
                {
                    UserList[i] = user;
                }

                reader.Close();

                if (!UserAlready && conf == password)
                {
                    writer = new StreamWriter("User.txt");
                    for (int j = 0; j <= i; j++)
                    {
                        writer.WriteLine(UserList[j].ToString()+" " + password.ToString());
                    }
                    Console.WriteLine("\n\nRegistered Successfully....!! ");
                    valid = true;
                    writer.Close();
                }

                else if (UserAlready)
                    Console.WriteLine("\n\nTHERE IS ALREADY A USER WITH IS USERNAME");
                else if (conf != password)
                    Console.WriteLine("\n\nTHE PASSWORD GIVEN DO NOT MATCH");
                
            }
            System.Threading.Thread.Sleep(2000);        //wait for 2 seconds
            Console.Clear();
        }

        public void SignIn()
        {
            bool valid = false;

            while(!valid)
            {
                Console.Write("\nEnter Username: ");
                user = Console.ReadLine();

                Console.Write("\nEnter Password: ");
                password = Console.ReadLine();

                reader = new StreamReader("user.txt");
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');

                    if (arr[0] == user && arr[1] == password)
                    {
                        valid = true;
                        break;
                    }
                }

                if (valid)
                {
                    Console.WriteLine("\n\nSIGNED IN SUCCESSFULLY... !!");
                    System.Threading.Thread.Sleep(2000);        // wait for 2 seconds
                    Account acc = new Account();
                    Console.Clear();
                    acc.DisplauMenu(user);
                }
                else
                {
                    Console.WriteLine("\n\nWRONG USERNAME OR PASSWORD!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            Console.Clear();
        }

    }
}
