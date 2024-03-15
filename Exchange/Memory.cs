class Memory
{
    private Stack<IMemento> history;
    Exchange exchange;
    public Memory(Exchange exchange)
    {
        this.exchange = exchange;
        history = new Stack<IMemento>();
    }
    public void Backup() => history.Push(exchange.Save());
    public void Undo()
    {
        if (history.Count == 0) return;
        exchange.Restore(history.Pop());
    }
}