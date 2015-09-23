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

            if (tbxUsername.Text == "")
            {
                MessageBox.Show("Pease enter a valid username!!");
                tbxUsername.Focus();
            }
            else if (tbxPassword.Text == "")
            {
                MessageBox.Show("Please enter a valid password!!");
                tbxPassword.Focus();
            }

            
        }

        private void Verify ()
        {
            string studLecy = tbxUsername.Text;
            // Make the error label invisible
            lblError.Visible = false;

            // If the password and the username match then
            if ((tbxPassword.Text == "l" && tbxUsername.Text == "l") || (tbxPassword.Text == "s" && tbxUsername.Text == "s"))
            {
                // If login code returns results
                this.Hide();
                frmCourseInfo courseInfo = new frmCourseInfo(studLecy);
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
