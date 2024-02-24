using Attacker.Strategies;

namespace Attacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new("Squidward");

            hero.Attack();

            hero.SetWeapon(new Broom());

            hero.Attack();

            Console.WriteLine("_________________\n");

            hero.SetWeapon(new Plunger());

            hero.Attack();
        }
    }
}
