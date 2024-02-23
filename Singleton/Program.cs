namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check the standard implementation.
            // You can create multiple instances of the class
            // which will conflict with each other.
            //var text1 = new FileWorker();
            //var text2 = new FileWorker();

            //text1.WriteText("Hello, World!");
            //text2.WriteText("Hi, Bro!");

            //text1.Save();
            //text2.Save();

            var singleton1 = FileWorkerSingleton.Instance;
            var singleton2 = FileWorkerSingleton.Instance;

            // var singleton = new FileWorkerSingleton(); // You can't create a new instance of a singleton!

            singleton1.WriteText("Hello, World!");
            singleton2.WriteText("Hi, Bro!");

            singleton1.Save();
            singleton2.Save();
        }
    }
}
