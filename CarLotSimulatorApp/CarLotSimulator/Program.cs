using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {

        //Fields

        //Property's
        public static  List<Car> ListOfCars { get; set; } = new List<Car>();


        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            string tmpStr = "";
            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //instantiate, create a "Car" object
            Car car1 = new Car();
            //Uses the DEFAULT CONSTRUCTOR
            //use dot notation to **SET** the object propertys <---<<<
            car1.Year        = 2023;
            car1.Make        = "Nissan";
            car1.Model       = "Rogue";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise   = "Beep, beep";
            car1.IsDriveable = "yes";

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //instantiate, create a "Car" object <---<<<
            //Object initializer syntax to **SET** the object propertys
            //Uses the DEFAULT CONSTRUCTOR
            //ADVANTAGE: Don't HAVE to supply ALL the parameters
            Car car2 = new Car() { Year = 1960, Make = "Ford", Model = "Cobra", EngineNoise = "Vroom Vroom", HonkNoise = "Beep", IsDriveable = "Y" }; //order does not matter

            //instantiate, create a "Car" object <---<<<
            //Uses Custom Constructor to **SET** the object propertys
            Car car3 = new Car(1955, "Chevrolet", "Covette", "Vroom Vroom", "Beep", "Y" ); //order does not matter

            Car.MakeEngineNoise("Vroom! Vroom!");
            Car.MakeHonkNoise("Beep! Beeeeeeeeeeeeeep!");

            Console.WriteLine("View Car");
            Console.Write($"Car1: {car1.Year}, {car1.Make}, {car1.Model}");
            tmpStr = Console.ReadLine();
            

            Console.WriteLine("--------------\n\n");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //Display Cars Variation 1 
            Program.ListOfCars.Add(car1);
            Program.ListOfCars.Add(car2);
            Program.ListOfCars.Add(car3);

            foreach (Car car in Program.ListOfCars)
            {
                Console.WriteLine($"Make: {car.Make}, Year:{car.Year}, Model:{car.Model}");
            }

            //Display Cars Variation 2
            CarLot.DisplayCars();
            Console.WriteLine("Press Return To Concontinue> ");
            tmpStr = Console.ReadLine();
            Console.WriteLine("--------------\n\n");

            //Add a car to inventory
            while (tmpStr != "xxx")
            {
                Console.WriteLine("Adding another car to inventory...");
                Console.WriteLine("Type the Make of the Car");
                tmpStr = Console.ReadLine();
                CarLot.AddCar(tmpStr);
                Console.WriteLine("Press Return to Add another car or xxx to exit> ");
                tmpStr = Console.ReadLine();
            }
            
            //Display cars again
            CarLot.DisplayCars();

        }//Main method
    }//class
}//namespace
