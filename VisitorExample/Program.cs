class Program
{
    static void Main(string[] args)
    {
        List<IPlace> places = new List<IPlace>()
        {
            new Zoo(), new Cinema(), new Circus()
        };

        foreach (var place in places)
        {
            HolidayMaker visitor = new HolidayMaker();
            place.Accept(visitor);
            Console.WriteLine(visitor.value);
        }
    }
}
