namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Jack Daniels";
            p1.company = new Company(666);

            Person p2 = p1.ShallowCopy();
            Person p3 = p1.DeepCopy();

            Console.WriteLine("   p1 : ");
            DisplayValues(p1);
            Console.WriteLine("   p2 :");
            DisplayValues(p2);
            Console.WriteLine("   p3 :");
            DisplayValues(p3);

            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.company.Name = 7878;

            Console.WriteLine("   p1 : ");
            DisplayValues(p1);
            Console.WriteLine("   p2  (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3  (everything was kept the same):");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
          p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      CompanyName: {0:d}", p.company.Name);
        }
    }
}