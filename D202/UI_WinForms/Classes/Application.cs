using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI_WinForms.Classes
{
    class Application
    {
        private static SqlConnection conn = null;

        private static SqlConnection ConnectDB()
        {
            if (conn == null)
            {
                conn = new SqlConnection(
                    "server=TFS;" +
                    "database=study3;" +
                    "Integrated Security=sspi"
                );
            }
            return conn;
        }

        public Application()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Category[] LoadCategories()
        {
            // TODO: Stub

            Category[] categories = {
                Category.FromID("A"),
                Category.FromID("B"),
                Category.FromID("C"),
                Category.FromID("D"),
            };
            return categories;
        }

        public Course[] LoadCourses()
        {
            Course[] courses = {
                new Course("A123", "A Course", Category.FromID("A"), null, null, false, "Course Description"),
                new Course("B123", "B Course", Category.FromID("B"), null, null, false, "Course Description"),
                new Course("B223", "B Course", Category.FromID("B"), null, null, false, "Course Description"),
                new Course("B323", "B Course", Category.FromID("B"), null, null, false, "Course Description"),
                new Course("C123", "C Course", Category.FromID("C"), null, null, false, "Course Description"),
                new Course("D123", "D Course", Category.FromID("D"), null, null, false, "Course Description"),
                new Course("D123", "D Course", Category.FromID("D"), null, null, false, "Course Description")
            };
            return courses;
        }

        public Course[] LoadCourses(Category category)
        {
            // Course array declared and return value of LoadCourses method is loaded into it
            Course[] courses = LoadCourses();

            // List that will hold the filtered results of the foreach loop
            List<Course> filteredCourses = new List<Course>();

            // Foreach loop that will go through each Course object in the courses array
            foreach(Course c in courses)
            {
                // If the Course objects category id is equivalent to the one passed in through the parameters then...
                if (c.CourseCategory.ID == category.ID)
                {
                    // Course object is added to the filtered list
                    filteredCourses.Add(c);
                }
            }

            // New array is declared and initialized with filteredCourses list
            Course[] newList = filteredCourses.ToArray();

            // The Course Array is returned
            return newList;
        }

        public Course LockCourse(Course course)
        {
            return course;
        }

        public void UnlockCourse(Course course)
        {

        }
    }
}
