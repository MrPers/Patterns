namespace CoRExample
{
    class Program
    {
        public static void GiveCommand(IWorker worker, string command)
        {
            string str = worker.Execute(command);
            if (str == "")
                Console.WriteLine(command + " - no one can do");
            else
                Console.WriteLine(str);
        }

        static void Main()
        {
            Designer designer = new Designer();
            Carpenters carpenters = new Carpenters();
            FinishingWorker finishingWorker = new FinishingWorker();

            designer.SetNextWorker(carpenters).SetNextWorker(finishingWorker);

            GiveCommand(designer, "designed house");
            GiveCommand(designer, "class brick");
            GiveCommand(designer, "wallpapering");
            GiveCommand(designer, "carry out wiring");
        }
    }
}