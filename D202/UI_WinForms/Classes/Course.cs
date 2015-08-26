using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_WinForms.Classes
{
    class Course
    {
        public Course(int id, string name, Category category, Course prerequisite, Lecturer lecturer, bool compulsory)
        {
            ID = id;
            Name = name;
            CourseCategory = category;
            Prerequisite = prerequisite;
            CourseLecturer = lecturer;
            Compulsory = compulsory;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public Category CourseCategory { get; set; }

        public Course Prerequisite { get; set; }

        public Lecturer CourseLecturer { get; set; }

        public bool Compulsory { get; set; }
    }
}
