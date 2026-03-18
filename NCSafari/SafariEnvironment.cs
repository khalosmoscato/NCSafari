using System;
using System.Collections.Generic;
using System.Text;

namespace NCSafari
{
    internal abstract class SafariEnvironment<IEnviroment>
    {
        protected List<Animal> animalsInEnvironment = new List<Animal>();

        public abstract void CheckAnimalsInEnvironment();

        public void AddAnimalInEnvironment(Animal animal)
        {
            this.animalsInEnvironment.Add(animal);
        }
    }
}
