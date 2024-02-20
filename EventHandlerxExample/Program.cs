class Program
{
    public static void Main()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += ProcessCompleted_1; // register with an event
        bl.ProcessCompleted += ProcessCompleted_2; // register with an event
        bl.ProcessCompleted -= ProcessCompleted_1; // register with an event
        bl.StartProcess();
    }

    // event handler
    public static void ProcessCompleted_1(object sender, EventArgs e)
    {
        Console.WriteLine("Process Completed 1 !");
    }

    public static void ProcessCompleted_2(object sender, EventArgs e)
    {
        Console.WriteLine("Process Completed 2 !");
    }
}

public class ProcessBusinessLogic
{
    // declaring an event using built-in EventHandler
    public event EventHandler ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted(EventArgs.Empty); //No event data
    }

    protected virtual void OnProcessCompleted(EventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }
}