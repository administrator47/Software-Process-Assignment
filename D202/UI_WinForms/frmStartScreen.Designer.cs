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
            this.btnLoadCategories = new System.Windows.Forms.Button();
            this.lbxLoad = new System.Windows.Forms.ListBox();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadCategories
            // 
            this.btnLoadCategories.Location = new System.Drawing.Point(12, 33);
            this.btnLoadCategories.Name = "btnLoadCategories";
            this.btnLoadCategories.Size = new System.Drawing.Size(106, 23);
            this.btnLoadCategories.TabIndex = 0;
            this.btnLoadCategories.Text = "Load Categories";
            this.btnLoadCategories.UseVisualStyleBackColor = true;
            // 
            // lbxLoad
            // 
            this.lbxLoad.FormattingEnabled = true;
            this.lbxLoad.Location = new System.Drawing.Point(25, 76);
            this.lbxLoad.Name = "lbxLoad";
            this.lbxLoad.Size = new System.Drawing.Size(171, 160);
            this.lbxLoad.TabIndex = 1;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(124, 33);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(95, 23);
            this.btnLoadAll.TabIndex = 2;
            this.btnLoadAll.Text = "Load all Papers";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            // 
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 284);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.lbxLoad);
            this.Controls.Add(this.btnLoadCategories);
            this.Name = "frmStartScreen";
            this.Text = "BICT Course Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCategories;
        private System.Windows.Forms.ListBox lbxLoad;
        private System.Windows.Forms.Button btnLoadAll;
    }
}

