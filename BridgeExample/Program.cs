class Program 
{
    static void Main(string[] args)
    {
        Sender sender = new EmailSender(new DataBaseRader());
        sender.Send();

        sender.SetDataReader(new FileReader());
        sender.Send();

        sender = new PhoneSender(new DataBaseRader());
        sender.Send();
    }
}
