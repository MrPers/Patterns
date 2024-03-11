class PhoneSender : Sender
{
    public PhoneSender(IDataReader reader) : base(reader) { }

    public override void Send()
    {
        Console.Write("Send using Phone ");
        reader.Read();
    }
}