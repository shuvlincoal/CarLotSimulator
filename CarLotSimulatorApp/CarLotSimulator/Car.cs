using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {

        //public int    Year;           //fields/attributes
        //public string Make;           //you CAN NOT have same 
        //public string Model;          //name fields here that
        //public string EngineNoise;    //used in propertys
        //public string HonkNoise;
        //public string IsDriveable;
        public int Price = 1200;

        

        public Car()   //explicity defined default constructor
        {
        }
        public Car(int taco, string make, string model, string engineNoise, string honkNoise, string isDriveable) //custom constructor
            //this **ESTABLISHES the order** parameters are passed in
        {
            //This FOLLOWS the order
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
        public int Year           { get; set; }  //property
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

    }
}
