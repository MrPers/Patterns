namespace ComposerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Item file = new DropDownItem("file->");
            Item create = new DropDownItem("create->");
            Item open = new DropDownItem("open->");
            Item exit = new DropDownItem("output->");

            file.Add(create);
            file.Add(open);
            file.Add(exit);

            Item project = new ClickableItem("project..");
            Item repository = new ClickableItem("repository..");

            create.Add(project);
            create.Add(repository);

            Item solution = new ClickableItem("solutions..");
            Item folder = new ClickableItem("folder..");

            create.Add(solution);
            create.Add(folder);

            file.Display();
            Console.WriteLine();

            file.Remove(create);
            file.Display();
        }
    }
}