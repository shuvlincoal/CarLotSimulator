using System;

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


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car1 = new Car();
            //dot notation
            car1.Year = 2023;
            car1.Make = "Nissan";
            car1.Model = "Rogue";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep, beep";
            car1.IsDriveable = "yes";

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //Object initializer syntax
            Car car2 = new Car() { Year = 2023, Make = "Nissan", Model = "Rogue", EngineNoise = "Vroom Vroom", HonkNoise = "Beep", IsDriveable = "Y" }; //order does not matter

            //Custom Constructor
            Car car3 = new Car(2023, "Nissan", "Rogue", "Vroom Vroom", "Beep", "yes"); //order DOES matter





            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarLot.DisplayCars();
            Console.WriteLine("Type the Make of the Car");
            string tmpStr = Console.ReadLine();
            CarLot.AddCar(tmpStr);
            CarLot.DisplayCars();

        }//Main method
    }//class
}//namespace
