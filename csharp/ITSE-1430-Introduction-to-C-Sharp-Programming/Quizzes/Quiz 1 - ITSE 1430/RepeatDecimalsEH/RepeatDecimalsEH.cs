//Esau Hervert
//ITSE 1430
//Quiz 1 Extra Credit
//No references.

using System;

namespace ITSE_1430
{
    class RepeatDecimalsEH
    {
        static void Main()
        {
            //Initializing the variables.
            int num = 1, den = 1;
            int secocc = 1;
            bool flag = false;
            bool flag2 = false;

            //Calling the menus.
            num = menunum(ref num);

            den = menuden(ref den);

            //Performs the algorithm unless the denominator is 0.
            while (den != 0)
            {
                int truenum = num;
                int trueden = den;
                Console.Out.WriteLine();
                Console.Out.Write("Decimal Representation: ");

                //For Whole Number solutions.
                if (num % den == 0)
                {
                    Console.Out.WriteLine(num / den + ".0");
                    Console.Out.WriteLine("No Repeating digits.");
                }

                //For numbers that terminate after 100 checks.
                for (int i = 0; i < 100; i++)
                {
                    int test = num % den;
                    if (test == 0)
                    {
                        flag = true;
                        continue;
                    }

                    //This moves on to the next digit value.
                    num %= den;
                    num *= 10;
                }

                //Now for the check to see if the number is repeating.

                //These arrays hold the decimals and how many times they appeared in the expansion.
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] array2 = new int[9];

                for (int i = 0; i < 100; i++)
                {
                    int test = num % den;

                    for (int j = 0; j < 9; j++)
                    {
                        if (test == array[j])
                        {
                            array2[j]++;
                        }
                    }
                    
                    //This is to check which number repeated first.
                    for (int k = 0; k < 9; k++)
                    {
                        if (array2[k] > 1)
                        {
                            flag2 = true;
                            secocc = array[k]; 
                        }
                    }

                    //This is suppossed to trigger once the repeat has completed it's loop.
                    if (flag2)
                    {
                        continue;
                    }

                    //On to the next digit.
                    num %= den;
                    num *= 10;
                }

                //Flag for if the decimal terminates.
                if (flag)
                {
                    Console.Out.WriteLine((double) truenum / (double) trueden);
                    Console.Out.WriteLine("No Repeating digits.");
                }

                //Flag for if the decimal does not terminate.
                if (flag2)
                {
                    int test = truenum % trueden;
                    while (test != secocc)
                    {
                        Console.Out.WriteLine(truenum / trueden + ".");

                        truenum %= trueden;
                        truenum *= 10;

                        Console.Out.WriteLine(test);
                        test = truenum % trueden;
                    }
                }

                Console.Out.WriteLine();

                //Ask the user to input the values again.
                num = menunum(ref num);

                den = menuden(ref den);
            }
        }

        //These are the menus so that the user can input their numbers.
        //This is the numerator menu.
        static int menunum(ref int num)
        {
            Console.Out.Write("Enter numerator: ");
            num = Convert.ToInt32(Console.ReadLine());

            return num;
        }

        //This is the denominator menu.
        static int menuden(ref int den)
        {
            Console.Out.Write("Enter denominator: ");
            den = Convert.ToInt32(Console.ReadLine());

            return den;
        }
    }
}
