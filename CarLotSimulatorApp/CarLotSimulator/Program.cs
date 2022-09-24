using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
            



            //Create a seperate class file called Car -Done

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - Done

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-Done

            //The methods should take one string parameter: the respective noise property-done


            //Now that the Car class is created we can instanciate 3 new cars-done
            //Set the properties for each of the cars-done
            //Call each of the methods for each car-done

            //standard Dot Notation
            Car Toyota = new Car();
            Toyota.Year = 2021;
            Toyota.Make = "Toyota";
            Toyota.Model = "Corolla SE";
            Toyota.EngineNoise = "VrOoOoM";
            Toyota.HonkNoise = "BEEP BEEP";
            Toyota.IsDriveable = true;

            
            //object initalizer syntax
            var mySecondCar = new Car()       //really have 2 corollas
            {
                Year = 2022,
                Make = "Toyota",
                Model = "Corolla LE",
                EngineNoise = "VrooooM",
                HonkNoise = "beep",
                IsDriveable = true
                
            };
            
            // using constructor
            var MyNextCar = new Car(2023, "Toyota", "Corolla GR", "VROOM *back fire*", "Beep", true);
            //want a Gr Corolla
            

            //calling my methods
            Toyota.MakeEngineNoise(Toyota.EngineNoise);
            mySecondCar.MakeEngineNoise(mySecondCar.EngineNoise);
            MyNextCar.MakeEngineNoise(MyNextCar.EngineNoise);

            Toyota.MakeHonkNoise(Toyota.HonkNoise);
            mySecondCar.MakeHonkNoise(mySecondCar.HonkNoise);
            MyNextCar.MakeHonkNoise(MyNextCar.HonkNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //Did above^




            //*************BONUS X 2*************//

            //Create a CarLot class - Done
            //It should have at least one property: a List of cars-Done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            // my car lot
            //first car to lot
            lot.Cars.Add(Toyota);
            //added my second car to the lot
            lot.Cars.Add(mySecondCar);
            //added 3rd car
            lot.Cars.Add(MyNextCar);
            Console.WriteLine("The cars i have on my lot are....");
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($" year: {car.Year} Make :{car.Make} Model:{car.Model}");
            }
            
            Console.WriteLine($"number of cars created {CarLot.numberofcars}");

        }



    }
}
