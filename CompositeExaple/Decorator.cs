namespace CompositeExaple
{
    // The Decorator base class follows the same interface as the others
    // Components. The main purpose of this class is to define a wrapper interface for
    // all specific decorators. The default wrapper code implementation can
    // include a field for storing the wrapped component and its means
    // initialization.
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        // The decorator delegates all the work to the wrapped component.
        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}