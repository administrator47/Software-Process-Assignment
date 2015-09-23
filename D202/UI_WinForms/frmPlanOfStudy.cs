using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_WinForms.Classes;

namespace UI_WinForms
{
    public partial class frmPlanOfStudy : Form
    {
        public frmPlanOfStudy()
        {
            InitializeComponent();
        }

        private void frmPlanOfStudy_Load(object sender, EventArgs e)
        {
            //TODO 
            // If no plan made then load default
            SetupCourses();
            // Else setup previous

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetupCourses();
        }

        private void SetupCourses ()
        {
            int year = 3;
            int semester = 2;
            if(rdoSemesterOne.Checked)
            {
                semester = 1;
            }
            if(rdoYearTwo.Checked)
            {
                year = 2;
            }

            // list of course objects retrieved from database based on year and semester
            List<Course> courseList = new List<Course>();
            courseList.AddRange(Course.LoadIDs(year, semester));
            courseList.AddRange(Course.LoadIDs(year, 3));

            // Any duplicates are filtered out
            //courseList = courseList.GroupBy(x => x)
            // .Where(x => x.Count() > 1)
            // .Select(x => x.Key)
            // .ToList();

            // All compulsory Course objects are loaded into a new course array
            Course[] compulsory = (from comp in courseList
                                   where comp.Compulsory == true
                                   select comp).ToArray();

            // Listbox is cleared then course array is added
            lbxCompulsory.Items.Clear();
            lbxCompulsory.Items.AddRange(compulsory);

            // All non-compulsory Course objects are loaded into a new course array
            Course[] nonCompulsory = (from comp in courseList
                                   where comp.Compulsory == false
                                   select comp).ToArray();

            // Course array is added to the listbox
            cbxOne.Items.Clear();
            cbxOne.Items.AddRange(nonCompulsory);
            cbxTwo.Items.Clear();
            cbxTwo.Items.AddRange(nonCompulsory);
            cbxThree.Items.Clear();
            cbxThree.Items.AddRange(nonCompulsory);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


    }
}
