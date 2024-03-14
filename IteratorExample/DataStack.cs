internal class DataStack
{
    public int[] items { get; private set; } = new int[10];
    public int length { get; private set; }

    public DataStack() => length = -1;
    public DataStack(DataStack dataStack) 
    {
        items = dataStack.items;
        length = dataStack.length;
    }

    public void Push(int item) => items[++length] = item;
    public int Pop() => items[length--];

    public static bool operator ==(DataStack left, DataStack right)
    {
        StackIterator it1 = new StackIterator(left),
            it2 = new StackIterator(right);

        while (it1.IsEnd() || it2.IsEnd())
        {
            if (it1.Get() != it2.Get())
                break;
            it1++;
            it2++;
        }

        return !it1.IsEnd() && !it2.IsEnd();
    }

    public static bool operator !=(DataStack left, DataStack right)
    {
        StackIterator it1 = new StackIterator(left),
            it2 = new StackIterator(right);

        while (it1.IsEnd() || it2.IsEnd())
        {
            if (it1.Get() != it2.Get())
                break;
            it1++;
            it2++;
        }

        return !(!it1.IsEnd() && !it2.IsEnd());
    }

}
