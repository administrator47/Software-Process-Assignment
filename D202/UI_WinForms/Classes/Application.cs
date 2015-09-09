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
            DatabaseConnector dataConnect = new DatabaseConnector();

            Category[] categories = dataConnect.GetCategories();


            return categories;
        }

        /// <summary>
        /// Loads all Courses from the database
        /// </summary>
        /// <returns>Array containing all Courses from the database</returns>
        public Course[] LoadCourses()
        {
            // TODO: Stub
            DatabaseConnector dataConnect = new DatabaseConnector();

            Course[] courses = dataConnect.GetCourses();


            return courses;
        }

        /// <summary>
        /// Loads all Courses from the database and sorts them by category param
        /// </summary>
        /// <param name="category">Category to sort by</param>
        /// <returns>Array containing sorted Courses </returns>
        public Course[] LoadCourses(Category category)
        {
            //Course[] courses = LoadCourses();
            //return courses;
            // Returns sorted Course objects in array
            return (
                from course in LoadCourses()
                where course.CourseCategory == category.ID
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
