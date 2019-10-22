using System;
using System.Collections.Generic;
using System.Text;

namespace legoMinifigures.Head
{
    abstract class Head
    {
        private string _headSize;
        public int Eyes { get; set; }
        public string EyeColor { get; set; }
        public int Ears { get; set; }
        public string Hearing { get; set; }
        public bool HasHair { get; set; }
        public string HairColor { get; set; }
        public bool HasNose { get; set; }
        public bool HasBuggers { get; set; }
        public bool HasMouth { get; set; }
        public bool HasBadBreath { get; set; }

        public abstract void Talk();
    }
}
