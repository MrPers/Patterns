namespace AdapterExample
{
    class AdapterClass  : Adaptee, ITarget
    {
        public string GetRequest()
        {
            return $"This is '{base.GetSpecificRequest()}' from Class";
        }
    }
}