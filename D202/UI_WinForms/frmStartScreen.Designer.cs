namespace UI_WinForms
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
            this.lblPaperName = new System.Windows.Forms.Label();
            this.tbxPaperName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.gbxLoad.SuspendLayout();
            this.gbxPaperInfo.SuspendLayout();
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
            // 
            // lbxLoad
            // 
            this.lbxLoad.FormattingEnabled = true;
            this.lbxLoad.Location = new System.Drawing.Point(20, 102);
            this.lbxLoad.Name = "lbxLoad";
            this.lbxLoad.Size = new System.Drawing.Size(171, 160);
            this.lbxLoad.TabIndex = 1;
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
            this.gbxPaperInfo.Controls.Add(this.tbxYear);
            this.gbxPaperInfo.Controls.Add(this.lblYear);
            this.gbxPaperInfo.Controls.Add(this.tbxDescription);
            this.gbxPaperInfo.Controls.Add(this.lblDescription);
            this.gbxPaperInfo.Controls.Add(this.tbxPaperName);
            this.gbxPaperInfo.Controls.Add(this.lblPaperName);
            this.gbxPaperInfo.Location = new System.Drawing.Point(568, 108);
            this.gbxPaperInfo.Name = "gbxPaperInfo";
            this.gbxPaperInfo.Size = new System.Drawing.Size(498, 388);
            this.gbxPaperInfo.TabIndex = 4;
            this.gbxPaperInfo.TabStop = false;
            // 
            // lblPaperName
            // 
            this.lblPaperName.AutoSize = true;
            this.lblPaperName.Location = new System.Drawing.Point(133, 20);
            this.lblPaperName.Name = "lblPaperName";
            this.lblPaperName.Size = new System.Drawing.Size(66, 13);
            this.lblPaperName.TabIndex = 0;
            this.lblPaperName.Text = "Paper Name";
            // 
            // tbxPaperName
            // 
            this.tbxPaperName.Location = new System.Drawing.Point(122, 42);
            this.tbxPaperName.Name = "tbxPaperName";
            this.tbxPaperName.Size = new System.Drawing.Size(100, 20);
            this.tbxPaperName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(38, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Paper Description";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(41, 99);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(181, 83);
            this.tbxDescription.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(321, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(324, 45);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(100, 20);
            this.tbxYear.TabIndex = 5;
            // 
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 612);
            this.Controls.Add(this.gbxPaperInfo);
            this.Controls.Add(this.gbxLoad);
            this.Name = "frmStartScreen";
            this.Text = "BICT Course Information";
            this.gbxLoad.ResumeLayout(false);
            this.gbxPaperInfo.ResumeLayout(false);
            this.gbxPaperInfo.PerformLayout();
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
    }
}

