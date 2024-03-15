

class HolidayMaker : IVisitor
{
    public string value;
    public void Visit(Zoo zoo) => value = "Zoo";
    public void Visit(Cinema cinema) => value = "Lord of the Rings";
    public void Visit(Circus circus) => value = "Clown in the circus";
}
