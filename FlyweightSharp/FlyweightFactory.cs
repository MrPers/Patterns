using System.Collections;

namespace FlyweightSharp
{
    class FlyweightFactory
    {
        private Hashtable flyweights;
        public string GetKey(Shared shared) => shared.company + "-" + shared.position;
        public FlyweightFactory(List<Shared> shareds)
        {
            flyweights = new Hashtable();
            foreach (var shared in shareds)
            {
                flyweights.Add(GetKey(shared), new Flyweight(shared));
            }
        }

        public Flyweight GetFlyweight(Shared shared)
        {
            string key = GetKey(shared);
            if (!flyweights.Contains(key))
            {
                Console.WriteLine($"Create: {key}");
                flyweights.Add(key, new Flyweight(shared));
            }
            else
            {
                Console.WriteLine($"Retrieved: {key}");
            }
            return (Flyweight)flyweights[key];
        }

        public void ListFlyweights()
        {
            int cont = flyweights.Count;
            Console.WriteLine("");
            foreach (Flyweight item in flyweights.Values)
            {
                Console.WriteLine(item.GetData());
            }
        }
    }
}