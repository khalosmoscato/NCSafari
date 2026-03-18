using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Tiger : PantheraBigCat, IMove
    {
        public Tiger(float weightInKg) : base(weightInKg)
        {
        }

        public void Move()
        {
            Console.WriteLine(this.GetType().Name + " is moving!");
        }
    }
}
