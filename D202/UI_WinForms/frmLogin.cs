using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Event handlers are made for the textboxes which calls the check enter method on keypress
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Call the Verify method
            Verify();
        }

        private void Verify ()
        {
            // Make the error label invisible
            lblError.Visible = false;

            // If the password and the username match then
            if ((tbxPassword.Text == "admin" && tbxUsername.Text == "admin") || (tbxPassword.Text.Length == 0 && tbxUsername.Text.Length == 0))
            {
                // If login code returns results
                this.Hide();
                frmCourseInfo courseInfo = new frmCourseInfo();
                courseInfo.ShowDialog();
                this.Close();
                //TODO: Need to make an account object (or student)
            }

            else
            {
                // Error label made visible
                lblError.Visible = true;
                // Text in the password textbox is cleared
                tbxPassword.Text = "";
                // The password textbox is made the focus of the form
                tbxPassword.Focus();
            }

        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // If the user pressed Enter then call the Verify method
            if (e.KeyChar == (char)13)
            {
                Verify();
            }
        }
    }
}
