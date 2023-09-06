using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        //Fields go here
        public static List<string> Cars = new List<string>() { "Mazeratti", "Ferrari", "Pinto", "SR71", "DeLorean" };

        //Constructors go here
        public CarLot()   //explicity defined default constructor
        {
        }

        public CarLot(List<string> CarInventory) //Custom constructor
        {

        }



        //Propertys go here
        public List<string> CarInventory { get; set; }  //property
        //public string Address { get; set; }
        //public string BizHours { get; set; }


        public static void AddCar(string make)
        {

            CarLot.Cars.Add(make);
            Console.WriteLine($"{make} Added to inventory");
        }


        public static void DisplayCars()
        {
            Console.WriteLine("Best Little Used Car Lot There is!!!");
            Console.WriteLine("Low Mileage guaranteed!!!");
            for (int i=0; i< Cars.Count; i++)
            {
                Console.WriteLine($"{Cars[i]}");
            }

        }









    }
}
