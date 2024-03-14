
namespace CoRExample
{
    abstract class AbsWorker : IWorker
    {
        private IWorker nextWorker;
        public AbsWorker() => nextWorker = null;

        public virtual string Execute(string command)
        {
            if(nextWorker != null)
            {
                return nextWorker.Execute(command); 
            }
            return string.Empty;
        }

        public IWorker SetNextWorker(IWorker worker)
        {
            nextWorker = worker;
            return worker;
        }
    }
}