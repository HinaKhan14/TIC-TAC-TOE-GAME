using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    class Quiz : Game
    {
        char[] options = { 'A', 'B', 'C', 'D' };
        char[] ans = new char[15];

        public void playGame(string name)
        {
            Console.Clear();

            Console.Write("\t\t\tHEY " + name);
            Console.WriteLine("WELCOME TO MCQ BASE GAME\n");
            
            Console.WriteLine("\t1-START");
            Console.WriteLine("\t2-EXIT");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                makeQuiz();
            }
            else if (choice == 2)
            {
                Console.Clear();
                return;
            }
            else
                Console.WriteLine("\t\tINVALID!!");
        }

        private void makeQuiz()
        {
            int x = 0, i = 4;
            Console.WriteLine("YOU HAVE " + i + " ATTEMPTS\n");
            Console.WriteLine("CHOOSE OPTION'S CAREFULLY!!\n\nYOU WILL GET 10 POINTS FOR A CORRECT ANSWER\n");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("\n\nQ1-A Constructor can be virtual?\n\n" + options[0] + "-True\n\n" + options[1] + "-False\n");
            ans[0] = Console.ReadKey().KeyChar;

            if (ans[0] == options[1])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT\n");            
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ2-A Single line comment in C++ language source can begin with?\n\n" + options[0] + "-;\n\n" + options[1] + "-:\n\n" + options[2] + "-/*\n\n" + options[3] + "-//\n");
            ans[1] = Console.ReadKey().KeyChar;
            if (ans[1] == options[3])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT\n");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ3-What is built in library function to compare two string?\n\n" + options[0] + "-string_cmp()\n\n" + options[1] + "-strcmp()\n\n" + options[2] + "-equals\n\n" + options[3] + "-str_compare\n");
            ans[2] = Console.ReadKey().KeyChar;
            if (ans[2] == options[1])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT\n");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ4-What does your class can hold?\n\n" + options[0] + "-data\n\n" + options[1] + "-functions\n\n" + options[2] + "-both A & B\n\n" + options[3] + "-none of the mentioned\n");
            ans[3] = Console.ReadKey().KeyChar;
            if (ans[3] == options[2])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ5-The feild in the class C++ program are by default?\n\n" + options[0] + "-protected\n\n" + options[1] + "-private\n\n" + options[2] + "-public\n\n" + options[3] + "-none of the mentioned\n");
            ans[4] = Console.ReadKey().KeyChar;
            if (ans[4] == options[1])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ6-Constructor are used to ?\n\n" + options[0] + "-to initialize object\n\n" + options[1] + "-contruct the data member\n\n" + options[2] + "-both A & B\n\n" + options[3] + "-none of the mentioned\n");
            ans[5] = Console.ReadKey().KeyChar;
            if (ans[5] == options[0])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ7-How to access the object in the class?\n\n" + options[0] + "-scope resolution operator\n\n" + options[1] + "-ternary operator\n\n" + options[2] + "-direct member access operator\n\n" + options[3] + "-none of the mentioned\n");
            ans[6] = Console.ReadKey().KeyChar;
            if (ans[6] == options[2])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ8-How many object can be present in the class?\n\n" + options[0] + "-1\n\n" + options[1] + "-2\n\n" + options[2] + "-3\n\n" + options[3] + "-as many as possible\n");
            ans[7] = Console.ReadKey().KeyChar;
            if (ans[7] == options[3])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ9-What does a default header file contain?\n\n" + options[0] + "-prototype\n\n" + options[1] + "-implementation\n\n" + options[2] + "-declarations\n\n" + options[3] + "-none of the mentioned\n");
            ans[8] = Console.ReadKey().KeyChar;
            if (ans[8] == options[2])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            Console.WriteLine("\n\nQ10-Which keyword is used to declare friend function?\n\n" + options[0] + "-freind\n\n" + options[1] + "-friend\n\n" + options[2] + "-classfriend\n\n" + options[3] + "-myfriend\n");
            ans[9] = Console.ReadKey().KeyChar;
            if (ans[9] == options[1])
            {
                x = x + 10;
                Console.Clear();
            }
            else
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("\n\nYOU HAVE NO ATTEMPTS LEFT\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("\n\nWRONG ANSWER\n");
                Console.WriteLine("YOU HAVE " + i + " ATTEMPT LEFT");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
            }

            if (x >= 60 && x < 70)
            {
                Console.WriteLine("\t\t\tYOU HAVE SCORED: " + x);
                Console.WriteLine("\n\t\t\tC GRADE---NOT BAD\n");
            }
            else if (x >= 70 && x < 80)
            {
                Console.WriteLine("\t\t\tYOU HAVE SCORED: " + x);
                Console.WriteLine("\n\t\t\tB GRADE---GOOD JOB!\n");
            }
            else if (x >= 80 && x < 90)
            {
                Console.WriteLine("\t\t\tYOU HAVE SCORED: " + x);
                Console.WriteLine("\n\t\t\tA GRADE---GENIUSS!!");
            }
            else if (x >= 90)
            {
                Console.WriteLine("\t\t\tYOU HAVE SCORED: " + x);
                Console.WriteLine("\n\t\t\tA+ GRADE---YOU'R REALLY GOOD!!!\n");
            }
            else if (x < 50)
            {
                Console.WriteLine("\t\t\tYOU HAVE SCORED: " + x);
                Console.WriteLine("\n\t\t\tLOSER!!!!");
            }
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
        }
    }
}
