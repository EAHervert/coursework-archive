//Esau Hervert
//ITSE 1430
//Program 2 - Problem 2
//References/Option: http://stackoverflow.com/questions/665299/are-2-dimensional-lists-possible-in-c <- for the 2D lists.

using System;
using System.Collections.Generic; // For the multidimentional list.

namespace ITSE_1430
{
    class MatrixTransposeEH
    {
        public static void Main()
        {
            //This is where the variables will be initialized.
            int rows = 1, columns = 1;
            int rowst = 1, columnst = 1;
            double value = 0;
            //Porpose of the program.
            Console.Out.WriteLine("This program will take a matrix up to 5x5 and output the traspose.\n");

            //Getting the dimentions of the Matrix and checking for error bounds.
            Console.Out.Write("Enter the number of rows: ");
            rows = Scan();
            while (rows > 5 || rows < 1)
            {
                Console.Out.WriteLine("Please enter a valid size.");
                Console.Out.Write("Enter the number of rows: ");
                rows = Scan();
            }

            Console.Out.Write("Enter the number of columns: ");
            columns = Scan();
            while(columns > 5 || columns < 1)
            {
                Console.Out.WriteLine("Please enter a valid size.");
                Console.Out.Write("Enter the number of columns: ");
                columns = Scan();
            }

            Console.Out.WriteLine();
            
            //Gettingt the dimensions of the transpose.
            rowst = columns;
            columnst = rows;

            //Creating a Matrix.
            //***************************************************************************************************************
            List<List<double>> Matrix = new List<List<double>>();
            
            for (int i = 0; i < rows; i++)
            {
                Matrix.Add(new List<double>());
                for (int j = 0; j < columns; j++)
                {
                    Console.Out.Write("Enter the at " + (i + 1) + " " + (j + 1) + ": ");
                    value = ScanD();
                    Matrix[i].Add(value);
                }
            }
            //***************************************************************************************************************

            Console.Out.WriteLine();

            //Displaying the matrix.
            //***************************************************************************************************************
            Console.Out.WriteLine("The Matrix that was inputted is: \n");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Out.Write(Matrix[i][j] + "       ");
                }
                Console.Out.WriteLine("\n");
            }
            //***************************************************************************************************************

            //Now for the transpose.
            //***************************************************************************************************************
            Console.Out.WriteLine("The transpose is: \n");

            List<List<double>> MatrixT = new List<List<double>>();

            for (int i = 0; i < rowst; i++)
            {
                MatrixT.Add(new List<double>());
                for (int j = 0; j < columnst; j++)
                {
                    MatrixT[i].Add(Matrix[j][i]);
                    Console.Out.Write(MatrixT[i][j] + "      ");
                }
                Console.Out.WriteLine("\n");
            }
            //***************************************************************************************************************

        }
        //This will allow for scanning integers.
        public static int Scan()
        {
            int i = 0;

            i = Convert.ToInt32(Console.ReadLine());

            return i;
        }
        //This will allow for scanning doubles.
        public static double ScanD()
        {
            double i = 0;

            i = Convert.ToDouble(Console.ReadLine());

            return i;
        }
    }
}
