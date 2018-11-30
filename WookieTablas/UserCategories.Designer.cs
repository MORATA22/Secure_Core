namespace WookieTablas
{
    partial class UserCategories
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
            this.lblCodeCategory = new System.Windows.Forms.Label();
            this.lblDescCategory = new System.Windows.Forms.Label();
            this.sdsTextDescCategory = new MantenimientoTest.SdsTextBox();
            this.sdsTextBoxCodeCategory = new MantenimientoTest.SdsTextBox();
            this.SuspendLayout();
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodeCategory.Location = new System.Drawing.Point(82, 182);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(74, 13);
            this.lblCodeCategory.TabIndex = 22;
            this.lblCodeCategory.Text = "CodeCategory";
            // 
            // lblDescCategory
            // 
            this.lblDescCategory.AllowDrop = true;
            this.lblDescCategory.AutoSize = true;
            this.lblDescCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblDescCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescCategory.Location = new System.Drawing.Point(82, 239);
            this.lblDescCategory.Name = "lblDescCategory";
            this.lblDescCategory.Size = new System.Drawing.Size(74, 13);
            this.lblDescCategory.TabIndex = 21;
            this.lblDescCategory.Text = "DescCategory";
            // 
            // sdsTextDescCategory
            // 
            this.sdsTextDescCategory.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextDescCategory.CodeSector = null;
            this.sdsTextDescCategory.ColumnName = "DescCategory";
            this.sdsTextDescCategory.DescCodi = null;
            this.sdsTextDescCategory.Location = new System.Drawing.Point(198, 236);
            this.sdsTextDescCategory.Name = "sdsTextDescCategory";
            this.sdsTextDescCategory.Nom = null;
            this.sdsTextDescCategory.NomBBDD = "SecureCore";
            this.sdsTextDescCategory.NomCamp = null;
            this.sdsTextDescCategory.NomControl = null;
            this.sdsTextDescCategory.NomTaula = "UserCategories";
            this.sdsTextDescCategory.Requerit = true;
            this.sdsTextDescCategory.SiEsForana = false;
            this.sdsTextDescCategory.Size = new System.Drawing.Size(100, 20);
            this.sdsTextDescCategory.TabIndex = 20;
            // 
            // sdsTextBoxCodeCategory
            // 
            this.sdsTextBoxCodeCategory.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBoxCodeCategory.CodeSector = null;
            this.sdsTextBoxCodeCategory.ColumnName = "CodeCategory";
            this.sdsTextBoxCodeCategory.DescCodi = null;
            this.sdsTextBoxCodeCategory.Location = new System.Drawing.Point(198, 179);
            this.sdsTextBoxCodeCategory.Name = "sdsTextBoxCodeCategory";
            this.sdsTextBoxCodeCategory.Nom = null;
            this.sdsTextBoxCodeCategory.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeCategory.NomCamp = null;
            this.sdsTextBoxCodeCategory.NomControl = null;
            this.sdsTextBoxCodeCategory.NomTaula = "UserCategories";
            this.sdsTextBoxCodeCategory.Requerit = true;
            this.sdsTextBoxCodeCategory.SiEsForana = false;
            this.sdsTextBoxCodeCategory.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeCategory.TabIndex = 19;
            // 
            // UserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.lblDescCategory);
            this.Controls.Add(this.sdsTextDescCategory);
            this.Controls.Add(this.sdsTextBoxCodeCategory);
            this.Name = "UserCategories";
            this.Text = "UserCategories";
            this.Load += new System.EventHandler(this.UserCategories_Load);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeCategory, 0);
            this.Controls.SetChildIndex(this.sdsTextDescCategory, 0);
            this.Controls.SetChildIndex(this.lblDescCategory, 0);
            this.Controls.SetChildIndex(this.lblCodeCategory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeCategory;
        private System.Windows.Forms.Label lblDescCategory;
        private MantenimientoTest.SdsTextBox sdsTextDescCategory;
        private MantenimientoTest.SdsTextBox sdsTextBoxCodeCategory;
    }
}