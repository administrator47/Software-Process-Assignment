using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_WinForms.Classes
{
    class Course
    {
        protected static Dictionary<string, Course> courses = new Dictionary<string, Course>(10);

        public static Course FromID(string id)
        {
            try
            {
                return courses[id];
            }
            catch (KeyNotFoundException)
            {
                return new Course(id);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        protected bool loaded = false;

        protected Course(string id)
        {
            courses[id] = this;
            fID = id;
            this.loaded = false;
        }

        //protected Course(string id, string name, Category category, Course prerequisite, Lecturer lecturer, bool compulsory, string description)
        //{
        //    courses[id] = this;
        //    fID = id;
        //    fName = name;
        //    fCourseCategory = category;
        //    fPrerequisite = prerequisite;
        //    fCourseLecturer = lecturer;
        //    fCompulsory = compulsory;
        //    fDescription = description;
        //    this.loaded = true;
        //}

        public Course(string[] returnedValue)
        {
            courses[returnedValue[0]] = this;
            fID = returnedValue[0];
            fName = returnedValue[1];
            fCourseLecturer = returnedValue[2];
            fCourseCategory = returnedValue[3];
            fDescription = returnedValue[4];

            fPrerequisite = returnedValue[5];

            if (returnedValue[6] == "Y")
            {
                fCompulsory = true;
            }
            else
            {
                fCompulsory = false;
            }

            Year = returnedValue[7];
            Semester = returnedValue[8];
            
            this.loaded = true;
        }

        public string Year { get; set; }
        public string Semester { get; set; }

        private string fID;
        public string ID
        {
            get
            {
                return fID;
            }
        }

        private string fName;
        public string Name
        {
            get
            {
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
                return fDescription;
            }
            set
            {
                fDescription = value;
            }
        }

        private string fCourseCategory;
        public string CourseCategory
        {
            get
            {
                return fCourseCategory;
            }
            set
            {
                fCourseCategory = value;
            }
        }

        private string fPrerequisite;
        public string Prerequisite
        {
            get
            {
                return fPrerequisite;
            }
            set
            {
                fPrerequisite = value;
            }
        }

        private string fCourseLecturer;
        public string CourseLecturer
        {
            get
            {
                return fCourseLecturer;
            }
            set
            {
                fCourseLecturer = value;
            }
        }

        private bool fCompulsory;
        public bool Compulsory
        {
            get
            {
                return fCompulsory;
            }
            set
            {
                fCompulsory = value;
            }
        }

        //public void Refresh()
        //{
        //    switch (ID)
        //    {
        //        case "A123":
        //            fName = "Course 1";
        //            fCourseCategory = Category.FromID("A");
        //            fPrerequisite = null;
        //            fCourseLecturer = Lecturer.FromID("L1");
        //            fCompulsory = true;
        //            fDescription = "A slice of heaven. Bugger, this kiwi as morepork is as tip-top as a rip-off treaty. Mean while, in the marae, James and the Giant Peach and Manus Morissette were up to no good with a bunch of good as lamingtons. The tapu force of his making scones was on par with The Hungery Caterpilar's pretty suss Tui. Put the jug on will you bro, all these bloody slippers can wait till later. The first prize for cooking up a feed goes to... The Topp Twins.";
        //            break;
        //        case "A220":
        //            fName = "Course 2";
        //            fCourseCategory = Category.FromID("A");
        //            fPrerequisite = Course.FromID("A123");
        //            fCourseLecturer = Lecturer.FromID("L1");
        //            fCompulsory = false;
        //            fDescription = "Technology has allowed paru Undie 500s to participate in the global conversation of nuclear-free kais. The next Generation of cracker manuses have already skived off over at the sausage sizzle. What's the hurry Fred Dagg?";
        //            break;
        //        case "B100":
        //            fName = "Course 3";
        //            fCourseCategory = Category.FromID("B");
        //            fPrerequisite = null;
        //            fCourseLecturer = Lecturer.FromID("L2");
        //            fCompulsory = true;
        //            fDescription = "The mean as force of his whinging was on par with Maui's chronic piece of pounamu. Put the jug on will you bro, all these snarky jerseys can wait till later. The first prize for munting goes to... Helen Clarke and his carked it Grandpa's slipper, what a dole bludger.";
        //            break;
        //        case "B222":
        //            fName = "Course 4";
        //            fCourseCategory = Category.FromID("B");
        //            fPrerequisite = Course.FromID("B100");
        //            fCourseLecturer = Lecturer.FromID("L1");
        //            fCompulsory = true;
        //            fDescription = "";
        //            break;
        //        case "C111":
        //            fName = "Course 5";
        //            fCourseCategory = Category.FromID("C");
        //            fPrerequisite = null;
        //            fCourseLecturer = Lecturer.FromID("L2");
        //            fCompulsory = true;
        //            fDescription = "";
        //            break;
        //        case "D102":
        //            fName = "Course 6";
        //            fCourseCategory = Category.FromID("D");
        //            fPrerequisite = null;
        //            fCourseLecturer = Lecturer.FromID("L1");
        //            fCompulsory = true;
        //            fDescription = "";
        //            break;
        //        case "D200":
        //            fName = "Course 7";
        //            fCourseCategory = Category.FromID("D");
        //            fPrerequisite = Course.FromID("D102");
        //            fCourseLecturer = Lecturer.FromID("L2");
        //            fCompulsory = false;
        //            fDescription = "";
        //            break;
        //        default:
        //            break;
        //    }
        //    loaded = true;
        //}

        public override string ToString()
        {
            return Name;
        }
    }
}
