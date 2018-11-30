namespace WookieTablas
{
    partial class Regions
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
            this.sdsTextBoxCodeRegion = new MantenimientoTest.SdsTextBox();
            this.sdsTextDescRegion = new MantenimientoTest.SdsTextBox();
            this.lblDescRegion = new System.Windows.Forms.Label();
            this.lblCodeRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sdsTextBoxCodeRegion
            // 
            this.sdsTextBoxCodeRegion.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBoxCodeRegion.CodeSector = null;
            this.sdsTextBoxCodeRegion.ColumnName = "CodeRegion";
            this.sdsTextBoxCodeRegion.DescCodi = null;
            this.sdsTextBoxCodeRegion.Location = new System.Drawing.Point(150, 158);
            this.sdsTextBoxCodeRegion.Name = "sdsTextBoxCodeRegion";
            this.sdsTextBoxCodeRegion.Nom = null;
            this.sdsTextBoxCodeRegion.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRegion.NomCamp = null;
            this.sdsTextBoxCodeRegion.NomControl = null;
            this.sdsTextBoxCodeRegion.NomTaula = "Regions";
            this.sdsTextBoxCodeRegion.Requerit = true;
            this.sdsTextBoxCodeRegion.SiEsForana = false;
            this.sdsTextBoxCodeRegion.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRegion.TabIndex = 10;
            // 
            // sdsTextDescRegion
            // 
            this.sdsTextDescRegion.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextDescRegion.CodeSector = null;
            this.sdsTextDescRegion.ColumnName = "DescRegion";
            this.sdsTextDescRegion.DescCodi = null;
            this.sdsTextDescRegion.Location = new System.Drawing.Point(150, 215);
            this.sdsTextDescRegion.Name = "sdsTextDescRegion";
            this.sdsTextDescRegion.Nom = null;
            this.sdsTextDescRegion.NomBBDD = "SecureCore";
            this.sdsTextDescRegion.NomCamp = null;
            this.sdsTextDescRegion.NomControl = null;
            this.sdsTextDescRegion.NomTaula = "Regions";
            this.sdsTextDescRegion.Requerit = true;
            this.sdsTextDescRegion.SiEsForana = false;
            this.sdsTextDescRegion.Size = new System.Drawing.Size(100, 20);
            this.sdsTextDescRegion.TabIndex = 11;
            // 
            // lblDescRegion
            // 
            this.lblDescRegion.AllowDrop = true;
            this.lblDescRegion.AutoSize = true;
            this.lblDescRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescRegion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescRegion.Location = new System.Drawing.Point(34, 218);
            this.lblDescRegion.Name = "lblDescRegion";
            this.lblDescRegion.Size = new System.Drawing.Size(66, 13);
            this.lblDescRegion.TabIndex = 13;
            this.lblDescRegion.Text = "DescRegion";
            // 
            // lblCodeRegion
            // 
            this.lblCodeRegion.AutoSize = true;
            this.lblCodeRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeRegion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodeRegion.Location = new System.Drawing.Point(34, 161);
            this.lblCodeRegion.Name = "lblCodeRegion";
            this.lblCodeRegion.Size = new System.Drawing.Size(66, 13);
            this.lblCodeRegion.TabIndex = 14;
            this.lblCodeRegion.Text = "CodeRegion";
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodeRegion);
            this.Controls.Add(this.lblDescRegion);
            this.Controls.Add(this.sdsTextDescRegion);
            this.Controls.Add(this.sdsTextBoxCodeRegion);
            this.Name = "Regions";
            this.Text = "Regions";
            this.Load += new System.EventHandler(this.Regions_Load);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRegion, 0);
            this.Controls.SetChildIndex(this.sdsTextDescRegion, 0);
            this.Controls.SetChildIndex(this.lblDescRegion, 0);
            this.Controls.SetChildIndex(this.lblCodeRegion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MantenimientoTest.SdsTextBox sdsTextBoxCodeRegion;
        private MantenimientoTest.SdsTextBox sdsTextDescRegion;
        private System.Windows.Forms.Label lblDescRegion;
        private System.Windows.Forms.Label lblCodeRegion;
    }
}