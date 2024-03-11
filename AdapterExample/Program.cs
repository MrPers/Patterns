namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget targetMethod = new AdapterMethod(adaptee);
            Console.WriteLine(targetMethod.GetRequest());

            ITarget targetClass = new AdapterClass();
            Console.WriteLine(targetClass.GetRequest());
        }
    }
}