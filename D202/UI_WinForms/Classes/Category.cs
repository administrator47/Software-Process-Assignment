using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Category
    {
        protected static Dictionary<string, Category> categories = new Dictionary<string, Category>(10);

        public static Category FromID(string id)
        {
            try
            {
                return categories[id];
            }
            catch (KeyNotFoundException)
            {
                return new Category(id);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        protected bool loaded = false;

        public string ID { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        protected Category(string id)
        {
            ID = id;
            categories[id] = this;
            loaded = false;
        }

        public Category(string id, string name, string? description)
        {
            ID = id;
            categories[id] = this;
            Name = name;
            Description = description;
            loaded = true;
        }

        public void Refresh()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
