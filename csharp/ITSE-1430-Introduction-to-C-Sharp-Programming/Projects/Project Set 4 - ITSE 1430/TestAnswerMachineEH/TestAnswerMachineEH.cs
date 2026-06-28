//Esau Hervert
//ITSE 1430
//Project 4: Problem 4.
//Option: Problem 4, Hard Problem.
//Resources: https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx : Datetime.

using System;

namespace ITSE_1430
{
    //This class will have the information for the Missed Calls.
    public class MissedCall
    {
        public MissedCall() { } // Constructor.
        public MissedCall(int yr, int m, int d, int hr, int min, int se) // For the Private Caller/
        {
            setDateTime(yr, m, d, hr, min, se);
        }
        public MissedCall(long N, string Nm, int yr, int m, int d, int hr, int min, int se) // For the regular Caller.
        {
            setNumber(N);
            setName(Nm);
            setDateTime(yr, m, d, hr, min, se);
        }

        // Private variables. 
        private long Number = 0000000000;
        private string Name = "Private";
        private DateTime Time;

        //*************************************************************************************************************************************
        // Get and set methods.
        public long getNumber()
        {
            return Number;
        }

        public void setNumber(long N)
        {
            Number = N;
        }

        public string getName()
        {
            return Name;
        }
        public void setName(string Nm)
        {
            if (Number != 0000000000)
                Name = Nm;
        }

        public DateTime getDateTime()
        {
            return Time;
        }
        public void setDateTime(int yr, int m, int d, int hr, int min, int sec)
        {
            Time = new DateTime(yr, m, d, hr, min, sec);
        }
        //*************************************************************************************************************************************

        //*************************************************************************************************************************************
        // Displays the information about the caller.
        public void getInfo()
        {
            Console.Out.WriteLine("Name: " + getName());

            if (Number != 0)
            Console.Out.WriteLine("Phone Number: " + getNumber());

            Console.Out.WriteLine("Date Received: " + getDateTime());

            Console.Out.WriteLine();
        }
    }

    // This is the Answering Machine.
    public class AnsweringMachine
    {

        private int delete = 0; // This is where the amount of deleted calls is supposed to be kept.
        private int counter = 0;
        public AnsweringMachine() { } // Constructor.

        private MissedCall[] Calls = new MissedCall[5]; // Array of missed calls.

        //*************************************************************************************************************************************
        // This method is supposed to take in a missed call and put it in order.
        // It kinda works, but it has flaws.
        public void addMissedCall(MissedCall M)
        {
            counter++;

            for (int i = 0; i < counter; i++)
            {
                if (Calls[i] == null)
                {
                    //Initializes with the first added call.
                    if (counter == 1)
                        Calls[0] = M;
                    else
                    {
                        if (M.getDateTime() > Calls[i - 1].getDateTime() && counter != 5) // Tests the date to see if it is at a newer date.
                        {
                            for (int j = 0; j < (counter - 1); j++)
                            {
                                Calls[counter - j] = Calls[counter - j - 1];
                            }
                            Calls[i] = M;
                        }
                        else if (counter == 5) // I was having issues witht the last input.
                        {
                            if (M.getDateTime() > Calls[i- 1].getDateTime())
                            {
                                for (int j = 0; j < counter - 1; j++)
                                {
                                    Calls[4 - j] = Calls[counter - j - 1];
                                }
                                Calls[i] = M;
                            }
                        }
                        else
                        {
                            Calls[counter - 1] = M;
                        }
                    }
                }
            }
        }

        //This method would return how many times an Call was deleted.
        public int getDelete()
        {
            return delete;
        }

        //Displays the calls to the user.
        public void DisplayCalls()
        {
            Console.Out.WriteLine("Here are the Calls:");
            for (int i = 0; i < 5; i++)
            {
                if (Calls[i] != null)
                {
                    Calls[i].getInfo();
                }
            }

        }
    }


    class TestAnswerMachineEH
    {
        public static void Main()
        {
            //*************************************************************************************************************************************
            // Here are some random calls.
            MissedCall M1 = new MissedCall(8176953465, "Maria Teresa", 2016, 11, 5, 11, 17, 56);
            M1.getInfo();

            MissedCall M2 = new MissedCall(2016, 10, 6, 11, 56, 03);
            M2.getInfo();

            MissedCall M3 = new MissedCall(2016, 8, 6, 23, 56, 09);
            M3.getInfo();

            MissedCall M4 = new MissedCall(8176992332, "Catherine the Great", 2015, 10, 6, 11, 56, 03);
            M4.getInfo();

            MissedCall M5 = new MissedCall(4698894655, "Frederic the Great", 2016, 10, 6, 8, 56, 03);
            M5.getInfo();
            //*************************************************************************************************************************************

            Console.Out.WriteLine();

            //*************************************************************************************************************************************
            AnsweringMachine A1 = new AnsweringMachine();

            //Adding the calls.
            A1.addMissedCall(M1);
            A1.addMissedCall(M2);
            A1.addMissedCall(M3);
            A1.addMissedCall(M4);
            A1.addMissedCall(M5);

            //Displaying the results.
            A1.DisplayCalls();
            //*************************************************************************************************************************************
        }

    }
}