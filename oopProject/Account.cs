using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    class Account
    {
        private int coins;

        public Account()
        {
            this.coins = 0;
        }

        public void DisplauMenu(string name)
        {
            bool valid = false;

            while(!valid)
            {
                Console.WriteLine("\t\t\tHEY " + name + ", YOU HAVE " + coins + " COINS\n");
                Console.WriteLine("\t1-GET COINS");
                Console.WriteLine("\t2-PLAY");
                Console.WriteLine("\t3-LOG OUT");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        GetCoins();
                        break;
                    case 2:
                        Game game = new Game();
                        Console.Clear();
                        game.DisplayMenu(name,coins);
                        break;
                    case 3:
                        valid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid!");
                        Console.Clear();
                        break;
               }
            
             }
        }

        private void GetCoins()            // Encapsulation (hiding GetCoins() from other classes)
        {
            bool valid = false;

            while(!valid)
            {
                Console.WriteLine("\t\tYOU HAVE " + coins + " LEFT!!");
                Console.WriteLine("WANT SOME COINS??");
                Console.WriteLine("ENTER THE AMOUNT YOU WANT");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 500)
                    Console.WriteLine("\n\n\t\t\tYOU CAN'T HAVE MORE THAN 500 COINS!!!");
                else
                {
                    coins = coins + input;
                    valid = true;
                }
            }
            Console.Clear();
        }
    }
}
