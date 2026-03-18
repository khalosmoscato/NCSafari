using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal abstract class Mammal : Animal
    {
        protected Mammal(float weightInKg) : base(weightInKg)
        {
        }
    }
}
