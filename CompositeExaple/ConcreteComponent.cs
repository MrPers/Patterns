namespace CompositeExaple
{
    // Concrete Components provide implementations of default behavior.
    // There may be several variations of these classes.
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}