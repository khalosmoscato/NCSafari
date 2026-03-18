using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float weightInKg) : base(weightInKg)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " squacks!");
        }

        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting in the water!");
        }
        
        public void Swim()
        {
            Console.WriteLine(this.GetType().Name + " is swimming!");
        }
    }
}
