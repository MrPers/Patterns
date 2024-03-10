namespace FlyweightSharp
{
    class Flyweight
    {
        private Shared shared;

        public Flyweight(Shared shared) => this.shared = shared;

        public void Process(Unique unique) => Console.WriteLine($"general data: {shared.company}, {shared.position} unique data: {unique.name}, {unique.passport}");

        public string GetData() => shared.company + "-" + shared.position;
    }
}