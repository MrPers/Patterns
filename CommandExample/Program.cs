namespace CommandExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            invoker.SetOnFinish(new ComplexCommand(new Receiver(), "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}