namespace ComposerExample
{
    class DropDownItem : Item
    {
        private List<Item> children;
        public DropDownItem(string name) : base(name) 
        {
            children = new List<Item>();
        }
        public override void Add(Item item) 
        {
            item.SetOwner(itemName);
            children.Add(item);
        }
        public override void Remove(Item item) => children.Remove(item);
        public override void Display()
        {
            foreach (var item in children)
            {
                if (ownerName != null)
                    Console.WriteLine(ownerName + itemName);
                item.Display();
            }
        }
    }
}