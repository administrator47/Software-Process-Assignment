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
            this.gbxLoad.BackColor = System.Drawing.Color.Transparent;
            this.gbxLoad.Controls.Add(this.lbxLoad);
            this.gbxLoad.Controls.Add(this.btnLoadCategories);
            this.gbxLoad.Controls.Add(this.btnLoadAll);
            this.gbxLoad.Location = new System.Drawing.Point(24, 78);
            this.gbxLoad.Name = "gbxLoad";
            this.gbxLoad.Size = new System.Drawing.Size(270, 298);
            this.gbxLoad.TabIndex = 3;
            this.gbxLoad.TabStop = false;
            this.gbxLoad.Enter += new System.EventHandler(this.gbxLoad_Enter);
            // 
            // gbxPaperInfo
            // 
            this.gbxPaperInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxPaperInfo.Controls.Add(this.lblPaperName);
            this.gbxPaperInfo.Location = new System.Drawing.Point(543, 138);
            this.gbxPaperInfo.Name = "gbxPaperInfo";
            this.gbxPaperInfo.Size = new System.Drawing.Size(360, 277);
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
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 534);
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
    }
}

