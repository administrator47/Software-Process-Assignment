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
    public partial class frmStartScreen : Form
    {
        Classes.Application app = new Classes.Application();

        public frmStartScreen()
        {//tester
            InitializeComponent();
        }

        private void btnLoadCategories_Click(object sender, EventArgs e)
        {
            lbxLoad.Items.AddRange(app.LoadCategories());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (btnSave.Visible)
            {
                DialogResult msgbxResult = MessageBox.Show("Are you sure you want to stop modifying?", "Warning!", MessageBoxButtons.YesNo);

                if (msgbxResult.Equals(DialogResult.Yes))
                {
                    btnSave.Visible = false;
                    btnModify.Text = "Modify";
                }
               
            }

            else
            {
                // Makes the save button visible
                btnSave.Visible = true;
                btnModify.Text = "Stop Modifying";
            }

        }

        // If the user double clicks a Category object then it loads the corresponding courses
        private void lbxLoad_DoubleClick(object sender, EventArgs e)
        {

        }


        // If selected item is a Course object then display course info
        private void lbxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
                var itemSel = lbxLoad.SelectedItem as Category;
                
                if (itemSel != null)
                {
                    tbxDescription.Text = itemSel.Description;   
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult msgbxResult = MessageBox.Show("Do you want to save your changes?", "Warning!", MessageBoxButtons.YesNo);

            if (msgbxResult.Equals(DialogResult.Yes))
            {
                btnSave.Visible = false;
                btnModify.Text = "Modify";

                //SAVE CODE HERE
            }

        }



    }
}
