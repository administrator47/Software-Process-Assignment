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

        private string fID;
        public string ID
        {
            get 
            { 
                return fID;
            }
        }

        private string fName;
        public string Name {
            get
            {
                if (!loaded) Refresh();
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        private string fDescription;

        public string Description
        {
            get
            {
                if (!loaded) Refresh();
                return fDescription;
            }
            set
            {
                fDescription = value;
            }
        }

        protected Category(string id)
        {
            categories[id] = this;
            fID = id;
            loaded = false;
        }

        protected Category(string id, string name, string description)
        {
            categories[id] = this;
            fID = id;
            fName = name;
            fDescription = description;
            loaded = true;
        }

        public void Refresh()
        {
            switch (ID)
            {
                case "A":
                    fName = "Category A";
                    fDescription = "Description 1 Kia ora.. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire.";
                    break;
                case "B":
                    fName = "Category B";
                    fDescription = "Description 2 Kia ora.. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire.";
                    break;
                case "C":
                    fName = "Category C";
                    fDescription = "Description 3 Kia ora.. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire.";
                    break;
                case "D":
                    fName = "Category D";
                    fDescription = "Description 4 Kia ora.. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire.";
                    break;
                default:
                    break;
            }
            loaded = true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
