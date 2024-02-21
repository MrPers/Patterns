namespace PrototypeExample
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public Company company;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.company = new Company(company.Name);
            clone.Name = String.Copy(Name);
            return clone;
        }

    }
}
