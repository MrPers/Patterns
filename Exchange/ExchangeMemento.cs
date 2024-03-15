class ExchangeMemento : IMemento
{
    public ExchangeMemento(int dollars, int euro)
    {
        this.dollars = dollars;
        this.euro = euro;
    }

    private int dollars;
    private int euro;

    public int GetDollars()=> dollars;

    public int GetEuro()=> euro;
}
