class Program
{
    static void Main(string[] args)
    {
        Designer designer = new Designer();
        Director director = new Director();

        Controller controller = new Controller(designer, director);

        director.GiveCommand("designs");

        designer.ExecuteWork();

    }
}
