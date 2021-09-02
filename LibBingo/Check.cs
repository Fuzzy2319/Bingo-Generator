using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBingo
{
    public class Check
    {
        private string name;
        private Category category;
        
        public string Name { get => name; }
        public Category Category { get => category; }

        public Check(string name, Category category)
        {
            this.name = name;
            this.category = category;
        }
    }
}
