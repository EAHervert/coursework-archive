//Esau Hervert
//ITSE 1430
//Project 3 - Problem 2
//References/Option: http://stackoverflow.com/questions/4060961/seeding-a-pseudo-random-number-generator-in-c-sharp - DateTime.Now.Ticks.GetHashCode() 
//Note: I was not able to make te GUI application work in time so I wrote the code that would be turned into the GUI.

using System;

namespace ITSE_1430
{
    class ShutTheBoxEH
    {
        public static void Main(string[] args)
        {
            //Create te random seed and the box with all the values.
            int i = DateTime.Now.Ticks.GetHashCode();

            //These are all the variables that the program will use.
            int dice1 = 0, dice2 = 0;
            int count = 0;
            int shut = 0;
            int roll = 0;
            int[] box = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };


            //Purpose of the Program.
            Console.Out.Write("This Program will simulate a game of shut the box.\n");

            Console.WriteLine();

            //***************************************************************************************************************************************************************
            //This loop will run until all the boxes are shut.
            while (!isZero(box))
            {

                //***********************************************************************************************************************************************************
                //This loop will run until the values of 7 to 12 are shut.
                while (!isUpper(box))
                {
                    //Set the dice values.
                    dice1 = dice((i += 1000 + DateTime.Now.Ticks.GetHashCode()));
                    dice2 = dice((i += 20000 + DateTime.Now.Ticks.GetHashCode()));

                    //Checks if the values that the user rolled are usable.
                    if (box[dice1 - 1] != 0 || box[dice2 - 1] != 0 || box[dice1 + dice2 - 1] != 0)
                    {

                        //***************************************************************************************************************************************************
                        //This will show what boxes are still open.
                        Console.Out.WriteLine();
                        Console.Out.Write("The open values are: ");

                        for (int k = 0; k < 12; k++)
                        {
                            if (box[k] != 0)
                            {
                                Console.Out.Write("[" + box[k] + "] ");
                            }
                        }
                        //***************************************************************************************************************************************************

                        //***************************************************************************************************************************************************
                        //The user's Dice.
                        Console.Out.Write("\nHere are your Dice: ");
                        Console.Out.WriteLine(dice1 + " " + dice2);

                        Console.Out.WriteLine("The options are: ");
                        //***************************************************************************************************************************************************

                        //Reinitializes the count for the option indexing
                        count = 0;

                        //***************************************************************************************************************************************************
                        //Checks if the individual dices and their sum are valid.
                        if (box[dice1 - 1] != 0)
                        {
                            count++;
                            Console.Out.WriteLine(count + ": Shut " + dice1);
                        }

                        if (box[dice2 - 1] != 0 && dice2 != dice1)
                        {
                            count++;
                            Console.Out.WriteLine(count + ": Shut " + dice2);
                        }

                        if (box[dice1 + dice2 - 1] != 0)
                        {
                            count++;
                            Console.Out.WriteLine(count + ": Shut " + (dice1 + dice2));
                        }

                        //***************************************************************************************************************************************************
                        //Shut the box.
                        Console.Out.Write("Enter which value you want shut: ");
                        shut = Convert.ToInt32(Console.ReadLine());

                        box[shut - 1] = 0;
                        roll++;
                        Console.Out.WriteLine("Roll Count : " + roll);

                        //***************************************************************************************************************************************************
                    }
                    //*******************************************************************************************************************************************************
                    //This is when the roll is not a good roll.
                    else
                    {
                        Console.Out.WriteLine("\nInvalid Roll. Dice were: " + dice1 + " " + dice2);
                        roll++;
                        Console.Out.WriteLine("Roll Count : " + roll);
                    }
                    //*******************************************************************************************************************************************************


                }
                //***********************************************************************************************************************************************************
                //The case where only one dice is in play.
                dice1 = dice((i += 300000 + DateTime.Now.Ticks.GetHashCode()));

                //Checks if the value is valid.
                if (box[dice1 - 1] != 0)
                {
                    //*******************************************************************************************************************************************************
                    //Same as above.
                    Console.Out.WriteLine();
                    Console.Out.Write("The open values are: ");

                    for (int k = 0; k < 12; k++)
                    {
                        if (box[k] != 0)
                        {
                            Console.Out.Write("[" + box[k] + "] ");
                        }
                    }
                    //*******************************************************************************************************************************************************

                    //*******************************************************************************************************************************************************
                    //same as above except there is only one dice now.
                    Console.Out.Write("\nHere are your Dice: ");
                    Console.Out.WriteLine(dice1);

                    Console.Out.WriteLine("The options are: ");
                    //*******************************************************************************************************************************************************

                    count = 0;
                    //*******************************************************************************************************************************************************
                    //Shut the box.
                    if (box[dice1 - 1] != 0)
                    {
                        count++;
                        Console.Out.WriteLine(count + ": Shut " + dice1);
                    }

                    Console.Out.Write("Enter which value you want shut: ");
                    shut = Convert.ToInt32(Console.ReadLine());

                    box[shut - 1] = 0;
                    roll++;
                    Console.Out.WriteLine("Roll Count : " + roll);
                    //*******************************************************************************************************************************************************

                }
                //***********************************************************************************************************************************************************
                //Check if the boxes have not been all shut.
                else if (!isZero(box))
                {
                    Console.Out.WriteLine("\nInvalid Roll. Dice was: " + dice1);
                    roll++;
                    Console.Out.WriteLine("Roll Count : " + roll);
                }
                //***********************************************************************************************************************************************************
            }

            //***************************************************************************************************************************************************************
            //End the Game.
            Console.Out.WriteLine("\nGame Completed.");
            Console.Out.WriteLine("Final Roll Count: " + roll);
            //***************************************************************************************************************************************************************
        }
        //*******************************************************************************************************************************************************************
        //This method will simulate the random roll with a new seeder each time.
        public static int dice(int i)
        {
            //These are the dice values.
            int[] Dice = { 1, 2, 3, 4, 5, 6 };

            //Creating a random number.
            Random rand = new Random(i);
            int r = rand.Next(6);

            //returning the dice value.
            return Dice[r];

        }

        //***************************************************************************************************************************************************************
        //Will let us know if the boxes have been shut.
        public static Boolean isZero(int[] B)
        {
            bool boolean = false;
            int counter = 0;

            //Checks each value.
            for (int i = 0; i < 12; i++)
            {
                if (B[i] == 0)
                    counter++;
            }

            //Checks if they are closed.
            if (counter == 12)
                boolean = true;
            return boolean;
        }
        //***************************************************************************************************************************************************************

        //***************************************************************************************************************************************************************
        //Will llet us know if the last six numbers have been shut.
        public static Boolean isUpper(int[] B)
        {
            bool boolean = false;
            int counter = 0;

            //Checks each value higher than 6.
            for (int i = 6; i < 12; i++)
            {
                if (B[i] == 0)
                    counter++;
            }

            //Checks if they are all closed.
            if (counter == 6)
                boolean = true;

            return boolean;
        }
        //***************************************************************************************************************************************************************

    }


}
