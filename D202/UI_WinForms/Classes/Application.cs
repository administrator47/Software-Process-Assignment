using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_WinForms.Classes
{
    class Application
    {
        public Application()
        {

        }

        /// <summary>
        /// Loads Categories of papers from the database
        /// </summary>
        /// <returns>Array containing all the Categories of the database</returns>
        public Category[] LoadCategories()
        {
            return Category.LoadIDs();
        }

        /// <summary>
        /// Loads all Courses from the database
        /// </summary>
        /// <returns>Array containing all Courses from the database</returns>
        public Course[] LoadCourses()
        {
            return Course.LoadIDs();
        }

        /// <summary>
        /// Loads all Courses from the database and sorts them by category param
        /// </summary>
        /// <param name="category">Category to sort by</param>
        /// <returns>Array containing sorted Courses </returns>
        public Course[] LoadCourses(Category category)
        {
            return Course.LoadIDs(category);
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
