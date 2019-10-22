using System;
using System.Collections.Generic;
using System.Text;

namespace legoMinifigures
{
    class Minifigure
    {
        public string Hair { get; set; }
        public string hat { get; set; }
        public string torso { get; set; }
        public string legs { get; set; }
        public string accessories { get; set; }

        public void Change(string cloths)
        {
            Console.WriteLine($"Change into the {cloths}");
        }

        public void Kick()
        {
            Console.WriteLine("SideKick!");
        }

        public void KarateChop()
        {
            Console.WriteLine("Karate Chop!!");
        }

        public void jump()
        {
            Console.WriteLine("Karate Leap");
        }

        public void doubleJump()
        {
            Console.WriteLine("Walking on Cloud!");
        }

        public void LookBack()
        {
            Console.WriteLine("Look behind you!");
        }

        public void run()
        {
            Console.WriteLine("Ninja dash!");
        }
    }
}
