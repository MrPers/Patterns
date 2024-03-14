
namespace CoRExample
{
    class FinishingWorker : AbsWorker
    {
        public override string Execute(string command)
        {
            if (command == "wallpapering")
                return "interior decoration worker spiritual team:" + command;
            else
                return base.Execute(command);
        }
    }
}