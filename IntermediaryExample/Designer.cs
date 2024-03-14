

class Designer : Employee
{
    private bool isWorking;
    public Designer(IMediator med = null) : base(med) { }

    public void ExecuteWork()
    {
        Console.WriteLine("<-designer at work");
        mediator.Notify(this, "designer designs...");
    }

    public void SetWork(bool state) 
    {
        isWorking = state;

        if (state)
            Console.WriteLine("<-the designer is relieved of work");
        else
            Console.WriteLine("<-designer is busy");
    }
}
