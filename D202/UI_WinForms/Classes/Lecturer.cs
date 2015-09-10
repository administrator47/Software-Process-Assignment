using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Lecturer: Table<Lecturer>
    {
        public new static string TableName()
        {
            return "lecture";
        }

        public Lecturer(string id)
            : base(id)
        { }

        protected Lecturer(string id, string name, string gender, string phone, string email)
            : this(id)
        {
            fName = name;
            fGender = gender;
            fPhone = phone;
            fEmail = email;
            loaded = true;
        }

        /// <summary>
        /// Lecturer Name
        /// </summary>
        private string fName;
        public string Name
        {
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

        /// <summary>
        /// Lecturer Gender
        /// </summary>
        private string fGender;
        public string Gender 
        {
            get
            {
                if (!loaded) Refresh();
                return fGender;
            }
            set
            {
                dirty = dirty || fGender != value;
                fGender = value;
            }
        }

        /// <summary>
        /// Lecturer Phone
        /// </summary>
        private string fPhone;
        public string Phone 
        {
            get
            {
                if (!loaded) Refresh();
                return fPhone;
            }
            set
            {
                dirty = dirty || fPhone != value;
                fPhone = value;
            }
        }

        /// <summary>
        /// Lecturer Email
        /// </summary>
        private string fEmail;
        public string Email 
        {
            get
            {
                if (!loaded) Refresh();
                return fEmail;
            }
            set
            {
                dirty = dirty || fEmail != value;
                fEmail = value;
            }
        }

        public override void Refresh()
        {
            object[] sql_params = { ID };
            var dr = ExecuteReader(String.Format("select name, gender, phone, email from {0} where id=@0", TableName()), sql_params);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fRecordedID = ID;
                    fName = dr.GetString(0);
                    fGender = dr.GetString(1);
                    fPhone = dr.GetString(2);
                    fEmail = dr.GetString(3);
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

            object[] sql_params = { ID, Name, Gender, Phone, Email };

            string sql_query;
            if (RecordedID == null)
            {
                sql_query = String.Format("insert {0} (id, name, gender, phone, email) values ((@0, @1, @2, @3, @4))", TableName());
            }
            else
            {
                sql_query = String.Format("update {0} set name=@1, gender=@2, phone=@3, email=@4 where id=@0", TableName());
            }
            ExecuteNonQuery(sql_query, sql_params);
            fRecordedID = ID;
            loaded = true;
            dirty = false;
        }
    }
}
