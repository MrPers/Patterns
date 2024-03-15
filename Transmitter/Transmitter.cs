

abstract class Transmitter
{
    protected virtual void Transmission() => Console.WriteLine("record fragment adverb");
    protected virtual void VoiceRecord() => Console.WriteLine("recording signals via radio ditch");
    protected virtual void Simpling() { }
    protected virtual void Digitization() { }
    protected virtual void Modulation() { }

    public void ProcessStart()
    {
        VoiceRecord();
        Simpling();
        Digitization();
        Modulation();
        Transmission();
    }
}