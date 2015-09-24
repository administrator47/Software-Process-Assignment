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

            if (tbxUsername.Text.Length < 0 || tbxPassword.Text.Length < 0)
            {
                MessageBox.Show("Pease enter a valid username and password!!");
                tbxUsername.Focus();
            }
            else
            {
                Verify();
            }

            
        }

        private void Verify ()
        {
            string studLecy = tbxUsername.Text;
            // Make the error label invisible
            lblError.Visible = false;

            DatabaseConnector qwd = new DatabaseConnector();

            List<string> test = qwd.LoginConnect("db_owner.SELECT_ID",tbxUsername.Text,tbxPassword.Text);

            // If the count of test is greater than 0 then that means something was returned
            if (test.Count() > 0)
            {
                // If login code returns results
                this.Hide();
                frmCourseInfo courseInfo = new frmCourseInfo(test[0], test[1]);
                courseInfo.ShowDialog();
                this.Close();
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
