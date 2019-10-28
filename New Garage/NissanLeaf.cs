using System;
using System.Collections.Generic;
using System.Text;

namespace New_Garage
{
    class NissanLeaf: Car
    {
        public string Make = "Nissan";
        public string Model = "Leaf";
        public int _Year { get; set; }

        public NissanLeaf(int year)
        {
            this._Year = year;
        }
    }
}
