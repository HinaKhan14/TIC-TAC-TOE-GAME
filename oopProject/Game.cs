using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    class Game
    {
        public int coins;
        public string name;

        public Game()          //parameterize constructor
        {
            this.name = "";
            this.coins = 0 ;
        }

        public void DisplayMenu(string username,int coins)
        {
            bool valid = false;
            this.name = username;
            this.coins = coins;

            while(!valid)
            {
                Console.WriteLine("\t\t\tHEY " + name +  " YOU HAVE " + coins + " COINS\n");
                Console.WriteLine("\tGAME:\n");
                Console.WriteLine("\t1- TIC TAC TOE (300 coins)");
                Console.WriteLine("\t2- QUIZ (200 coins)");
                Console.WriteLine("\t3- BACK\n");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        TicTacToe tic = new TicTacToe();
                        if (coins < 300)
                        {
                            Console.WriteLine("\n\n\t\tYOU DONT HAVE ENOUGH COINS");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                        }
                        else
                        {
                            tic.PlayGame(this.coins);
                            coins -= 300;
                        }
                        //Console.Clear();
                        break;
                    case 2:
                        Quiz quiz = new Quiz();
                        if (coins < 200)
                        {
                            Console.WriteLine("\n\n\t\tYOU DONT HAVE ENOUGH COINS");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                        }
                        else
                        {
                            coins -= 200;
                            quiz.playGame(name);
                        }
                        break;
                    case 3:
                        valid = true;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid!");
                        Console.Clear();
                        break;
                }
            }
        }

        public int GetCoins()
        {
            return this.coins;
        }
    }
}
