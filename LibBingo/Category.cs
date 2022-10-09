namespace LibBingo
{
    public class Category
    {
        private string name;
        private bool isActive;
        private Category? parent;

        public string Name { get => name; }
        public bool IsActive {
            get => parent == null ? isActive : isActive && parent.IsActive;
            set => isActive = value;
        }
        public Category? Parent{ get => parent; }

        internal void SetParent(Category? category = null)
        {
            parent = category;
        }

        public Category(string name)
        {
            this.name = name;
            this.isActive = false;
            this.parent = null;
        }
    }
}
