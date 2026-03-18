using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal abstract class PantheraBigCat : Mammal
    {
        protected PantheraBigCat(float weightInKg) : base(weightInKg)
        {
        }

        public sealed override void MakeSound() // `sealed` prevents any further overriding in subclasses
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}
