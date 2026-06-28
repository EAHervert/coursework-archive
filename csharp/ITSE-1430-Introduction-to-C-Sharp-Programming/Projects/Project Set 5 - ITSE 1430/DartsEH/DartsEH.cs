// Esau Hervert
// ITSE 1430
// Projct 5, Program 4
// Option: The one hard problem.
// References: http://stackoverflow.com/questions/1968328/read-numbers-from-a-text-file-in-c-sharp - How to separate the numbers in a nice form to read them.

using System;
using System.IO; // For Text Manipulation.

namespace ITSE_1430
{
    class DartsEH
    {
        public static void Main(string[] args)
        {

            string filename = ""; // Where the file directory will be stored.

            filename = Console.ReadLine();

            filename = filename.Replace("\\", "\\\\"); // So that the file reader can read the file.

            Console.Out.WriteLine(); //Display reasons.

            // Opening the file and reading the two lines.
            StreamReader file = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
            string data1 = file.ReadLine();
            string data2 = file.ReadLine();

            // The Games.
            Score G1 = new Score(data1);
            G1.Results();

            Score G2 = new Score(data2);
            G2.Results();
        }

        class Score
        {
            private int P1Value, P2Value; // Final values of the individual players.
            private double X11, X12, X13, Y11, Y12, Y13; // Coordinate value for player 1.
            private double X21, X22, X23, Y21, Y22, Y23; // Coordinate value for player 2.
            private int ring1 = 3, ring2 = 6, ring3 = 9, ring4 = 12, ring5 = 15; // The ring radii.
            private int r1value = 100, r2value = 80, r3value = 60, r4value = 40, r5value = 20; // Value for hitting each ring.

            public Score(string Score)
            {
                string[] bits = Score.Split(' '); // To separate the numbers.

                // Setting the numbers to the correct value.
                X11 = double.Parse(bits[0]);
                Y11 = double.Parse(bits[1]);
                X12 = double.Parse(bits[2]);
                Y12 = double.Parse(bits[3]);
                X13 = double.Parse(bits[4]);
                Y13 = double.Parse(bits[5]);
                X21 = double.Parse(bits[6]);
                Y21 = double.Parse(bits[7]);
                X22 = double.Parse(bits[8]);
                Y22 = double.Parse(bits[9]);
                X23 = double.Parse(bits[10]);
                Y23 = double.Parse(bits[11]);

            }

            // Calculates the radius of the point from the origin.
            public double Radius(double X, double Y)
            {
                double r = Math.Pow(Math.Pow(X, 2) + Math.Pow(Y, 2), .5);
                return r;
            }

            // Sets the correct score.
            public int value(double X, double Y)
            {
                int v = 0;

                if (Radius(X, Y) <= ring1)
                    v = r1value;
                else if (Radius(X, Y) > ring1 && Radius(X, Y) <= ring2)
                    v = r2value;
                else if (Radius(X, Y) > ring2 && Radius(X, Y) <= ring3)
                    v = r3value;
                else if (Radius(X, Y) > ring3 && Radius(X, Y) <= ring4)
                    v = r4value;
                else if (Radius(X, Y) > ring4 && Radius(X, Y) <= ring5)
                    v = r5value;
                else
                    v = 0;

                return v;
            }

            // Adds up the values of the individual darts for each player and displays the winner.
            public void Results()
            {
                P1Value = value(X11, Y11) + value(X12, Y12) + value(X13, Y13);
                P2Value = value(X21, Y21) + value(X22, Y22) + value(X23, Y23);

                Console.Out.Write("SCORE: " + P1Value + " to " + P2Value + ", ");

                if (P1Value == P2Value)
                    Console.Out.WriteLine("TIE.");
                else if (P1Value > P2Value)
                    Console.Out.WriteLine("PLAYER 1 WINS.");
                else if (P2Value > P1Value)
                    Console.Out.WriteLine("PLAYER 2 WINS.");
            }
        }
    }
}
