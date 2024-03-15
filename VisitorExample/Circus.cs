

class Circus : IPlace
{
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
