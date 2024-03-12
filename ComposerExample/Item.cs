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
}