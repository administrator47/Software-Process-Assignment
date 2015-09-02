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
                new Course("A123", "Test Course", Category.FromID("A"), null, null, false, "Course Description"),
                new Course("B123", "Test Course", Category.FromID("B"), null, null, false, "Course Description")
            };
            return courses;
        }

        public Course[] LoadCourses(Category category)
        {
            return LoadCourses();
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
