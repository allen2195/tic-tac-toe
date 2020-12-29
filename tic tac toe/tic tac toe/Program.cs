using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[]args)
        {

   

            int turns = 9;
            char player = 'X';
            char[,] board = new char[3, 3];
            GameBoard(board);

           Console.WriteLine("Welcome to tic-tac-toe!");
 
            while (true)
            {
                Console.Clear();
                Print(board);
                Console.WriteLine("Player '" + player + "' is playing!");
                Console.WriteLine("Select the row");
                int row = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Select column");
                int col = Convert.ToInt32(Console.ReadLine()) - 1;
                board[row, col] = player;
                turns--;
                if (turns == 0)
                {
                    Console.Clear();
                    Print(board);
                    Console.WriteLine("Game over!");
                    break;
                }
             
                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }

            }
            Console.WriteLine(" Press any key to exit the game ");
            Console.ReadKey();



        }
        static void GameBoard (char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {



                Console.Write(row + 1 + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1   2   3   ");


        }

    }
    } 
    






    
