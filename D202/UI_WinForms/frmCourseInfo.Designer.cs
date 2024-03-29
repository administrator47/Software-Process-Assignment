﻿namespace UI_WinForms
{
    partial class frmCourseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseInfo));
            this.btnLoadCategories = new System.Windows.Forms.Button();
            this.lbxLoad = new System.Windows.Forms.ListBox();
            this.btnLoadCourses = new System.Windows.Forms.Button();
            this.gbxLoad = new System.Windows.Forms.GroupBox();
            this.gbxPaperInfo = new System.Windows.Forms.GroupBox();
            this.lblPaperID = new System.Windows.Forms.Label();
            this.tbxPaperID = new System.Windows.Forms.TextBox();
            this.lblPaperPrerequisite = new System.Windows.Forms.Label();
            this.tbxSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.tbxPaperPrerequisite = new System.Windows.Forms.ComboBox();
            this.tbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxLecturer = new System.Windows.Forms.GroupBox();
            this.tbxLecturerEmail = new System.Windows.Forms.TextBox();
            this.tbxLecturerPhone = new System.Windows.Forms.TextBox();
            this.tbxLecturerName = new System.Windows.Forms.ComboBox();
            this.lblLecturerInfo = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxPaperName = new System.Windows.Forms.TextBox();
            this.lblPaperName = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStudyPlan = new System.Windows.Forms.Button();
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
            this.lbxLoad.DoubleClick += new System.EventHandler(this.lbxLoad_DoubleClick);
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Location = new System.Drawing.Point(148, 34);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(95, 23);
            this.btnLoadCourses.TabIndex = 2;
            this.btnLoadCourses.Text = "Load all Papers";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // gbxLoad
            // 
            this.gbxLoad.BackColor = System.Drawing.Color.IndianRed;
            this.gbxLoad.Controls.Add(this.lbxLoad);
            this.gbxLoad.Controls.Add(this.btnLoadCategories);
            this.gbxLoad.Controls.Add(this.btnLoadCourses);
            this.gbxLoad.Location = new System.Drawing.Point(120, 108);
            this.gbxLoad.Name = "gbxLoad";
            this.gbxLoad.Size = new System.Drawing.Size(270, 298);
            this.gbxLoad.TabIndex = 3;
            this.gbxLoad.TabStop = false;
            // 
            // gbxPaperInfo
            // 
            this.gbxPaperInfo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbxPaperInfo.Controls.Add(this.lblPaperID);
            this.gbxPaperInfo.Controls.Add(this.tbxPaperID);
            this.gbxPaperInfo.Controls.Add(this.lblPaperPrerequisite);
            this.gbxPaperInfo.Controls.Add(this.tbxSemester);
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
            // 
            // lblPaperID
            // 
            this.lblPaperID.AutoSize = true;
            this.lblPaperID.Location = new System.Drawing.Point(354, 16);
            this.lblPaperID.Name = "lblPaperID";
            this.lblPaperID.Size = new System.Drawing.Size(49, 13);
            this.lblPaperID.TabIndex = 16;
            this.lblPaperID.Text = "Paper ID";
            // 
            // tbxPaperID
            // 
            this.tbxPaperID.Location = new System.Drawing.Point(357, 37);
            this.tbxPaperID.Name = "tbxPaperID";
            this.tbxPaperID.Size = new System.Drawing.Size(46, 20);
            this.tbxPaperID.TabIndex = 15;
            this.tbxPaperID.TextChanged += new System.EventHandler(this.tbxPaperID_TextChanged);
            // 
            // lblPaperPrerequisite
            // 
            this.lblPaperPrerequisite.AutoSize = true;
            this.lblPaperPrerequisite.Location = new System.Drawing.Point(135, 129);
            this.lblPaperPrerequisite.Name = "lblPaperPrerequisite";
            this.lblPaperPrerequisite.Size = new System.Drawing.Size(93, 13);
            this.lblPaperPrerequisite.TabIndex = 14;
            this.lblPaperPrerequisite.Text = "Paper Prerequisite";
            // 
            // tbxSemester
            // 
            this.tbxSemester.Location = new System.Drawing.Point(205, 102);
            this.tbxSemester.Name = "tbxSemester";
            this.tbxSemester.ReadOnly = true;
            this.tbxSemester.Size = new System.Drawing.Size(30, 20);
            this.tbxSemester.TabIndex = 13;
            this.tbxSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxSemester.TextChanged += new System.EventHandler(this.tbxSemester_TextChanged);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(148, 105);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 13);
            this.lblSemester.TabIndex = 12;
            this.lblSemester.Text = "Semester";
            // 
            // tbxPaperPrerequisite
            // 
            this.tbxPaperPrerequisite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxPaperPrerequisite.Enabled = false;
            this.tbxPaperPrerequisite.Location = new System.Drawing.Point(81, 145);
            this.tbxPaperPrerequisite.Name = "tbxPaperPrerequisite";
            this.tbxPaperPrerequisite.Size = new System.Drawing.Size(193, 21);
            this.tbxPaperPrerequisite.TabIndex = 11;
            this.tbxPaperPrerequisite.SelectedIndexChanged += new System.EventHandler(this.tbxPaperPrerequisite_SelectedIndexChanged);
            this.tbxPaperPrerequisite.TextChanged += new System.EventHandler(this.tbxPaperPrerequisite_TextChanged);
            // 
            // tbxCategory
            // 
            this.tbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxCategory.Enabled = false;
            this.tbxCategory.Location = new System.Drawing.Point(81, 76);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(193, 21);
            this.tbxCategory.TabIndex = 9;
            this.tbxCategory.SelectedIndexChanged += new System.EventHandler(this.tbxCategory_SelectedIndexChanged);
            this.tbxCategory.TextChanged += new System.EventHandler(this.tbxCategory_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(150, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // gbxLecturer
            // 
            this.gbxLecturer.Controls.Add(this.tbxLecturerEmail);
            this.gbxLecturer.Controls.Add(this.tbxLecturerPhone);
            this.gbxLecturer.Controls.Add(this.tbxLecturerName);
            this.gbxLecturer.Controls.Add(this.lblLecturerInfo);
            this.gbxLecturer.Location = new System.Drawing.Point(300, 156);
            this.gbxLecturer.Name = "gbxLecturer";
            this.gbxLecturer.Size = new System.Drawing.Size(169, 131);
            this.gbxLecturer.TabIndex = 7;
            this.gbxLecturer.TabStop = false;
            // 
            // tbxLecturerEmail
            // 
            this.tbxLecturerEmail.Location = new System.Drawing.Point(6, 96);
            this.tbxLecturerEmail.Name = "tbxLecturerEmail";
            this.tbxLecturerEmail.ReadOnly = true;
            this.tbxLecturerEmail.Size = new System.Drawing.Size(157, 20);
            this.tbxLecturerEmail.TabIndex = 9;
            // 
            // tbxLecturerPhone
            // 
            this.tbxLecturerPhone.Location = new System.Drawing.Point(6, 70);
            this.tbxLecturerPhone.Name = "tbxLecturerPhone";
            this.tbxLecturerPhone.ReadOnly = true;
            this.tbxLecturerPhone.Size = new System.Drawing.Size(157, 20);
            this.tbxLecturerPhone.TabIndex = 8;
            // 
            // tbxLecturerName
            // 
            this.tbxLecturerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxLecturerName.Enabled = false;
            this.tbxLecturerName.Location = new System.Drawing.Point(6, 44);
            this.tbxLecturerName.Name = "tbxLecturerName";
            this.tbxLecturerName.Size = new System.Drawing.Size(157, 21);
            this.tbxLecturerName.TabIndex = 7;
            this.tbxLecturerName.SelectedIndexChanged += new System.EventHandler(this.tbxLecturerName_SelectedIndexChanged);
            // 
            // lblLecturerInfo
            // 
            this.lblLecturerInfo.AutoSize = true;
            this.lblLecturerInfo.Location = new System.Drawing.Point(31, 21);
            this.lblLecturerInfo.Name = "lblLecturerInfo";
            this.lblLecturerInfo.Size = new System.Drawing.Size(101, 13);
            this.lblLecturerInfo.TabIndex = 6;
            this.lblLecturerInfo.Text = "Lecturer Information";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(113, 102);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.ReadOnly = true;
            this.tbxYear.Size = new System.Drawing.Size(30, 20);
            this.tbxYear.TabIndex = 5;
            this.tbxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxYear.TextChanged += new System.EventHandler(this.tbxYear_TextChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(81, 105);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(25, 203);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(247, 83);
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
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // tbxPaperName
            // 
            this.tbxPaperName.Location = new System.Drawing.Point(81, 37);
            this.tbxPaperName.Name = "tbxPaperName";
            this.tbxPaperName.ReadOnly = true;
            this.tbxPaperName.Size = new System.Drawing.Size(193, 20);
            this.tbxPaperName.TabIndex = 1;
            this.tbxPaperName.TextChanged += new System.EventHandler(this.tbxPaperName_TextChanged);
            // 
            // lblPaperName
            // 
            this.lblPaperName.AutoSize = true;
            this.lblPaperName.Location = new System.Drawing.Point(142, 16);
            this.lblPaperName.Name = "lblPaperName";
            this.lblPaperName.Size = new System.Drawing.Size(66, 13);
            this.lblPaperName.TabIndex = 0;
            this.lblPaperName.Text = "Paper Name";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1054, 587);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(97, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(951, 587);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStudyPlan
            // 
            this.btnStudyPlan.Location = new System.Drawing.Point(400, 499);
            this.btnStudyPlan.Name = "btnStudyPlan";
            this.btnStudyPlan.Size = new System.Drawing.Size(199, 46);
            this.btnStudyPlan.TabIndex = 7;
            this.btnStudyPlan.Text = "Create Study Plan";
            this.btnStudyPlan.UseVisualStyleBackColor = true;
            this.btnStudyPlan.Click += new System.EventHandler(this.btnStudyPlan_Click);
            // 
            // frmCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 612);
            this.Controls.Add(this.btnStudyPlan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.gbxPaperInfo);
            this.Controls.Add(this.gbxLoad);
            this.Name = "frmCourseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BICT Course Information";
            this.Load += new System.EventHandler(this.frmCourseInfo_Load);
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
        private System.Windows.Forms.Button btnLoadCourses;
        private System.Windows.Forms.GroupBox gbxLoad;
        private System.Windows.Forms.GroupBox gbxPaperInfo;
        private System.Windows.Forms.Label lblPaperName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxPaperName;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox tbxPaperPrerequisite;
        private System.Windows.Forms.ComboBox tbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxLecturer;
        private System.Windows.Forms.TextBox tbxLecturerEmail;
        private System.Windows.Forms.TextBox tbxLecturerPhone;
        private System.Windows.Forms.ComboBox tbxLecturerName;
        private System.Windows.Forms.Label lblLecturerInfo;
        private System.Windows.Forms.Label lblPaperPrerequisite;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPaperID;
        private System.Windows.Forms.TextBox tbxPaperID;
        private System.Windows.Forms.Button btnStudyPlan;
    }
}

