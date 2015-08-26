﻿using System;
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
        public frmStartScreen()
        {//tester
            InitializeComponent();
        }

        private void btnLoadCategories_Click(object sender, EventArgs e)
        {
            Classes.Application app = new Classes.Application();

            List<Category> categoriesList = new List<Category>();

            categoriesList = app.LoadCategories();

            lbxLoad.Items.AddRange(categoriesList.ToArray());
        }


        // If the user clicks a Category object then it loads the corresponding courses
        // Else if Course object then load Course properties into the course info on the GUI
        private void lbxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnModify_Click(object sender, EventArgs e)
        {

        }



    }
}
