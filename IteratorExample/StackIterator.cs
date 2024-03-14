class StackIterator
{
    private DataStack stack;
    private int index;

    public StackIterator(DataStack stack)
    {
        this.stack = stack;
        index = 0;
    }

    public static StackIterator operator ++(StackIterator stack)
    {
        stack.index++;
        return stack;
    }

    public int Get()
    {
        if (index < stack.length)
            return stack.items[index];
        return 0;
    }
    public bool IsEnd() => index != stack.length + 1;
}
