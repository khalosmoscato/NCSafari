using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class Sky : SafariEnvironment<IFly>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is IFly flier)
                {
                    flier.Fly();
                }
            }
        }
    }
}
