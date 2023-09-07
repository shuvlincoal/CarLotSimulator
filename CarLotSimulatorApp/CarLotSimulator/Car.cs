using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {   //Fields are created directly inside the class
        //Fields are accessible from anywhere in our outside the class (if public)
        //If a field is changed from anywhere - its changed everywhere its used
        //Fields use camel casing
        //              Camel Casing
        //public int    year;           //fields/attributes
        //public string make;           //you CAN NOT have same 
        //public string model;          //name fields here that
        //public string engineNoise;    //used in propertys
        //public string honkNoise;
        //public string isDriveable;
        public int price = 1200;


        //"static" vs non "static"
        //"static" MUST use classname.method
        //A static class is basically the same as a non-static
        //class, but there is one difference: a static class
        //cannot be instantiated. In other words, you cannot
        //use the new operator to create a variable of the class
        //type. Because there is no instance variable, you
        //access the members of a static class by using the
        //class name itself. 

        //A static class can be used as a convenient container
        //for sets of methods that just operate on input parameters
        //and do not have to get or set any internal instance fields

        //non static allows us to use instance.method
        //Car car1 = new Car();
        public Car()   //explicity defined default constructor
        {
        }
        public Car(int taco, string make, string model, string engineNoise, string honkNoise, string isDriveable) //custom constructor
            //this **ESTABLISHES the order** parameters are passed in
        {
            //This FOLLOWS the order
            //Pascal      camel Casing
            Year        = taco;
            Make        = make;
            Model       = model;
            EngineNoise = engineNoise;
            HonkNoise   = honkNoise;
            IsDriveable = isDriveable;
            //Price       = price;

        }

        //This construct of "Property" is required in order to
        //default AND custom Constructor
        //            Pascal Casing
        public int    Year        { get; set; }  //property
        public string Make        { get; set; }  //property
        public string Model       { get; set; }  //property
        public string EngineNoise { get; set; }  //property
        public string HonkNoise   { get; set; }  //property
        public string IsDriveable { get; set; }  //property



        public static void MakeEngineNoise(string noise)
        {


        }

        public static void MakeHonkNoise(string honK)
        {


        }

    }//class
}//namespace
