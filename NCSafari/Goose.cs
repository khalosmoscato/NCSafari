using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Goose : Bird, IFly, ISwim
    {
        public Goose(float weightInKg) : base(weightInKg)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " honks!");
        }

        public void Swim()
        {
            Console.WriteLine(this.GetType().Name + " is swimming!");
        }

        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying!");
        }
    }
}
