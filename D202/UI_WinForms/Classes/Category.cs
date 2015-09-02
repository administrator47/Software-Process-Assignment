using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Category
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Category(string id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
