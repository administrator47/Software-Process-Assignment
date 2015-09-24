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
        Student LoggedInStudent = new Student();

        public frmPlanOfStudy(string studID, string studName)
        {
            InitializeComponent();
            LoggedInStudent = new Student(studID,studName);
        }

        private void frmPlanOfStudy_Load(object sender, EventArgs e)
        {
            lblStudentID.Text = LoggedInStudent.ID;
            lblWelcome.Text = "Welcome, " + LoggedInStudent.Name;
            //TODO SQL QUERY HERE
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

            // Foreach loop goes through every ComboBox, clears the items then adds the range on non-compulsory course items
            foreach(ComboBox c in gbxCourses.Controls)
            {
                c.Items.Clear();
                c.Items.AddRange(nonCompulsory);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete you plan of study?", "Warning!", MessageBoxButtons.YesNo);

                if(dr.Equals(DialogResult.Yes))
                {
                   // Delete textbox text
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConstructTextbox()
        {
            try 
            {
                // Clear the textbox
                tbxCoursesOutput.Clear();

                // Setup textbox
             //   tbxCoursesOutput.Text = "STUDYPLAN: \n \nYear Two:\n" /*Compulsory*/+ +"\n" + +"\n" + +"\n" + +"\n";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
