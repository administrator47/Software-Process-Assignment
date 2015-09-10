using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Lecturer: Table<Lecturer>
    {
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
                fEmail = value;
            }
        }

        public override void Refresh()
        {
            object[] sql_params = { ID };
            var dr = ExecuteReader("select name, gender, phone, email from lecture where id=@0", sql_params);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fName = dr.GetString(0);
                    fGender = dr.GetString(1);
                    fPhone = dr.GetString(2);
                    fEmail = dr.GetString(3);
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

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
