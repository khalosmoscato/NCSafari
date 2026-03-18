using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Penguin : Bird, IMove
    {
        public Penguin(float weightInKg) : base(weightInKg)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " noot noot!");
        }

        public void Move()
        {
            Console.WriteLine(this.GetType().Name + " is moving!");
        }
    }
}
