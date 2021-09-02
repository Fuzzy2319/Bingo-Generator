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

        public string Name { get => name; }
        public bool IsActive { get => isActive; set => isActive = value; }
        
        public Category(string name)
        {
            this.name = name;
            this.isActive = false;
        }
    }
}
