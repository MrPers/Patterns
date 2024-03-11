namespace AdapterExample
{
    class AdapterMethod : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterMethod(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}' from Method";
        }
    }
}