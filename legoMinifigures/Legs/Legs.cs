using System;
using System.Collections.Generic;
using System.Text;

namespace legoMinifigures.Legs
{
    class Legs : ILegs
    {
        private Sizes _legLenth = Sizes.Large;
        private int NumberOfLegs { get; set; }
        private int NumberOfToes { get; set; }
        private bool OdorousFeet { get; set; }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void KarateKick()
        {
            throw new NotImplementedException();
        }

        public void NinjaDash()
        {
            throw new NotImplementedException();
        }
    }
}
