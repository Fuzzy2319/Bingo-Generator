using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBingo
{
    public class Category
    {
        private string name;
        private bool isActive;
        #nullable enable
        private Category? parent;
        #nullable disable

        public string Name { get => name; }
        public bool IsActive {
            get => parent == null ? isActive : isActive && parent.IsActive;
            set => isActive = value;
        }

        #nullable enable
        public Category? Parent{ get => parent; }

        internal void SetParent(Category category)
        {
            parent = category;
        }

        internal void SetParent()
        {
            parent = null;
        }
        #nullable disable

        public Category(string name)
        {
            this.name = name;
            this.isActive = false;
            this.parent = null;
        }
    }
}
