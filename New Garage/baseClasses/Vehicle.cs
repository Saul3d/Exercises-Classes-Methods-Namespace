using System;
using System.Collections.Generic;
using System.Text;

namespace New_Garage
{
    class Vehicle
    {
        public int _fueling { get; set; }
        public string _color { get; set; }
        public string _passengerOccupancy { get; set; }

        public void Refueling()
        {
            Console.WriteLine("All filled up");
        }
    }
}
