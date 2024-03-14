class Director : Employee
{
    private string text;
    public Director(IMediator mediator = null): base(mediator) { }

    public void GiveCommand(string txt) 
    {
        text = txt;
        if (text == "")
            Console.WriteLine("->the director knows that the designer is already working");
        else
            Console.WriteLine("->the director gave the command: " + text);
        mediator.Notify(this, text);
    }
}
