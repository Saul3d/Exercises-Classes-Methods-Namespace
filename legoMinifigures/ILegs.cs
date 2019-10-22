using System;
using System.Collections.Generic;
using System.Text;

namespace legoMinifigures
{
    interface ILegs
    {
        void Jump();
        void KarateKick();
        void NinjaDash();
    }

    interface DoubleJump : ILegs
    {
        void NinjaJumb();
    }
}