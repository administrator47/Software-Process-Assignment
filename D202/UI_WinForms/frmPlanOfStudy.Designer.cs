namespace UI_WinForms
{
    partial class frmPlanOfStudy
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
            this.lblPlanOfStudy = new System.Windows.Forms.Label();
            this.lblCompulsoryPapers = new System.Windows.Forms.Label();
            this.lblYourID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.cbxOne = new System.Windows.Forms.ComboBox();
            this.cbxTwo = new System.Windows.Forms.ComboBox();
            this.cbxThree = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxSemester = new System.Windows.Forms.GroupBox();
            this.rdoSemesterTwo = new System.Windows.Forms.RadioButton();
            this.rdoSemesterOne = new System.Windows.Forms.RadioButton();
            this.gbxYear = new System.Windows.Forms.GroupBox();
            this.rdoYearThree = new System.Windows.Forms.RadioButton();
            this.rdoYearTwo = new System.Windows.Forms.RadioButton();
            this.lbxCompulsory = new System.Windows.Forms.ListBox();
            this.gbxCourses = new System.Windows.Forms.GroupBox();
            this.gbxSemester.SuspendLayout();
            this.gbxYear.SuspendLayout();
            this.gbxCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlanOfStudy
            // 
            this.lblPlanOfStudy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlanOfStudy.AutoSize = true;
            this.lblPlanOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanOfStudy.Location = new System.Drawing.Point(307, 15);
            this.lblPlanOfStudy.Name = "lblPlanOfStudy";
            this.lblPlanOfStudy.Size = new System.Drawing.Size(222, 39);
            this.lblPlanOfStudy.TabIndex = 0;
            this.lblPlanOfStudy.Text = "Plan of Study";
            this.lblPlanOfStudy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCompulsoryPapers
            // 
            this.lblCompulsoryPapers.AutoSize = true;
            this.lblCompulsoryPapers.Location = new System.Drawing.Point(48, 221);
            this.lblCompulsoryPapers.Name = "lblCompulsoryPapers";
            this.lblCompulsoryPapers.Size = new System.Drawing.Size(97, 13);
            this.lblCompulsoryPapers.TabIndex = 0;
            this.lblCompulsoryPapers.Text = "Compulsory Papers";
            // 
            // lblYourID
            // 
            this.lblYourID.AutoSize = true;
            this.lblYourID.Location = new System.Drawing.Point(491, 77);
            this.lblYourID.Name = "lblYourID";
            this.lblYourID.Size = new System.Drawing.Size(46, 13);
            this.lblYourID.TabIndex = 0;
            this.lblYourID.Text = "Your ID:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStudentID.Location = new System.Drawing.Point(581, 77);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(44, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "ID Here";
            // 
            // cbxOne
            // 
            this.cbxOne.FormattingEnabled = true;
            this.cbxOne.Location = new System.Drawing.Point(20, 42);
            this.cbxOne.Name = "cbxOne";
            this.cbxOne.Size = new System.Drawing.Size(221, 21);
            this.cbxOne.TabIndex = 4;
            // 
            // cbxTwo
            // 
            this.cbxTwo.FormattingEnabled = true;
            this.cbxTwo.Location = new System.Drawing.Point(20, 93);
            this.cbxTwo.Name = "cbxTwo";
            this.cbxTwo.Size = new System.Drawing.Size(221, 21);
            this.cbxTwo.TabIndex = 5;
            // 
            // cbxThree
            // 
            this.cbxThree.FormattingEnabled = true;
            this.cbxThree.Location = new System.Drawing.Point(20, 148);
            this.cbxThree.Name = "cbxThree";
            this.cbxThree.Size = new System.Drawing.Size(221, 21);
            this.cbxThree.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(762, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(641, 459);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 459);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxSemester
            // 
            this.gbxSemester.Controls.Add(this.rdoSemesterTwo);
            this.gbxSemester.Controls.Add(this.rdoSemesterOne);
            this.gbxSemester.Location = new System.Drawing.Point(46, 78);
            this.gbxSemester.Name = "gbxSemester";
            this.gbxSemester.Size = new System.Drawing.Size(99, 46);
            this.gbxSemester.TabIndex = 10;
            this.gbxSemester.TabStop = false;
            this.gbxSemester.Text = "Semester";
            // 
            // rdoSemesterTwo
            // 
            this.rdoSemesterTwo.AutoSize = true;
            this.rdoSemesterTwo.Location = new System.Drawing.Point(57, 19);
            this.rdoSemesterTwo.Name = "rdoSemesterTwo";
            this.rdoSemesterTwo.Size = new System.Drawing.Size(31, 17);
            this.rdoSemesterTwo.TabIndex = 1;
            this.rdoSemesterTwo.Text = "2";
            this.rdoSemesterTwo.UseVisualStyleBackColor = true;
            // 
            // rdoSemesterOne
            // 
            this.rdoSemesterOne.AutoSize = true;
            this.rdoSemesterOne.Checked = true;
            this.rdoSemesterOne.Location = new System.Drawing.Point(20, 19);
            this.rdoSemesterOne.Name = "rdoSemesterOne";
            this.rdoSemesterOne.Size = new System.Drawing.Size(31, 17);
            this.rdoSemesterOne.TabIndex = 0;
            this.rdoSemesterOne.TabStop = true;
            this.rdoSemesterOne.Text = "1";
            this.rdoSemesterOne.UseVisualStyleBackColor = true;
            // 
            // gbxYear
            // 
            this.gbxYear.Controls.Add(this.rdoYearThree);
            this.gbxYear.Controls.Add(this.rdoYearTwo);
            this.gbxYear.Location = new System.Drawing.Point(49, 150);
            this.gbxYear.Name = "gbxYear";
            this.gbxYear.Size = new System.Drawing.Size(96, 43);
            this.gbxYear.TabIndex = 11;
            this.gbxYear.TabStop = false;
            this.gbxYear.Text = "Year";
            // 
            // rdoYearThree
            // 
            this.rdoYearThree.AutoSize = true;
            this.rdoYearThree.Location = new System.Drawing.Point(54, 19);
            this.rdoYearThree.Name = "rdoYearThree";
            this.rdoYearThree.Size = new System.Drawing.Size(31, 17);
            this.rdoYearThree.TabIndex = 1;
            this.rdoYearThree.Text = "3";
            this.rdoYearThree.UseVisualStyleBackColor = true;
            // 
            // rdoYearTwo
            // 
            this.rdoYearTwo.AutoSize = true;
            this.rdoYearTwo.Checked = true;
            this.rdoYearTwo.Location = new System.Drawing.Point(17, 19);
            this.rdoYearTwo.Name = "rdoYearTwo";
            this.rdoYearTwo.Size = new System.Drawing.Size(31, 17);
            this.rdoYearTwo.TabIndex = 0;
            this.rdoYearTwo.TabStop = true;
            this.rdoYearTwo.Text = "2";
            this.rdoYearTwo.UseVisualStyleBackColor = true;
            // 
            // lbxCompulsory
            // 
            this.lbxCompulsory.FormattingEnabled = true;
            this.lbxCompulsory.Location = new System.Drawing.Point(49, 249);
            this.lbxCompulsory.Name = "lbxCompulsory";
            this.lbxCompulsory.Size = new System.Drawing.Size(150, 160);
            this.lbxCompulsory.TabIndex = 12;
            // 
            // gbxCourses
            // 
            this.gbxCourses.Controls.Add(this.cbxThree);
            this.gbxCourses.Controls.Add(this.cbxTwo);
            this.gbxCourses.Controls.Add(this.cbxOne);
            this.gbxCourses.Location = new System.Drawing.Point(251, 142);
            this.gbxCourses.Name = "gbxCourses";
            this.gbxCourses.Size = new System.Drawing.Size(267, 205);
            this.gbxCourses.TabIndex = 13;
            this.gbxCourses.TabStop = false;
            this.gbxCourses.Text = "Select Course(s)";
            // 
            // frmPlanOfStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 506);
            this.Controls.Add(this.gbxCourses);
            this.Controls.Add(this.lbxCompulsory);
            this.Controls.Add(this.gbxYear);
            this.Controls.Add(this.gbxSemester);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblYourID);
            this.Controls.Add(this.lblCompulsoryPapers);
            this.Controls.Add(this.lblPlanOfStudy);
            this.Name = "frmPlanOfStudy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan of Study";
            this.Load += new System.EventHandler(this.frmPlanOfStudy_Load);
            this.gbxSemester.ResumeLayout(false);
            this.gbxSemester.PerformLayout();
            this.gbxYear.ResumeLayout(false);
            this.gbxYear.PerformLayout();
            this.gbxCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanOfStudy;
        private System.Windows.Forms.Label lblCompulsoryPapers;
        private System.Windows.Forms.Label lblYourID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox cbxOne;
        private System.Windows.Forms.ComboBox cbxTwo;
        private System.Windows.Forms.ComboBox cbxThree;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxSemester;
        private System.Windows.Forms.RadioButton rdoSemesterTwo;
        private System.Windows.Forms.RadioButton rdoSemesterOne;
        private System.Windows.Forms.GroupBox gbxYear;
        private System.Windows.Forms.RadioButton rdoYearThree;
        private System.Windows.Forms.RadioButton rdoYearTwo;
        private System.Windows.Forms.ListBox lbxCompulsory;
        private System.Windows.Forms.GroupBox gbxCourses;
    }
}