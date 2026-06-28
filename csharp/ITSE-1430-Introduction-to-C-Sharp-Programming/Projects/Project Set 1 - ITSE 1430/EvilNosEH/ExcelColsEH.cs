// Author: Esau Hervert
// Course: ITSE 1430
// Project 1 Problem
// References/Option: None

using System;

namespace ITSE_1430
{
    class ExcelColsEH
    {
        static void Main(string[] args)
        {
            //This is where all the characters will be stored and taken from.
            char[] Array = { 'A','B','C','D','E','F','G','H','I','J',
                             'K','L','M','N','O','P','Q','R','S','T',
                             'U','V','W','X','Y','Z'};

            //Prompt the user to input an integer from 1 to 1000000.
            Console.Out.Write("Enter a positive column number between 1 and 1000000: ");
            int Int = Convert.ToInt32(Console.ReadLine());

            //This is in case the user inputs a value that is not in the bounds.
            if (Int > 1000000 || Int < 1)
            {
                do
                {
                    Console.Out.Write("That was not a valid input!\n\n");
                    Console.Out.Write("Enter a positive column number between 1 and 1000000: ");
                    Int = Convert.ToInt32(Console.ReadLine());
                } while (Int > 1000000 || Int < 1);
            }

            //This array will be used to store the converted decimal values at each exponent.
            int[] Digits = { -1, -1, -1, -1, -1, -1};

            //This is the loop where the number will be converted from decimal to base 26.
            int i = 0;
            do
            {
                Digits[i] = (Int - 1) % 26;
                Int = (Int - 1) / 26;
                
                i++;
            } while (Int > 0);

            //This will display the converted number.
            for (int j = 0; j <= 5; j++)
            {
              if (Digits[5 - j] != -1)
               {
                  Console.Out.Write(Array[Digits[5 - j]]);
               }
            }
            Console.Out.WriteLine();

        }
    }
}
