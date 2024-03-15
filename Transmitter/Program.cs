class Program
{
    static void Main(string[] args)
    {
        Transmitter analog = new AnalogTransmitter();
        analog.ProcessStart();

        Console.WriteLine();

        Transmitter digit = new DigitTransmitter();
        digit.ProcessStart();
    }
}
