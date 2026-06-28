//Esau Hervert
//ITSE 1430
//Program 2 - Problem 1
//References/Option: None

using System;

namespace ITSE_1430
{
    class PingPongEH
    {
        public static void Main()
        {
            //Here are the variables that we will be using.
            double level1 = 0, level2 = 0;

            //Heading.
            Console.Out.WriteLine("Table Tennin\n");

            //Purpose of the program.
            Console.Out.WriteLine("This program will predict the outcome of a match between two players.\n");

            //Take player1 stats.
            Console.Out.Write("Enter skill level for Player 1: ");
            level1 = Input();
            while (level1 > 10 || level1 < 0)
            {
                Console.Out.WriteLine("This was not a valid input.");
                Console.Out.Write("Enter skill level for Player 1: ");
                level1 = Input();
            }

            //Take player2 stats.
            Console.Out.Write("Enter skill level for Player 2: ");
            level2 = Input();
            while (level2 > 10 || level2 < 0)
            {
                Console.Out.WriteLine("This was not a valid input.");
                Console.Out.Write("Enter skill level for Player 2: ");
                level2 = Input();
            }

            //This will take the winner.
            if (Game(level1, level2))
                Console.Out.WriteLine("Overall Winner is Player 1.");
            else
                Console.Out.WriteLine("Overall Winner is Player 2.");
        }
        //This program will simulate a game and use a seed in the random so that the random numbers can be different every time.
        public static bool PingPongGame(double one, double two, int i)
        {
            bool game = true;
            double pick = 0;

            var random = new Random(i);

            pick = (one + two) * random.NextDouble();

            if (pick < one)
            {
                game = true;
            }
            else
            {
                game = false;
            }

            return game;
        }
        
        //This program will run as many games as needed until the conditions are met for there to be a winner.
        public static bool Game(double level1, double level2)
        {
            bool winner = true;
            bool flag = true;
            int player1 = 0, player2 = 0;

            Random rand = new Random();
            int i = rand.Next(1, 100);
            
            //Here is the game.
            while (flag)
            {
                if (PingPongGame(level1, level2,i))
                {
                    player1 += 1;
                }
                else
                {
                    player2 += 1;
                }
                i++;

                //Consitions for winning.
                if (player1 >= 11 && (player1 - player2) >= 2)
                {
                    winner = true;
                    flag = false;
                }
                else if (player2 >= 11 && (player2 - player1) >= 2)
                {
                    winner = false;
                    flag = false;
                }
                else if (player1 >= 10 && player2 >= 10)
                {
                    if ((player1 - player2) >= 2)
                    {
                        winner = true;
                        flag = false;
                    }
                    if ((player2 - player1) >= 2)
                    {
                        winner = false;
                        flag = false;
                    }
                }
            }

            Console.Out.WriteLine();

            //Displays the score.
            Console.Out.WriteLine("Number won by Player 1: " + player1);
            Console.Out.WriteLine("Number won by Player 2: " + player2);

            Console.Out.WriteLine();

            return winner;
        }

        //To take in a value.
        public static double Input()
            {
                double In = 0;
                In = Convert.ToDouble(Console.ReadLine());
                return In;
            }
    }
}
