// Author: Esau Hervert
// Course: ITSE 1430
// Project 1 Problem 2
// References/Option: None

using System;

namespace ITSE_1430
{
    class EvilNosEH
    {
        static void Main()
        {
            //This counter will see how many 1's we have so that we can see if it is even or odd.
            int evilcounter = 0;

            //Displays information for the user.
            Console.Out.WriteLine("This program will take a positive integer and see if it is evil.\n");

            //Here we will take a number from a user.
            Console.Out.Write("Enter a positive value: ");
            int Int = Convert.ToInt32(Console.ReadLine());

            //This will make sure that if the value is not within range, it will prompt again.
            while (Int > 1000 || Int < 0)
            {
                Console.Out.WriteLine(Int + " was not a valid value!\n");
                Console.Out.Write("Enter a positive value: ");
                Int = Convert.ToInt32(Console.ReadLine());
            }

            //Saving the number for later.
            int Int0 = Int;

            //Displaying the number choosen to the user.
            Console.Out.WriteLine("\nYour value was " + Int + ".");
            int[] Digits = { -1, -1, -1, -1, -1, -1, -1, -1, -1, - 1 };

            //This index is for the array.
            int i = 0;

            //This loop will convert the Decimal to Binary.
            do
            {
                Digits[i] = (Int) % 2;
                
                //If we get a 1, we add it to the counter.
                if (Int % 2 == 1)
                {
                    evilcounter += 1;
                }

                //Reduce the number.
                Int = (Int) / 2;

                i++;
            } while (Int > 0);

            //Display to the user.
            Console.Out.Write("The number in Binary is: ");

            //This will display the converted number.
            for (int j = 0; j <= 9; j++)
            {
                if (Digits[9 - j] != -1)
                {
                    Console.Out.Write(Digits[9 - j]);
                    if ((j - 1) % 4 == 0)
                    {
                        Console.Out.Write(" ");
                    }
                }
            }

            Console.Out.WriteLine();

            //Will let the user know if the number is evil or not.
            if (evilcounter % 2 == 0)
            {
                Console.Out.Write(Int0 + " is an evil number >:).");
            }
            else
            {
                Console.Out.Write(Int0 + " is not an evil number :).");
            }

            Console.Out.WriteLine("\n");

        }
    }
}
