namespace CompositeExaple
{
    // Client code works with all objects using the interface
    // Component. Thus, it remains independent of specific
    // component classes to work with.
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}