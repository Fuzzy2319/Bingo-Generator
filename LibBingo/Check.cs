namespace LibBingo
{
    public class Check : CheckMin
    {
        private Category category;
        
        public Category Category { get => category; }

        public Check(string name, Category category) : base(name)
        {
            this.category = category;
        }
    }
}
