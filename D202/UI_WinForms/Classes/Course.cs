using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UI_WinForms.Classes
{
    class Course : Table<Course>
    {
        public new static string TableName()
        {
            return "course";
        }

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

        public static Course[] LoadIDs(Category category)
        {
            object[] sql_params = { category.ID };
            var dr = ExecuteReader(String.Format("select id from {0} where category_id=@0", TableName()), sql_params);
            return LoadFromDataReader(dr);
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
            var dr = ExecuteReader(String.Format(
                "select name, category_id, prerequisite, lecture_id, compulsory, description, year, semester " +
                "from {0} where id=@0",
                TableName()
            ), sql_params);
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

            object[] sql_params = { ID, Name, CourseCategory.ID, Prerequisite.ID, CourseLecturer.ID, Compulsory ? "Y" : "N", Description, Year, Semester };

            string sql_query;
            if (RecordedID == null)
            {
                sql_query = String.Format(
                    "insert {0} " +
                    "(id, name, category_id, prerequisite, lecture_id, compulsory, description, year, semester) " +
                    "values ((@0, @1, @2, @3, @4, @5, @6, @7, @8))",
                    TableName()
                );
            }
            else
            {
                sql_query = String.Format(
                    "update {0} " +
                    "set name=@1, category_id=@2, prerequisite=@3, lecture_id=@4, compulsory=@5, description=@6, year=@7, semester=@8 " +
                    "where id=@0",
                    TableName()
                );
            }
            ExecuteNonQuery(sql_query, sql_params);
            fRecordedID = ID;
            loaded = true;
            dirty = false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
