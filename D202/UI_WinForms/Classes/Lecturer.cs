using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Lecturer
    {
        public Lecturer(string id, string name, string gender, string phone, string email)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Lecturer ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Lecturer Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Lecturer Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Lecturer Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Lecturer Email
        /// </summary>
        public string Email { get; set; }
    }
}
