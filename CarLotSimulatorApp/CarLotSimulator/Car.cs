using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {

        }

        public Car(string year, string make, string model, string engineNoise, string honkNoise, string isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDrivable { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"EngineNoise: {EngineNoise}");
            Console.WriteLine($"HonkNoise: {HonkNoise}");
            Console.WriteLine($"IsDrivable: {IsDrivable}");
            Console.WriteLine("------------------------------------------");
        }
        


    }
}
