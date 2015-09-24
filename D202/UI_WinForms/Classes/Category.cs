using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Category : Table<Category>
    {
        public new static string TableName()
        {
            return "category";
        }

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

        private string fName;
        public string Name {
            get
            {
                if (!loaded) Refresh();
                return fName;
            }
            set
            {
                dirty = dirty || fName != value;
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
                dirty = dirty || fDescription != value;
                fDescription = value;
            }
        }

        public override void Refresh()
        {
            var DB_ID = EffectiveID;
            object[] sql_params = { DB_ID };
            var dr = ExecuteReader(String.Format("select name, description from {0} where id=@0", TableName()), sql_params);
            try
            {
                if (dr.HasRows)
                {
                    SetRecordedID(DB_ID);
                    SetID(DB_ID);

                    dr.Read();
                    fName = dr.GetString(0);
                    fDescription = dr.GetString(1);
                    loaded = true;
                    dirty = false;
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

        public override void Update()
        {
            if (!dirty) return;
            base.Update();

            object[] sql_params = { ID, Name, Description };

            string sql_query;
            if (RecordedID == null)
            {
                sql_query = String.Format("insert {0} (id, name, description) values ((@0, @1, @2))", TableName());
            }
            else
            {
                sql_query = String.Format("update {0} set name=@1, description=@2 where id=@0", TableName());
            }
            ExecuteNonQuery(sql_query, sql_params);
            SetRecordedID(ID);
            loaded = true;
            dirty = false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
