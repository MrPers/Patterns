namespace EventExample
{
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += ProcessCompleted_1; // register with an event
            bl.ProcessCompleted += ProcessCompleted_2; // register with an event
            bl.ProcessCompleted -= ProcessCompleted_1; // unsubscribe with an event
            bl.StartProcess();
        }

        // event handler
        public static void ProcessCompleted_1()
        {
            Console.WriteLine("Process Completed 1 !");
        }

        public static void ProcessCompleted_2()
        {
            Console.WriteLine("Process Completed 2 !");
        }
    }
}

