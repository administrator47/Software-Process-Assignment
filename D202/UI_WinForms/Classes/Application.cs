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
                Course.FromID("A123"),
                Course.FromID("A220"),
                Course.FromID("B100"),
                Course.FromID("C111"),
                Course.FromID("B222"),
                Course.FromID("D102"),
                Course.FromID("D200")
            };
            return courses;
        }

        public Course[] LoadCourses(Category category)
        {
            return (
                from course in LoadCourses()
                where course.CourseCategory == category
                select course
            ).ToArray();
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
