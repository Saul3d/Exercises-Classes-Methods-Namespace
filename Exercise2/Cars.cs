using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Type { get; set; }

        public void start()
        {
            Console.WriteLine("Vrooooom, the car has started");
        }
        public void stop()
        {
            Console.WriteLine("Skreeeeeeeee, the car has stopped!");
        }
    }

}
