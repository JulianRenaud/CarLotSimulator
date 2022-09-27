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


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();
            carLot.CarList = new List<Car>();


            
            
            var Car1 = new Car();

            
            Car1.Year = "2006";
            Car1.Make = "Toyota";
            Car1.Model = "R1";
            Car1.EngineNoise = "Low";
            Car1.HonkNoise = "High Pitch";
            Car1.IsDrivable = "No";


            carLot.CarList.Add(Car1);
            

            Car1.PrintInfo();

            Console.WriteLine($"Number of cars: {CarLot.NumberOfCars}");





            var Car2 = new Car()
            {
                Year = "2020",
                Make = "Corvette",
                Model = "ZR6",
                EngineNoise = "Loud",
                HonkNoise = "High Pitch",
                IsDrivable = "Yes"
            };

            carLot.CarList.Add(Car2);
            Car2.PrintInfo();

            Console.WriteLine($"Number of cars: {CarLot.NumberOfCars}");

            var Car3 = new Car("2022", "Lamborghini", "Turbo", "Extremely Loud", "Low Pitch", "Yes");
            carLot.CarList.Add(Car3);
            Car3.PrintInfo();
            Console.WriteLine($"Number of cars: {CarLot.NumberOfCars}");

            foreach (var Car in carLot.CarList)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(Car.Year);
                Console.WriteLine(Car.Make);
                Console.WriteLine(Car.Model);
                
                


            }
            





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}



