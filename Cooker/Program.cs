using Cooker;

//IChief chief = new Chief();
IChief chief = new ChiefProxy(new Chief());

while(true)
{
    Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n");

    IEnumerable<Order> orders = chief.GetOrders();

    foreach(Order order in orders)
    {
        string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

        Console.WriteLine($"{order.Name}\t\t{status}");
    }

    Thread.Sleep(1000);

    Console.Clear();
}