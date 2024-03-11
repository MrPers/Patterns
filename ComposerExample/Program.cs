namespace ComposerExample
{
    abstract class Item
    {
        protected string itemName;
        protected string ownerName;
        public void SetOwner(string ownerName) => this.ownerName = ownerName;
        public Item(string name) => this.itemName = name;
        public virtual void Add(Item item) { }
        public virtual void Remove(Item item) { }
        public abstract void Display();
    }

    class ClickableItem: Item
    {
        public ClickableItem(string name) : base(name) { }
        public override void Add(Item item) { }
        public override void Remove(Item item) { }
        public override void Display()
        {
            Console.WriteLine(itemName);
        }
    }

    class DropDownItem : Item
    {
        private List<Item> children;
        public DropDownItem(string name) : base(name) 
        {
            children = new List<Item>();
        }
        public override void Add(Item item) 
        {
            sub
        }
        public override void Remove(Item item) { }
        public override void Display()
        {
            Console.WriteLine(itemName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}