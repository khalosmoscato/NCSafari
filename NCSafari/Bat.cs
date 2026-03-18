using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Bat : Mammal, IHunt, IFly
    {
        public Bat(float weightInKg) : base(weightInKg)
        {
        }

        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting in the air!");
        }

        public void Fly()
        {
            Console.WriteLine(this.GetType().Name + " is flying!");
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
