using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is ISwim swimmer)
                {
                    swimmer.Swim();
                }
            }
        }
    }
}
