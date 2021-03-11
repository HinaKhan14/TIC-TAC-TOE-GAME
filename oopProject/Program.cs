using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication auth = new Authentication();
      
            bool finish = false;

            while(!finish)
            {
                Console.WriteLine("\t\t ***WELCOME TO THE GAME CLUB***\n");
                Console.WriteLine("\t 1- SIGN UP");
                Console.WriteLine("\t 2- SIGN IN");
                Console.WriteLine("\t 3- EXIT");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    auth.SignUp();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    auth.SignIn();
                }
                else if (input == 3)
                {
                    Console.WriteLine("\n\n\t\t THANKS FOR PLAYING");
                    finish = true;
                }
                else
                {
                    Console.WriteLine("Invalid!");
                    Console.Clear();
                }
            }
            Console.Read();

        }
    }
}
