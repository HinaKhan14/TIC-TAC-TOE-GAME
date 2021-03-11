using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    class TicTacToe : Game      //inheritance
    {
        char[] grid = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int player;

        public TicTacToe()
        {
            player = 1;
        }
        public void PlayGame(int coins)
        {
            Console.Clear();

            int p;

            do
            {
                Console.WriteLine("\t\t\tTIC TAC TOE!!!\n\n");
                Console.WriteLine("\t\t\t    |    |    ");
                Console.WriteLine("\t\t\t " + grid[0] + "  | " + grid[1] + "  |  " + grid[2]);
                Console.WriteLine("\t\t\t____|____|____");
                Console.WriteLine("\t\t\t    |    |    ");
                Console.WriteLine("\t\t\t " + grid[3] + "  | " + grid[4] + "  |  " + grid[5]);
                Console.WriteLine("\t\t\t____|____|____");
                Console.WriteLine("\t\t\t    |    |    ");
                Console.WriteLine("\t\t\t " + grid[6] + "  | " + grid[7] + "  |  " + grid[8]);
                Console.WriteLine("\t\t\t    |    |    ");

                player = (player % 2 == 1) ? 1 : 2;
                Console.Write("Player" + player + ", Enter a number:  ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1 && grid[0] == '1')
                {
                    grid[0] = (player == 1) ? 'X' : 'O';
                }
                else if (choice == 2 && grid[1] == '2')
                {
                    grid[1] = (player == 1) ? 'X' : 'O';
                }
                else if (choice == 3 && grid[2] == '3')
                {
                    grid[2] = (player == 1) ? 'X' : 'O';
                }

                else if (choice == 4 && grid[3] == '4')
                {
                    grid[3] = (player == 1) ? 'X' : 'O';
                }

                else if (choice == 5 && grid[4] == '5')
                {
                    grid[4] = (player == 1) ? 'X' : 'O';
                }

                else if (choice == 6 && grid[5] == '6')
                {
                    grid[5] = (player == 1) ? 'X' : 'O';
                }

                else if (choice == 7 && grid[6] == '7')
                {
                    grid[6] = (player == 1) ? 'X' : 'O';
                }

                else if (choice == 8 && grid[7] == '8')
                {
                    grid[7] = (player == 1) ? 'X' : 'O';
                }

                else if (choice == 9 && grid[8] == '9')
                {
                    grid[8] = (player == 1) ? 'X' : 'O';
                }
                else
                {
                    Console.WriteLine("INVALID MOVE!!");
                    player--;
                }
                player++;

                p = GetWinner();

                if(p == 1)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }

                if (p == 0)
                {
                    Console.WriteLine("ITS A DRAW");
                    Console.Clear();
                }
            } while (p == -1);

            
        }

        private int GetWinner()         //Encapsulation
        {
            if (grid[0] == 'X' && grid[1] == 'X' && grid[2] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");

                return 1;
            }
            if (grid[3] == 'X' && grid[4] == 'X' && grid[5] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            if (grid[6] == 'X' && grid[7] == 'X' && grid[8] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            if (grid[0] == 'X' && grid[4] == 'X' && grid[8] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            if (grid[2] == 'X' && grid[4] == 'X' && grid[6] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            if (grid[0] == 'X' && grid[3] == 'X' && grid[6] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            if (grid[1] == 'X' && grid[4] == 'X' && grid[7] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            if (grid[2] == 'X' && grid[5] == 'X' && grid[8] == 'X')
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER");
                return 1;
            }
            //IF PLAYER 2 WINS

            if (grid[0] == 'O' && grid[1] == 'O' && grid[2] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[3] == 'O' && grid[4] == 'O' && grid[5] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[6] == 'O' && grid[7] == 'O' && grid[8] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[0] == 'O' && grid[4] == 'O' && grid[8] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[2] == 'O' && grid[4] == 'O' && grid[6] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[0] == 'O' && grid[3] == 'O' && grid[6] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[1] == 'O' && grid[4] == 'O' && grid[7] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            if (grid[2] == 'O' && grid[5] == 'O' && grid[8] == 'O')
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER");
                return 1;
            }
            else if (grid[0] != '1' && grid[1] != '2' && grid[2] != '3'
                            && grid[3] != '4' && grid[4] != '5' && grid[5] != '6'
                          && grid[6] != '7' && grid[7] != '8' && grid[8] != '9')

                return 0;

            else
            {
                Console.Clear();
                return -1;
            }
        }
    }
}
