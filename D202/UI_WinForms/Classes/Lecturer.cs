using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Lecturer
    {
        protected static Dictionary<string, Lecturer> lecturers = new Dictionary<string, Lecturer>(10);

        public static Lecturer FromID(string id)
        {
            try
            {
                return lecturers[id];
            }
            catch (KeyNotFoundException)
            {
                return new Lecturer(id);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        protected bool loaded = false;

        protected Lecturer(string id)
        {
            lecturers[id] = this;
            fID = id;
            loaded = false;
        }

        protected Lecturer(string id, string name, string gender, string phone, string email)
        {
            lecturers[id] = this;
            fID = id;
            fName = name;
            fGender = gender;
            fPhone = phone;
            fEmail = email;
            loaded = true;
        }

        /// <summary>
        /// Lecturer ID
        /// </summary>

        private string fID;
        public string ID
        {
            get
            {
                return fID;
            }
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

        public void Refresh()
        {
            switch (ID)
            {
                case "L1":
                    fName = "Lecturer 1";
                    fGender = "Male";
                    fPhone = "5555555";
                    fEmail = "l1@example.com";
                    break;
                case "L2":
                    fName = "Lecturer 2";
                    fGender = "Female";
                    fPhone = "5555565";
                    fEmail = "l2@example.com";
                    break;
                default:
                    break;
            }
            loaded = true;
        }

    }
}
