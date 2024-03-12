namespace ComposerExample
{
    class ClickableItem : Item
    {
        public ClickableItem(string name) : base(name) { }
        public override void Add(Item item) { }
        public override void Remove(Item item) { }
        public override void Display()
        {
            Console.WriteLine(itemName);
        }
    }
}