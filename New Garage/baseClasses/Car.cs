using System;
using System.Collections.Generic;
using System.Text;
using Console = System.Console;

namespace New_Garage
{
    class Car: Vehicle
    {
        public void Braking()
        {
            Console.WriteLine("braking");
        }

        public void Driving()
        {
            Console.WriteLine("Driving");
        }
    }
}
