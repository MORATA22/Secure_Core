namespace WookieTablas
{
    partial class UserRanks
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
            this.lblCodeRank = new System.Windows.Forms.Label();
            this.lblDescRank = new System.Windows.Forms.Label();
            this.sdsTextDescRank = new MantenimientoTest.SdsTextBox();
            this.sdsTextBoxCodeRank = new MantenimientoTest.SdsTextBox();
            this.SuspendLayout();
            // 
            // lblCodeRank
            // 
            this.lblCodeRank.AutoSize = true;
            this.lblCodeRank.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeRank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodeRank.Location = new System.Drawing.Point(78, 176);
            this.lblCodeRank.Name = "lblCodeRank";
            this.lblCodeRank.Size = new System.Drawing.Size(58, 13);
            this.lblCodeRank.TabIndex = 18;
            this.lblCodeRank.Text = "CodeRank";
            // 
            // lblDescRank
            // 
            this.lblDescRank.AllowDrop = true;
            this.lblDescRank.AutoSize = true;
            this.lblDescRank.BackColor = System.Drawing.Color.Transparent;
            this.lblDescRank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescRank.Location = new System.Drawing.Point(78, 233);
            this.lblDescRank.Name = "lblDescRank";
            this.lblDescRank.Size = new System.Drawing.Size(58, 13);
            this.lblDescRank.TabIndex = 17;
            this.lblDescRank.Text = "DescRank";
            // 
            // sdsTextDescRank
            // 
            this.sdsTextDescRank.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextDescRank.CodeSector = null;
            this.sdsTextDescRank.ColumnName = "DescRank";
            this.sdsTextDescRank.DescCodi = null;
            this.sdsTextDescRank.Location = new System.Drawing.Point(194, 230);
            this.sdsTextDescRank.Name = "sdsTextDescRank";
            this.sdsTextDescRank.Nom = null;
            this.sdsTextDescRank.NomBBDD = "SecureCore";
            this.sdsTextDescRank.NomCamp = null;
            this.sdsTextDescRank.NomControl = null;
            this.sdsTextDescRank.NomTaula = "UserRanks";
            this.sdsTextDescRank.Requerit = true;
            this.sdsTextDescRank.SiEsForana = false;
            this.sdsTextDescRank.Size = new System.Drawing.Size(100, 20);
            this.sdsTextDescRank.TabIndex = 16;
            // 
            // sdsTextBoxCodeRank
            // 
            this.sdsTextBoxCodeRank.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBoxCodeRank.CodeSector = null;
            this.sdsTextBoxCodeRank.ColumnName = "CodeRank";
            this.sdsTextBoxCodeRank.DescCodi = null;
            this.sdsTextBoxCodeRank.Location = new System.Drawing.Point(194, 173);
            this.sdsTextBoxCodeRank.Name = "sdsTextBoxCodeRank";
            this.sdsTextBoxCodeRank.Nom = null;
            this.sdsTextBoxCodeRank.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRank.NomCamp = null;
            this.sdsTextBoxCodeRank.NomControl = null;
            this.sdsTextBoxCodeRank.NomTaula = "UserRanks";
            this.sdsTextBoxCodeRank.Requerit = true;
            this.sdsTextBoxCodeRank.SiEsForana = false;
            this.sdsTextBoxCodeRank.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRank.TabIndex = 15;
            // 
            // UserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodeRank);
            this.Controls.Add(this.lblDescRank);
            this.Controls.Add(this.sdsTextDescRank);
            this.Controls.Add(this.sdsTextBoxCodeRank);
            this.Name = "UserRanks";
            this.Text = "UserRanks";
            this.Load += new System.EventHandler(this.UserRanks_Load);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRank, 0);
            this.Controls.SetChildIndex(this.sdsTextDescRank, 0);
            this.Controls.SetChildIndex(this.lblDescRank, 0);
            this.Controls.SetChildIndex(this.lblCodeRank, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeRank;
        private System.Windows.Forms.Label lblDescRank;
        private MantenimientoTest.SdsTextBox sdsTextDescRank;
        private MantenimientoTest.SdsTextBox sdsTextBoxCodeRank;
    }
}