class Controller : IMediator
{
    private Designer designer;
    private Director director;
    public Controller(Designer designer, Director director)
    {
        this.designer = designer;
        this.director = director;
        designer.SetMediator(this);
        director.SetMediator(this);
    }
    public void Notify(Employee employee, string msg)
    {
        if (employee is Director dir)
        {
            if (msg == "")
                designer.SetWork(false);
            else
                designer.SetWork(true);
        }
        if (employee is Designer des && msg == "designer designs...")
                director.GiveCommand("");
    }
}