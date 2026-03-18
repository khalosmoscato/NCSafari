namespace NCSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            Sky sky = new Sky();
            sky.AddAnimalInEnvironment(betty);
            sky.AddAnimalInEnvironment(jeff);
            Water water = new Water();
            water.AddAnimalInEnvironment(penny);
            water.AddAnimalInEnvironment(jeff);
            HuntingGround huntingGround = new HuntingGround();
            huntingGround.AddAnimalInEnvironment(betty);
            huntingGround.AddAnimalInEnvironment(fluffy);
            huntingGround.AddAnimalInEnvironment(penny);


            sky.CheckAnimalsInEnvironment();
            water.CheckAnimalsInEnvironment();
            huntingGround.CheckAnimalsInEnvironment();

            //List<Animal> animals = new List<Animal>()
            //{ fluffy, penny, jeff, betty };

            //foreach (Animal animal in animals)
            //{
            //    if (animal is IFly flyingAnimal)
            //    {
            //        flyingAnimal.Fly();
            //    }
            //    if (animal is IHunt huntingAnimal)
            //    {
            //        huntingAnimal.Hunt();
            //    }
            //    if (animal is ISwim swimmingAnimal)
            //    {
            //        swimmingAnimal.Swim();
            //    }
            // }
        }
    }
}
