//Esau Hervert
//ITSE 1430
//Project 4: problem 1.
//Option: Extra Credit!!!
//Reference: https://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx get set
// https://msdn.microsoft.com/en-us/library/ebca9ah3.aspx overide
// https://stackoverflow.com/questions/15251167/how-to-extend-a-class-in-c - extending class.

using System;

namespace ITSE_1430
{
    class TestShipEH
    {
        public static void Main()
        {
            Ship ship = new Ship("BoatyMcBoatFace", "2015");
            Console.Out.WriteLine(ship.ToString());

            Console.Out.WriteLine();

            CruiseShip ship2 = new CruiseShip("Nickelodean", "1492", 2500);
            Console.Out.WriteLine(ship2.ToString());

            Console.Out.WriteLine();

            CargoShip ship3 = new CargoShip("Hauling", "2017", 1500);
            Console.Out.WriteLine(ship3.ToString());

            Console.Out.WriteLine();
        }

    }
    public class Ship
    {
        public string Name { get; set; }
        private string Date { get; set; }

        public Ship(string Name, string Date)
        {
            this.Name = Name;
            this.Date = Date;
        }

        public virtual string ToString()
        {
            return "Name: " + Name + "\nYear Built: " + Date;
        }
    }

    public class CruiseShip : Ship
    {
        public CruiseShip(string Name, string Date, int MaxPass) : base(Name, Date)
        {
            this.MaxPass = MaxPass;
        }

        public int MaxPass { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\nMaximum passengers: " + MaxPass;
        }

    }

    class CargoShip : Ship
    {
        public CargoShip(string Name, string Date, int Capacity) : base(Name, Date)
        {
            this.Capacity = Capacity;
        }

        public int Capacity { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\nCargo capacity: " + Capacity + " tons";
        }

    }
}