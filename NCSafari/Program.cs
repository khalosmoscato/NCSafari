using System.Globalization;

namespace NCSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Animal> animalsToSee = new List<Animal>
            //{
            //    new Tiger(70),
            //    new Goose(5.2f),
            //    new Bat(0.9f),
            //    new Goose(4),
            //    new Tiger(90),
            //    new Penguin(15.8f)
            //};
            //animalsToSee.Sort(new CompareWeight(true));

            //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.WeightInKg}kg"));

            Tiger pumpkin = new Tiger(100.4f);
            WeightFormatter pumpkinWeightFormatter = new WeightFormatter(pumpkin);
            // here I declare the CultureInfo, this will be the `formatProvider` arg for `ToString` method of `WeightFormatter`
            CultureInfo uk = new CultureInfo("en-GB");
            CultureInfo es = new CultureInfo("es-ES");
            CultureInfo de = new CultureInfo("de-De");
            // with kg, note there is a difference with the use of dots or commas
            Console.WriteLine(pumpkinWeightFormatter.ToString("kg", uk));
            Console.WriteLine(pumpkinWeightFormatter.ToString("kg", es));
            Console.WriteLine(pumpkinWeightFormatter.ToString("kg", de));
            // with oz, note the differences
            Console.WriteLine(pumpkinWeightFormatter.ToString("oz", uk));
            Console.WriteLine(pumpkinWeightFormatter.ToString("oz", es));
            Console.WriteLine(pumpkinWeightFormatter.ToString("oz", de));
            //consider how you will pass the culture and measurements 

            //Tiger fluffy = new Tiger(80);
            //Penguin penny = new Penguin(20.4f);
            //Goose jeff = new Goose(3);
            //Bat betty = new Bat(0.7f);

            //Sky sky = new Sky();
            //sky.AddAnimalInEnvironment(betty);
            //sky.AddAnimalInEnvironment(jeff);
            //Water water = new Water();
            //water.AddAnimalInEnvironment(penny);
            //water.AddAnimalInEnvironment(jeff);
            //HuntingGround huntingGround = new HuntingGround();
            //huntingGround.AddAnimalInEnvironment(betty);
            //huntingGround.AddAnimalInEnvironment(fluffy);
            //huntingGround.AddAnimalInEnvironment(penny);


            //sky.CheckAnimalsInEnvironment();
            //water.CheckAnimalsInEnvironment();
            //huntingGround.CheckAnimalsInEnvironment();

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
