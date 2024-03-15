class Exchange
{
    private int dollars;
    private int euro;
    public Exchange(int dollars, int euro)
    {
        this.dollars = dollars;
        this.euro = euro;
    }

    public void GetDollars() => Console.WriteLine("Dollars: "+ dollars);
    public void GetEuro() => Console.WriteLine("Euro: " + dollars);

    public void Sell()
    {
        if (dollars > 0) 
            --dollars;
    }
    public void Buy() => ++euro;

    public ExchangeMemento Save() => new ExchangeMemento(dollars, euro);

    public void Restore(IMemento memento)
    {
        dollars = memento.GetDollars();
        euro = memento.GetEuro();
    }
}
