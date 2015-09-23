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
    public partial class frmCourseInfo : Form
    {
        string studentOrLecturer;
        public frmCourseInfo(string studLect)
        {
            studentOrLecturer = studLect;
            InitializeComponent();
        }
        private void frmCourseInfo_Load(object sender, EventArgs e)
        {
            if (studentOrLecturer == "l")
            {
                btnStudyPlan.Visible = false;
            }
            else
            {
                btnModify.Visible = false;
            }
        }
        #region Load Category and Course
        private void btnLoadCategories_Click(object sender, EventArgs e)
        {
            // Items in the listbox are cleared
            lbxLoad.Items.Clear();

            // Items are loaded into the listbox from the database
            lbxLoad.Items.AddRange(Category.LoadIDs());

        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            // Items in the listbox are cleared
            lbxLoad.Items.Clear();

            // Items are loaded into the listbox from the database
            lbxLoad.Items.AddRange(Course.LoadIDs());
        }
        #endregion

        /// <summary>
        /// Makes the Course/Category information editable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            // If the Save button is visible then the user is clicking "Stop Modifying"
            if (btnSave.Visible)
            {
                // Messagebox appears warning the user that they will lose progress if they press yes
                DialogResult msgbxResult = MessageBox.Show("Are you sure you want to stop modifying? You will lose all progress?", "Warning!", MessageBoxButtons.YesNo);

                // If the user presses yes..
                if (msgbxResult.Equals(DialogResult.Yes))
                {
                    // Certain buttons are hidden
                    ShowAndHide();

                    // Reload category into information box
                }
               
            }

            // Else save button is not visible and the user is clicking "Modify"
            else
            {
                // Certain buttons are shown
                ShowAndHide();
            }

        }

        // If the user double clicks a Category object then it loads the corresponding courses
        private void lbxLoad_DoubleClick(object sender, EventArgs e)
        {
            // Variable declared that will hold the object that the user has selected from the listbox
            var itemSelected = lbxLoad.SelectedItem;

            // If statement to check what type of object the user has selected
            // If user has clicked the list box whilst the categories are loaded into it..
            if (itemSelected is Category)
            {
                // Items in the listbox are cleared
                lbxLoad.Items.Clear();

                // Category object declared and initialized with itemselected
                Category cat = (Category)itemSelected;

                // Items are loaded into the listbox from the database
                lbxLoad.Items.AddRange(Course.LoadIDs(cat));
            }
            
        }


        // If selected item is a Course object then display course info
        private void lbxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in gbxPaperInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                foreach (Control d in gbxLecturer.Controls)
                {
                    if (d is TextBox)
                    {
                        d.Text = "";
                    }

                }
            }
            // Variable declared that will hold the object that the user has selected from the listbox
            var itemSelected = lbxLoad.SelectedItem;
                
            // If statement to check what type of object the user has selected
            // If user has clicked the list box whilst the categories are loaded into it..
                if (itemSelected is Category)
                {
                    // Category var declared and selected listbox item is loaded into it
                    Category categoryOutput = (Category)itemSelected;

                    // Contents are loaded into the information boxes 
                    tbxDescription.Text = categoryOutput.Description;
                    tbxCategory.Text = categoryOutput.Name;
                }
            
           // Else if the item selected in the listbox is Course
                else if (itemSelected is Course)
                {
                    // Course var declared and selected listbox item is loaded into it
                    Course courseOutput = (Course)itemSelected;

                    // Contents of Course object are loaded into the information boxes 
                    tbxDescription.Text = courseOutput.Description;
                    tbxPaperName.Text = courseOutput.Name;
                    tbxCategory.Text = courseOutput.CourseCategory.ToString();
                    tbxYear.Text = courseOutput.Year.ToString();

                    if (courseOutput.Semester == 3)
                    {
                        tbxSemester.Text = "1,2";
                    }
                    else
                    {
                         tbxSemester.Text = courseOutput.Semester.ToString();
                    }

                    tbxPaperID.Text = courseOutput.ID;
                    if (courseOutput.Prerequisite != null)
                    {
                        tbxPaperPrerequisite.Text = courseOutput.Prerequisite.Name;
                    }
                    else
                    {
                        tbxPaperPrerequisite.Text = "None";
                    }

                    // Lecturer information loaded in
                    if (courseOutput.CourseLecturer != null)
                    {
                        tbxLecturerName.Text = courseOutput.CourseLecturer.Name;
                        tbxLecturerEmail.Text = courseOutput.CourseLecturer.Email;
                        tbxLecturerPhone.Text = courseOutput.CourseLecturer.Phone;
                    }
                    else
                    {
                        tbxLecturerName.Text = "Project Sponsor";
                        tbxLecturerEmail.Text = "N/A";
                        tbxLecturerPhone.Text = "N/A";
                    }


                    


                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Message box appears asking if the user wants to save their changes
            DialogResult msgbxResult = MessageBox.Show("Do you want to save your changes?", "Warning!", MessageBoxButtons.YesNo);

            // If the user selects yes then..
            if (msgbxResult.Equals(DialogResult.Yes))
            {
                // ShowAndHide method is called
                ShowAndHide();

                //SAVE CODE HERE

            }

        }

        /// <summary>
        /// Swaps between making certain objects on form visible and  invisible when they click the Modify and Save buttons.
        /// </summary>
        private void ShowAndHide()
        {
                 // If the Save Button is visible then...
            if (btnSave.Visible)
            {
                // Make the save button invisible
                btnSave.Visible = false;
                // Change btnModify's text to "Modify"
                btnModify.Text = "Modify";

                // Loop through Paper Info groupbox and disable textbox
                foreach (Control c in gbxPaperInfo.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = false;
                    }
                }

                // Loop through lecturer Info groupbox and disable textbox
                foreach (Control c in gbxLecturer.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = false;
                    }
                }
            }

                // Else the save button is hidden..
            else
            {
                // Makes the save button visible
                btnSave.Visible = true;
                // Changes btnModify's text to "Stop Modifying"
                btnModify.Text = "Stop Modifying";

                // Loop through groupbox and enable textbox
                foreach(Control c in gbxPaperInfo.Controls)
                {
                    if(c is TextBox)
                    {
                        c.Enabled = true;
                    }
                }

                // Loop through lecturer Info groupbox and disable textbox
                foreach (Control c in gbxLecturer.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = true;
                    }
                }
            }

            }

        private void btnStudyPlan_Click(object sender, EventArgs e)
        {
            // Plan of study form declared and instantiated
            frmPlanOfStudy plan = new frmPlanOfStudy();
            // Plan of study form is shown on screen
            plan.Show();
        }



    }
}
