using System;
using System.Windows.Forms;
using UI_WinForms.Classes;

namespace UI_WinForms
{
    public partial class frmCourseInfo : Form
    {

        public frmCourseInfo()
        {
            InitializeComponent();
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

        private bool modifying = false;
        private Course course_data = null;

        /// <summary>
        /// 
        /// </summary>
        private void ModifyStart()
        {
            if (modifying || (course_data == null))
            {
                return;
            }

            modifying = true;

            // Certain buttons are hidden
            ShowAndHide();

            course_data.Refresh();
            RefreshCourse();
        }

        /// <summary>
        /// 
        /// </summary>
        private void ModifyStop()
        {
            bool abort = false;
            if (modifying && course_data.Dirty)
            {
                // Messagebox appears warning the user that they will lose progress if they press yes
                DialogResult msgbxResult = MessageBox.Show("Are you sure you want to stop modifying? You will lose all progress?", "Warning!", MessageBoxButtons.YesNo);
                abort = (msgbxResult != DialogResult.Yes);
            }
            if (!abort)
            {
                modifying = false;

                // Certain buttons are hidden
                ShowAndHide();

                // Reload category into information box
                course_data.Refresh();
                RefreshCourse();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ModifySave()
        {
            bool abort = false;
            if (modifying && course_data.Dirty)
            {
                // Message box appears asking if the user wants to save their changes
                DialogResult msgbxResult = MessageBox.Show("Do you want to save your changes?", "Warning!", MessageBoxButtons.YesNo);
                abort = (msgbxResult != DialogResult.Yes);
            }
            if (!abort)
            {
                course_data.Update();
                ModifyStop();
            }
        }

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
                ModifyStop();

            }

            // Else save button is not visible and the user is clicking "Modify"
            else
            {
                ModifyStart();
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

        private void SetCombo(ComboBox cbx, Object item)
        {
            if (item != null)
            {
                cbx.SelectedItem = item;
            }
            else
            {
                cbx.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void RefreshCourse()
        {
            Course[] all_courses = Course.LoadIDs();
            Category[] all_categories = Category.LoadIDs();
            Lecturer[] all_lecturers = Lecturer.LoadIDs();

            // Contents of Course object are loaded into the information boxes 
            tbxDescription.Text = course_data.Description;
            tbxPaperName.Text = course_data.Name;

            tbxCategory.Items.Clear();
            tbxCategory.Items.Add("(None)");
            tbxCategory.Items.AddRange(all_categories);
            SetCombo(tbxCategory, course_data.CourseCategory);

            tbxYear.Text = course_data.Year.ToString();

            if (course_data.Semester == 3)
            {
                tbxSemester.Text = "1,2";
            }
            else
            {
                tbxSemester.Text = course_data.Semester.ToString();
            }

            tbxPaperID.Text = course_data.ID;

            tbxPaperPrerequisite.Items.Clear();
            tbxPaperPrerequisite.Items.Add("(None)");
            tbxPaperPrerequisite.Items.AddRange(all_courses);
            SetCombo(tbxPaperPrerequisite, course_data.Prerequisite);

            // Lecturer information loaded in
            tbxLecturerName.Items.Clear();
            tbxLecturerName.Items.Add("Project Sponsor");
            tbxLecturerName.Items.AddRange(all_lecturers);
            SetCombo(tbxLecturerName, course_data.CourseLecturer);
            RefreshLecturer();
        }

        private void RefreshLecturer()
        {
            if (course_data.CourseLecturer != null)
            {
                tbxLecturerEmail.Text = course_data.CourseLecturer.Email;
                tbxLecturerPhone.Text = course_data.CourseLecturer.Phone;
            }
            else
            {
                tbxLecturerEmail.Text = "N/A";
                tbxLecturerPhone.Text = "N/A";
            }
        }

        private void tbxPaperName_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.Name = tbxPaperName.Text;
            }
        }

        private void tbxPaperID_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.ID = tbxPaperID.Text;
            }
        }

        private void tbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.CourseCategory = (tbxCategory.SelectedItem as Category);
            }
        }

        private void tbxCategory_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                // FIXME: Combobox needed.
            }
        }

        private void tbxYear_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.Year = int.Parse(tbxYear.Text);
            }
        }

        private void tbxSemester_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.Semester = int.Parse(tbxSemester.Text);
            }
        }

        private void tbxPaperPrerequisite_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                // FIXME: Combobox needed.
            }
        }

        private void tbxPaperPrerequisite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.Prerequisite = (tbxPaperPrerequisite.SelectedItem as Course);
            }
        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.Description = tbxDescription.Text;
            }
        }

        private void tbxLecturerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modifying)
            {
                course_data.CourseLecturer = (tbxLecturerName.SelectedItem as Lecturer);
                RefreshLecturer();
            }
        }


        // If selected item is a Course object then display course info
        private void lbxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Variable declared that will hold the object that the user has selected from the listbox
            var itemSelected = lbxLoad.SelectedItem;

            if (itemSelected == course_data)
            {
                // Newly selected item is currently loaded item, assume selection change was aborted.
                return;
            }

            if (modifying)
            {
                // Attempt to abort modification of currently loaded item.
                ModifyStop();
                if (modifying)
                {
                    // Abort selected item change.
                    lbxLoad.SelectedItem = course_data;
                    return;
                }
            }

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

            // If statement to check what type of object the user has selected
            // If user has clicked the list box whilst the categories are loaded into it..
            if (itemSelected is Category)
            {
                course_data = null;

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
                course_data = (Course)itemSelected;
                RefreshCourse();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ModifySave();
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
                    TextBox tbx = c as TextBox;
                    ComboBox cbx = c as ComboBox;
                    if (tbx != null)
                    {
                        tbx.ReadOnly = true;
                    }
                    if (cbx != null)
                    {
                        cbx.Enabled = false;
                    }
                }

                // Loop through lecturer Info groupbox and disable textbox
                foreach (Control c in gbxLecturer.Controls)
                {
                    TextBox tbx = c as TextBox;
                    ComboBox cbx = c as ComboBox;
                    if (tbx != null)
                    {
                        tbx.ReadOnly = true;
                    }
                    if (cbx != null)
                    {
                        cbx.Enabled = false;
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
                foreach (Control c in gbxPaperInfo.Controls)
                {
                    TextBox tbx = c as TextBox;
                    ComboBox cbx = c as ComboBox;
                    if (tbx != null)
                    {
                        tbx.Enabled = true;
                        tbx.ReadOnly = false;
                    }
                    if (cbx != null)
                    {
                        cbx.Enabled = true;
                    }
                }

                // Loop through lecturer Info groupbox and enable textbox
                foreach (Control c in gbxLecturer.Controls)
                {
                    TextBox tbx = c as TextBox;
                    ComboBox cbx = c as ComboBox;
                    if (tbx != null)
                    {
                        tbx.Enabled = true;
                        //tbx.ReadOnly = false;
                    }
                    if (cbx != null)
                    {
                        cbx.Enabled = true;
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
