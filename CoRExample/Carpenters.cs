
namespace CoRExample
{
    class Carpenters : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "class brick")
                return "the carpenter followed the command:" + command;
            else
                return base.Execute(command);
        }
    }
}