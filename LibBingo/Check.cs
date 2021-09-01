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
        private string category;
        
        public string Name { get => name; }
        public string Category { get => category; set => category = value; }

        public Check(string name, string category)
        {
            this.name = name;
            this.category = category;
        }
    }
}
