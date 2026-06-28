//Esau Hervert
//ITSE 1430
//Quiz 1 Extra Credit
//Options/References: https://msdn.microsoft.com/en-us/library/471w8d85(v=vs.110).aspx - To read the enter key.

using System;

namespace ITSE_1430
{
    class PennyPitchEH
    {
        public static void Main()
        {
            //*********************************************************************************************************
            //Create the Matrix which will contain all the values.
            char[,] PennyPincher = { { '1', '1', '1', '1', '1' }, { '1', '2', '2', '2', '1' }, 
                { '1', '2', '3', '2', '1' }, { '1', '2', '2', '2', '1' }, { '1', '1', '1', '1', '1' } };

            //*********************************************************************************************************

            //*********************************************************************************************************
            //This is where the value of the game will be stored as well as the times played.
            int value = 0;
            int played = 0;
            int r = 0, c = 0;
            int size = 5;
            Boolean flag = true;
            //*********************************************************************************************************

            //*********************************************************************************************************
            //This is for the random number generating.
            Random rand = new Random(DateTime.Now.Millisecond);
            int i = rand.Next(1, 100);
            //*********************************************************************************************************

            //*********************************************************************************************************
            //Purpose of the program.
            Console.Out.WriteLine("Let's Play Penny Pincher.");

            //Display the board.
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    Console.Out.Write(PennyPincher[j,k] + " ");
                }

                Console.Out.WriteLine();
            }
            //*********************************************************************************************************

            //*********************************************************************************************************
            while (played < 5 && flag)
            {
                //********************************************************************************************************
                //Values that we will be using to run our programs.
                var random1 = new Random(i * DateTime.Now.Millisecond);
                c = random1.Next(0, 5);
                var random2 = new Random(i * DateTime.Now.Millisecond);
                r = random2.Next(0, 5);
                //*********************************************************************************************************

                //Change the value that is held at the point to P.
                if (PennyPincher[c,r] != 'P')
                {
                    Console.Out.WriteLine();

                    played++;
                    Console.Out.WriteLine("Toss #:" + played);

                    //Subtract 48 because '1' = 49.
                    value += Convert.ToInt32(PennyPincher[c, r]) - 48;
                    PennyPincher[c, r] = 'P';

                    Console.Out.WriteLine("Total Amount: " + value);
                    Console.Out.WriteLine();

                    //Display the board.
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            Console.Out.Write(PennyPincher[j, k] + " ");
                        }

                        Console.Out.WriteLine();
                    }
                    //*********************************************************************************************************
                    //Ask them to press enter so that they can continue.
                    if (played < 5)
                    {
                        Console.Out.WriteLine("Press Enter to toss a penny");

                        //checks if the enter key was pressed.
                        if (Console.ReadKey().Key == ConsoleKey.Enter)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }


                }
            }
            //*********************************************************************************************************

            Console.Out.WriteLine();

            //*********************************************************************************************************
            //This is where the final result.

            Console.Out.WriteLine("The final value is " + value + ".");

            Console.Out.WriteLine();

            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    Console.Out.Write(PennyPincher[j, k] + " ");
                }

                Console.Out.WriteLine();
            }
            //*********************************************************************************************************

        }
    }
}
