using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            string tmpStr = "";
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //instantiate, create a "Car" object
            Car car1 = new Car();

            //use dot notation to **SET** the object propertys
            car1.Year        = 2023;
            car1.Make        = "Nissan";
            car1.Model       = "Rogue";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise   = "Beep, beep";
            car1.IsDriveable = "yes";

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //instantiate, create a "Car" object
            //Object initializer syntax to **SET** the object propertys
            Car car2 = new Car() { Year = 2023, Make = "Nissan", Model = "Rogue", EngineNoise = "Vroom Vroom", HonkNoise = "Beep", IsDriveable = "Y" }; //order does not matter

            //instantiate, create a "Car" object
            //Custom Constructor to **SET** the object propertys

            //Experimental
            //Car car3 = new Car(2023, "Nissan", "Rogue", "Vroom Vroom", "Beep", "yes"); //order DOES matter

            //Dictionary<string, List<string>> CarDict = new Dictionary<string, List<string>>();
            //List<string> Car1List = new List<string>("Nissan",);
            //END Experiment


            Console.WriteLine("View Car");
            Console.Write($"Car1: {car1.Year}, {car1.Make}, {car1.Model}");
            tmpStr = Console.ReadLine();
            Console.WriteLine("--------------\n\n");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //Display Cars
            CarLot.DisplayCars();
            Console.WriteLine("Press Return To Concontinue> ");
            tmpStr = Console.ReadLine();
            Console.WriteLine("--------------\n\n");

            //Add a car to inventory
            Console.WriteLine("Type the Make of the Car");
            tmpStr = Console.ReadLine();
            CarLot.AddCar(tmpStr);
            
            //Display cars again
            CarLot.DisplayCars();

        }//Main method
    }//class
}//namespace
