using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
