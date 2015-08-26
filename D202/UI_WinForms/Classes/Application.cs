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
        /// 
        /// </summary>
        /// <returns></returns>
        public Category[] LoadCategories()
        {
            // TODO: Stub

            Category[] categories = {
                new Category(1, "Category 1", "Description 1 Kia ora.. Rack off, this bloody hokey pokey is as mean as as a mint scarfie. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire."),
                new Category(2, "Category 2", "Description 2 Kia ora.. Rack off, this bloody hokey pokey is as mean as as a mint scarfie. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire."),
                new Category(3, "Category 3", "Description 3 Kia ora.. Rack off, this bloody hokey pokey is as mean as as a mint scarfie. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire."),
                new Category(4, "Category 4", "Description 4 Kia ora.. Rack off, this bloody hokey pokey is as mean as as a mint scarfie. Mean while, in a waka, Lomu and Fred Dagg were up to no good with a bunch of beaut pinapple lumps. The heaps good force of his burning my Vogel's was on par with Spot, the Telecom dog's tip-top length of number 8 wire."),
            };
            return categories;
        }

        public Course[] LoadCourses()
        {
            return new Course[0];
        }

        public Course[] LoadCourses(Category category)
        {
            return new Course[0];
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
