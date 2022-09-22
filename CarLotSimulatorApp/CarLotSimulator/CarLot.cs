using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public CarLot()
        {
            CarLot.CarCount++;
        }

        // Field
        public static int CarCount;
        // Property
        public List<Car> CarList { get; set; }
        // Method
        public static void PrintCars()
        {
            throw new NotImplementedException();
        }
    }
}
