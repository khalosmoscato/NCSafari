using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal abstract class Bird : Animal
    {
        protected Bird(float weightInKg) : base(weightInKg)
        {
        }
    }
}
