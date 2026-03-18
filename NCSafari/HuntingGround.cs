using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal class HuntingGround : SafariEnvironment<IHunt>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is IHunt flyingHunter && animal is IFly flier)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting in the skies above the hunting ground");
                }
                else if (animal is IHunt swimmingHunter && animal is ISwim swimmer)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting in the waters of the hunting ground");
                }
                else if (animal is IHunt hunter)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting on land in the hunting ground");
                }
            }
        }
    }
}
