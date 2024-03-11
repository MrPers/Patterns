class EmailSender : Sender
{
    public EmailSender(IDataReader reader): base(reader) { }

    public override void Send()
    {
        Console.Write("Send using Email ");
        reader.Read();
    }
}
