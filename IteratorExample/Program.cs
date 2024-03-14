using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DataStack stack1 = new DataStack();
        for (int i = 1; i < 5; i++)
            stack1.Push(i);

        DataStack stack2 = new DataStack(stack1);

        Console.WriteLine(stack2 == stack1);

        stack2.Push(10);

        Console.WriteLine(stack2 == stack1);

    }
}
