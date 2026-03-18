namespace NCSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger fluffy = new Tiger(70.5f);
            Penguin penny = new Penguin(21);

            fluffy.Hunt();
            penny.Hunt();
            penny.Swim();

            fluffy.MakeSound();
            penny.MakeSound();
        }
    }
}
