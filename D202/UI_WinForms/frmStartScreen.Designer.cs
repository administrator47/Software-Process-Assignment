﻿namespace UI_WinForms
{
    partial class frmStartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartScreen));
            this.btnLoadCategories = new System.Windows.Forms.Button();
            this.lbxLoad = new System.Windows.Forms.ListBox();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.gbxLoad = new System.Windows.Forms.GroupBox();
            this.gbxPaperInfo = new System.Windows.Forms.GroupBox();
            this.lblPaperPrerequisite = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.tbxPaperPrerequisite = new System.Windows.Forms.TextBox();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxLecturer = new System.Windows.Forms.GroupBox();
            this.tbxLecturerEmail = new System.Windows.Forms.TextBox();
            this.tbxLecturerPhone = new System.Windows.Forms.TextBox();
            this.tbxLecturerName = new System.Windows.Forms.TextBox();
            this.lblLecturerInfo = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxPaperName = new System.Windows.Forms.TextBox();
            this.lblPaperName = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.gbxLoad.SuspendLayout();
            this.gbxPaperInfo.SuspendLayout();
            this.gbxLecturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCategories
            // 
            this.btnLoadCategories.Location = new System.Drawing.Point(20, 34);
            this.btnLoadCategories.Name = "btnLoadCategories";
            this.btnLoadCategories.Size = new System.Drawing.Size(106, 23);
            this.btnLoadCategories.TabIndex = 0;
            this.btnLoadCategories.Text = "Load Categories";
            this.btnLoadCategories.UseVisualStyleBackColor = true;
            this.btnLoadCategories.Click += new System.EventHandler(this.btnLoadCategories_Click);
            // 
            // lbxLoad
            // 
            this.lbxLoad.FormattingEnabled = true;
            this.lbxLoad.Location = new System.Drawing.Point(20, 102);
            this.lbxLoad.Name = "lbxLoad";
            this.lbxLoad.Size = new System.Drawing.Size(171, 160);
            this.lbxLoad.TabIndex = 1;
            this.lbxLoad.SelectedIndexChanged += new System.EventHandler(this.lbxLoad_SelectedIndexChanged);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(148, 34);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(95, 23);
            this.btnLoadAll.TabIndex = 2;
            this.btnLoadAll.Text = "Load all Papers";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            // 
            // gbxLoad
            // 
            this.gbxLoad.BackColor = System.Drawing.Color.IndianRed;
            this.gbxLoad.Controls.Add(this.lbxLoad);
            this.gbxLoad.Controls.Add(this.btnLoadCategories);
            this.gbxLoad.Controls.Add(this.btnLoadAll);
            this.gbxLoad.Location = new System.Drawing.Point(120, 108);
            this.gbxLoad.Name = "gbxLoad";
            this.gbxLoad.Size = new System.Drawing.Size(270, 298);
            this.gbxLoad.TabIndex = 3;
            this.gbxLoad.TabStop = false;
            this.gbxLoad.Enter += new System.EventHandler(this.gbxLoad_Enter);
            // 
            // gbxPaperInfo
            // 
            this.gbxPaperInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbxPaperInfo.Controls.Add(this.lblPaperPrerequisite);
            this.gbxPaperInfo.Controls.Add(this.txtSemester);
            this.gbxPaperInfo.Controls.Add(this.lblSemester);
            this.gbxPaperInfo.Controls.Add(this.tbxPaperPrerequisite);
            this.gbxPaperInfo.Controls.Add(this.tbxCategory);
            this.gbxPaperInfo.Controls.Add(this.lblCategory);
            this.gbxPaperInfo.Controls.Add(this.gbxLecturer);
            this.gbxPaperInfo.Controls.Add(this.tbxYear);
            this.gbxPaperInfo.Controls.Add(this.lblYear);
            this.gbxPaperInfo.Controls.Add(this.tbxDescription);
            this.gbxPaperInfo.Controls.Add(this.lblDescription);
            this.gbxPaperInfo.Controls.Add(this.tbxPaperName);
            this.gbxPaperInfo.Controls.Add(this.lblPaperName);
            this.gbxPaperInfo.Location = new System.Drawing.Point(568, 108);
            this.gbxPaperInfo.Name = "gbxPaperInfo";
            this.gbxPaperInfo.Size = new System.Drawing.Size(491, 309);
            this.gbxPaperInfo.TabIndex = 4;
            this.gbxPaperInfo.TabStop = false;
            this.gbxPaperInfo.Enter += new System.EventHandler(this.gbxPaperInfo_Enter);
            // 
            // lblPaperPrerequisite
            // 
            this.lblPaperPrerequisite.AutoSize = true;
            this.lblPaperPrerequisite.Location = new System.Drawing.Point(119, 129);
            this.lblPaperPrerequisite.Name = "lblPaperPrerequisite";
            this.lblPaperPrerequisite.Size = new System.Drawing.Size(93, 13);
            this.lblPaperPrerequisite.TabIndex = 14;
            this.lblPaperPrerequisite.Text = "Paper Prerequisite";
            this.lblPaperPrerequisite.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(285, 102);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(30, 20);
            this.txtSemester.TabIndex = 13;
            this.txtSemester.TextChanged += new System.EventHandler(this.txtSemester_TextChanged);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(228, 105);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 13);
            this.lblSemester.TabIndex = 12;
            this.lblSemester.Text = "Semester";
            this.lblSemester.Click += new System.EventHandler(this.lblSemester_Click);
            // 
            // tbxPaperPrerequisite
            // 
            this.tbxPaperPrerequisite.Location = new System.Drawing.Point(122, 145);
            this.tbxPaperPrerequisite.Name = "tbxPaperPrerequisite";
            this.tbxPaperPrerequisite.ReadOnly = true;
            this.tbxPaperPrerequisite.Size = new System.Drawing.Size(100, 20);
            this.tbxPaperPrerequisite.TabIndex = 11;
            this.tbxPaperPrerequisite.TextChanged += new System.EventHandler(this.tbxPaperPrerequisite_TextChanged);
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(122, 76);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.ReadOnly = true;
            this.tbxCategory.Size = new System.Drawing.Size(193, 20);
            this.tbxCategory.TabIndex = 9;
            this.tbxCategory.TextChanged += new System.EventHandler(this.tbxCategory_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(183, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // gbxLecturer
            // 
            this.gbxLecturer.Controls.Add(this.tbxLecturerEmail);
            this.gbxLecturer.Controls.Add(this.tbxLecturerPhone);
            this.gbxLecturer.Controls.Add(this.tbxLecturerName);
            this.gbxLecturer.Controls.Add(this.lblLecturerInfo);
            this.gbxLecturer.Location = new System.Drawing.Point(320, 156);
            this.gbxLecturer.Name = "gbxLecturer";
            this.gbxLecturer.Size = new System.Drawing.Size(149, 131);
            this.gbxLecturer.TabIndex = 7;
            this.gbxLecturer.TabStop = false;
            this.gbxLecturer.Enter += new System.EventHandler(this.gbxLecturer_Enter);
            // 
            // tbxLecturerEmail
            // 
            this.tbxLecturerEmail.Location = new System.Drawing.Point(24, 96);
            this.tbxLecturerEmail.Name = "tbxLecturerEmail";
            this.tbxLecturerEmail.ReadOnly = true;
            this.tbxLecturerEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxLecturerEmail.TabIndex = 9;
            // 
            // tbxLecturerPhone
            // 
            this.tbxLecturerPhone.Location = new System.Drawing.Point(24, 70);
            this.tbxLecturerPhone.Name = "tbxLecturerPhone";
            this.tbxLecturerPhone.ReadOnly = true;
            this.tbxLecturerPhone.Size = new System.Drawing.Size(100, 20);
            this.tbxLecturerPhone.TabIndex = 8;
            // 
            // tbxLecturerName
            // 
            this.tbxLecturerName.Location = new System.Drawing.Point(24, 44);
            this.tbxLecturerName.Name = "tbxLecturerName";
            this.tbxLecturerName.ReadOnly = true;
            this.tbxLecturerName.Size = new System.Drawing.Size(100, 20);
            this.tbxLecturerName.TabIndex = 7;
            // 
            // lblLecturerInfo
            // 
            this.lblLecturerInfo.AutoSize = true;
            this.lblLecturerInfo.Location = new System.Drawing.Point(21, 14);
            this.lblLecturerInfo.Name = "lblLecturerInfo";
            this.lblLecturerInfo.Size = new System.Drawing.Size(101, 13);
            this.lblLecturerInfo.TabIndex = 6;
            this.lblLecturerInfo.Text = "Lecturer Information";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(154, 102);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.ReadOnly = true;
            this.tbxYear.Size = new System.Drawing.Size(30, 20);
            this.tbxYear.TabIndex = 5;
            this.tbxYear.TextChanged += new System.EventHandler(this.tbxYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(119, 105);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(25, 203);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(274, 83);
            this.tbxDescription.TabIndex = 3;
            this.tbxDescription.TextChanged += new System.EventHandler(this.tbxDescription_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(22, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Paper Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // tbxPaperName
            // 
            this.tbxPaperName.Location = new System.Drawing.Point(122, 37);
            this.tbxPaperName.Name = "tbxPaperName";
            this.tbxPaperName.ReadOnly = true;
            this.tbxPaperName.Size = new System.Drawing.Size(193, 20);
            this.tbxPaperName.TabIndex = 1;
            this.tbxPaperName.TextChanged += new System.EventHandler(this.tbxPaperName_TextChanged);
            // 
            // lblPaperName
            // 
            this.lblPaperName.AutoSize = true;
            this.lblPaperName.Location = new System.Drawing.Point(183, 16);
            this.lblPaperName.Name = "lblPaperName";
            this.lblPaperName.Size = new System.Drawing.Size(66, 13);
            this.lblPaperName.TabIndex = 0;
            this.lblPaperName.Text = "Paper Name";
            this.lblPaperName.Click += new System.EventHandler(this.lblPaperName_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1067, 581);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 612);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.gbxPaperInfo);
            this.Controls.Add(this.gbxLoad);
            this.Name = "frmStartScreen";
            this.Text = "BICT Course Information";
            this.gbxLoad.ResumeLayout(false);
            this.gbxPaperInfo.ResumeLayout(false);
            this.gbxPaperInfo.PerformLayout();
            this.gbxLecturer.ResumeLayout(false);
            this.gbxLecturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCategories;
        private System.Windows.Forms.ListBox lbxLoad;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.GroupBox gbxLoad;
        private System.Windows.Forms.GroupBox gbxPaperInfo;
        private System.Windows.Forms.Label lblPaperName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxPaperName;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox tbxPaperPrerequisite;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxLecturer;
        private System.Windows.Forms.TextBox tbxLecturerEmail;
        private System.Windows.Forms.TextBox tbxLecturerPhone;
        private System.Windows.Forms.TextBox tbxLecturerName;
        private System.Windows.Forms.Label lblLecturerInfo;
        private System.Windows.Forms.Label lblPaperPrerequisite;
        private System.Windows.Forms.Button btnModify;
    }
}

