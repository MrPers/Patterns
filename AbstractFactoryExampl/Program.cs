namespace AbstractFactoryExampl
{
    // Abstract Factory ensures that all products it
    // creates have the same variation and are therefore compatible.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory1:");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Factory2:");
            ClientMethod(new ConcreteFactory2());
        }

        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
