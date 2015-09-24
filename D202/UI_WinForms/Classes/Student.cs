 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    public class Student
    {
        public Student (string id, string name)
        {
            ID = id;
            Name = name;
        }

        public Student()
        {

        }

        public string ID { get; set; }
        public string Name { get; set; }
    }
}
