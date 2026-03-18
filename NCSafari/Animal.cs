using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    public abstract class Animal
    {
        public float WeightInKg { get; set; }
        public Animal(float weightInKg)
        {
           this.WeightInKg = weightInKg;
        }

        public abstract void MakeSound();

    }
}
