namespace FlyweightSharp
{
    struct Unique
    {
        public string name {  get; private set; }  
        public string passport {  get; private set; }

        public Unique(string company, string position)
        {
            this.name = company;
            this.passport = position;
        }
    }
}