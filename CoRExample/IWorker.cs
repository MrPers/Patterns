
namespace CoRExample
{
    interface IWorker
    {
        IWorker SetNextWorker(IWorker worker);
        string Execute(string command);
    }
}