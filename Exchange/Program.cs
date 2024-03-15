class Program
{
    static void Main(string[] args)
    {
        Exchange exchange = new Exchange(10, 10);
        Memory memory=new Memory(exchange);
        exchange.GetDollars();
        exchange.GetEuro();

        Console.WriteLine("--Sale dollars, purchase euro");
        exchange.Sell();
        exchange.Buy();

        exchange.GetDollars();
        exchange.GetEuro();

        Console.WriteLine("--Save state");
        memory.Backup();

        Console.WriteLine("--Sale dollars, purchase euro");
        exchange.Sell();
        exchange.Buy();

        exchange.GetDollars();
        exchange.GetEuro();

        Console.WriteLine("--Restore state");
        memory.Undo();

        exchange.GetDollars();
        exchange.GetEuro();

    }
}