abstract class Sender
{
    protected IDataReader reader;
    public Sender(IDataReader reader) => this.reader = reader;
    public void SetDataReader(IDataReader reader) => this.reader = reader;
    public abstract void Send();
}
