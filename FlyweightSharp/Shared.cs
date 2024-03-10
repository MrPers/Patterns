namespace FlyweightSharp
{
    struct Shared
    {
        public string company { get; private set; }
        public string position { get; private set; }

        public Shared(string company, string position)
        {
            this.company = company;
            this.position = position;
        }
    }
}