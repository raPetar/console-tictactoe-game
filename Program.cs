using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] options = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int player = 1, option;
            int unoccupied = 10;

            do
            {
                // Decrementing available options
                unoccupied--;

                // Drawing the board
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2} ", options[1], options[2], options[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", options[4], options[5], options[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", options[7], options[8], options[9]);
                Console.WriteLine("     |     |      ");

                // Checking Victory conditions
                if (options[1] == options[2] && options[2] == options[3])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("Pobedio je O");
                    break;
                }
                if (options[4] == options[5] && options[5] == options[6])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }
                if (options[7] == options[8] && options[8] == options[9])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }
                if (options[1] == options[4] && options[4] == options[7])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }
                if (options[2] == options[5] && options[5] == options[8])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }
                if (options[3] == options[6] && options[6] == options[9])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }
                if (options[1] == options[5] && options[5] == options[9])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }
                if (options[3] == options[5] && options[5] == options[7])
                {
                    if (player % 2 == 0)
                        Console.WriteLine("X Won");
                    else
                        Console.WriteLine("O Won");
                    break;
                }

                // Checking if there are any available options
                if (unoccupied == 0)
                {
                    Console.WriteLine("The game resulted in a Tie");
                    Console.ReadKey();
                    break;
                }

                // Determining players turn
                if (player % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Turn: X");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Turn: O");
                    Console.ResetColor();
                }

                // Catching user input
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (options[option] != 'X' && options[option] != 'O')
                    {
                        if (player % 2 != 0)
                        {
                            player++;
                            options[option] = 'X';
                        }
                        else
                        {
                            player++;
                            options[option] = 'O';
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Selected option (number) already occupied \nPlease try again (press any key to continue)");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select a valid number \nPlease try again (press any key to continue)");
                    Console.ReadKey();
                }     
                Console.Clear();
            }
            while (true);
        }
    }
}
