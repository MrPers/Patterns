
namespace CoRExample
{
    class Designer : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "designed house")
                return "the designer executed the command:" + command;
            else
                return base.Execute(command);
        }
    }
}