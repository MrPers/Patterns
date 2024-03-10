namespace FlyweightSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory(new List<Shared>()
            {
                new Shared("Microsoft", "Manager"),
                new Shared("Google", "Web"),
                new Shared("Google", "Manager"),
                new Shared("Apple", "Android")
            });
            factory.ListFlyweights();

            AddSpecialistDataBase(
                factory,
                "Google",
                "Web",
                "Sahara",
                "AM-17");

            AddSpecialistDataBase(
                factory,
                "Apple",
                "Web",
                "Jurong",
                "AM-32");

            factory.ListFlyweights();
        }

        static void AddSpecialistDataBase(FlyweightFactory ff, string company, string position, string name, string passport)
        {
            Console.WriteLine();
            Flyweight flyweight = ff.GetFlyweight(new Shared(company, position));
            flyweight.Process(new Unique(name, passport));
        }
    }
}