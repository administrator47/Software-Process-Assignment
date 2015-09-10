using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Category : Table<Category>
    {
        public Category(string id)
            : base(id)
        { }

        protected Category(string id, string name, string description) 
            : this (id)
        {
            fName = name;
            fDescription = description;
            loaded = true;
        }

        public static Category[] LoadIDs()
        {
            var result = new List<Category>();

            var dr = ExecuteReader("select id from category", null);
            try
            {
                while (dr.Read())
                {
                    var id = dr.GetString(0);
                    result.Add(Category.FromID(id));
                }
            }
            finally
            {
                dr.Close();
            }

            return result.ToArray<Category>();
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

        public override void Refresh()
        {
            object[] sql_params = { ID };
            var dr = ExecuteReader("select name, description from category where id=@0", sql_params);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fName = dr.GetString(0);
                    fDescription = dr.GetString(1);
                    loaded = true;
                }
                else
                {
                    throw new System.Data.RowNotInTableException("No row with id=" + ID);
                }
            }
            finally
            {
                dr.Close();
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
