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
        /// Loads Categories of papers from the database
        /// </summary>
        /// <returns>Array containing all the Categories of the database</returns>
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

        /// <summary>
        /// Loads all Courses from the database
        /// </summary>
        /// <returns>Array containing all Courses from the database</returns>
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

        /// <summary>
        /// Loads all Courses from the database and sorts them by category param
        /// </summary>
        /// <param name="category">Category to sort by</param>
        /// <returns>Array containing sorted Courses </returns>
        public Course[] LoadCourses(Category category)
        {
            // Returns sorted Course objects in array
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
