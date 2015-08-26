using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_WinForms.Classes
{
    class Course
    {
        public int CourseID { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int Semesters { get; set; }

        public Category CourseCategory { get; set; }

        public Course Prerequisite { get; set; }

        public Lecturer CourseLecturer { get; set; }
    }
}
