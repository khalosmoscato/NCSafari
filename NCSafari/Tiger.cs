using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Tiger : PantheraBigCat, IHunt
    {
        public Tiger(float weightInKg) : base(weightInKg)
        {
        }

        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + " is hunting on land!");
        }
    }
}
