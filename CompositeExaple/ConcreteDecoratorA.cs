namespace CompositeExaple
{
    // Concrete Decorators call the wrapped object and change its result
    // in some way.
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }
        // Decorators can call the parent implementation of the operation instead
        // in order to call the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}