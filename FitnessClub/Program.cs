using FitnessClub.Domain;
using FitnessClub.Factories;

class Program
{
    static void Main()
    {
        Console.WriteLine("> Enter the membership type you would like to create: ");
        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym + Pool");
        Console.WriteLine("> T - Personal Training");

        string membershipType = Console.ReadLine().ToLower();

        MembershipFactory factory = membershipType switch
        {
            "g" => new GymMembershipFactory(100, "Basic membership"),
            "p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
            "t" => new GymPersonalTrainingMembershipFactory(400, "Best for professionals"),
            _ => null
        };

        IMembership membership = factory.GetMembership();

        Console.WriteLine(
            $"\tName:\t\t{membership.Name}\n" +
            $"\tDescription:\t{membership.Description}\n" +
            $"\tPrice:\t\t{membership.GetPrice()}\n" +
            $"\tFactoryCLaseName:\t\t{factory.ToString().Split('.')[2]}"
            );

        Console.ReadLine();
    }
}