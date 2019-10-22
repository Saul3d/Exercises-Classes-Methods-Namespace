using System;
using System.Collections.Generic;
using System.Text;

namespace legoMinifigures.Head
{
    class PirateHead : Head
    {
        Sizes _HeadSize = Sizes.Medium;
        private int Eyes = 2;
        private string EyeColor = "brown";
        private int ears = 2;
        private string hearing = "good";
        private bool HasHair = true;
        private string HairColor = "brown";
        private bool HasNose = false;
        private bool HasBuggers = false;
        private bool HasMouth = true;
        private bool HasBadBreath = true;

        public override void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
