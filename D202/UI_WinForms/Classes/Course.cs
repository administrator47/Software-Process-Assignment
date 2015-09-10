using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_WinForms.Classes
{
    class Course : Table<Course>
    {
        public Course(string id)
            : base(id)
        { }

        protected Course(string id, string name, Category category, Course prerequisite, Lecturer lecturer, bool compulsory, string description, int year, int semester)
            : this(id)
        {
            fName = name;
            fCourseCategory = category;
            fPrerequisite = prerequisite;
            fCourseLecturer = lecturer;
            fCompulsory = compulsory;
            fDescription = description;
            fYear = year;
            fSemester = semester;
            this.loaded = true;
        }

        public static Course[] LoadIDs()
        {
            var result = new List<Course>();

            var dr = ExecuteReader("select id from course", null);
            try
            {
                while (dr.Read())
                {
                    var id = dr.GetString(0);
                    result.Add(Course.FromID(id));
                }
            }
            finally
            {
                dr.Close();
            }

            return result.ToArray<Course>();
        }

        public static Course[] LoadIDs(Category category)
        {
            var result = new List<Course>();

            object[] sql_params = { category.ID };
            var dr = ExecuteReader("select id from course where category_id=@0", sql_params);
            try
            {
                while (dr.Read())
                {
                    var id = dr.GetString(0);
                    result.Add(Course.FromID(id));
                }
            }
            finally
            {
                dr.Close();
            }

            return result.ToArray<Course>();
        }

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

        private Category fCourseCategory;
        public Category CourseCategory
        {
            get
            {
                if (!loaded) Refresh();
                return fCourseCategory;
            }
            set
            {
                fCourseCategory = value;
            }
        }

        private Course fPrerequisite;
        public Course Prerequisite
        {
            get
            {
                if (!loaded) Refresh();
                return fPrerequisite;
            }
            set
            {
                fPrerequisite = value;
            }
        }

        private Lecturer fCourseLecturer;
        public Lecturer CourseLecturer
        {
            get
            {
                if (!loaded) Refresh();
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
                if (!loaded) Refresh();
                return fCompulsory;
            }
            set
            {
                fCompulsory = value;
            }
        }

        private int fYear;
        public int Year
        {
            get
            {
                if (!loaded) Refresh();
                return fYear;
            }
            set
            {
                fYear = value;
            }
        }

        private int fSemester;
        public int Semester
        {
            get
            {
                if (!loaded) Refresh();
                return fSemester;
            }
            set
            {
                fSemester = value;
            }
        }

        public override void Refresh()
        {
            object[] sql_params = { ID };
            var dr = ExecuteReader("select name, category_id, prerequisite, lecture_id, compulsory, description, year, semester from course where id=@0", sql_params);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    fName = dr.GetString(0);
                    fCourseCategory = Category.FromID(dr.GetString(1));
                    if (!dr.IsDBNull(2)) fPrerequisite = Course.FromID(dr.GetString(2));
                    if (!dr.IsDBNull(3)) fCourseLecturer = Lecturer.FromID(dr.GetString(3));
                    fCompulsory = (dr.GetString(4).ToUpper()[0] == 'Y');
                    fDescription = dr.GetString(5);
                    fYear = dr.GetInt32(6);
                    fSemester = dr.GetInt32(7);
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
