namespace WookieTablas
{
    partial class Routes
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
            this.sdsTextBoxCodeRoute = new MantenimientoTest.SdsTextBox();
            this.sdsTextBoxDescRoute = new MantenimientoTest.SdsTextBox();
            this.lblCodeRoute = new System.Windows.Forms.Label();
            this.lblDescRoute = new System.Windows.Forms.Label();
            this.sdsForaneaRouteTypes = new MantenimientoForanea.sdsForanea();
            this.sdsTextBoxRouteTypes = new MantenimientoTest.SdsTextBox();
            this.SuspendLayout();
            // 
            // sdsTextBoxCodeRoute
            // 
            this.sdsTextBoxCodeRoute.CodeSector = null;
            this.sdsTextBoxCodeRoute.ColumnName = "CodeRoute";
            this.sdsTextBoxCodeRoute.DescCodi = null;
            this.sdsTextBoxCodeRoute.Location = new System.Drawing.Point(175, 152);
            this.sdsTextBoxCodeRoute.Name = "sdsTextBoxCodeRoute";
            this.sdsTextBoxCodeRoute.Nom = null;
            this.sdsTextBoxCodeRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRoute.NomCamp = null;
            this.sdsTextBoxCodeRoute.NomControl = null;
            this.sdsTextBoxCodeRoute.NomTaula = "Routes";
            this.sdsTextBoxCodeRoute.Requerit = false;
            this.sdsTextBoxCodeRoute.SiEsForana = false;
            this.sdsTextBoxCodeRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRoute.TabIndex = 9;
            // 
            // sdsTextBoxDescRoute
            // 
            this.sdsTextBoxDescRoute.CodeSector = null;
            this.sdsTextBoxDescRoute.ColumnName = "DescRoute";
            this.sdsTextBoxDescRoute.DescCodi = null;
            this.sdsTextBoxDescRoute.Location = new System.Drawing.Point(175, 198);
            this.sdsTextBoxDescRoute.Name = "sdsTextBoxDescRoute";
            this.sdsTextBoxDescRoute.Nom = null;
            this.sdsTextBoxDescRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxDescRoute.NomCamp = null;
            this.sdsTextBoxDescRoute.NomControl = null;
            this.sdsTextBoxDescRoute.NomTaula = "Routes";
            this.sdsTextBoxDescRoute.Requerit = false;
            this.sdsTextBoxDescRoute.SiEsForana = false;
            this.sdsTextBoxDescRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxDescRoute.TabIndex = 10;
            // 
            // lblCodeRoute
            // 
            this.lblCodeRoute.AutoSize = true;
            this.lblCodeRoute.Location = new System.Drawing.Point(84, 156);
            this.lblCodeRoute.Name = "lblCodeRoute";
            this.lblCodeRoute.Size = new System.Drawing.Size(64, 13);
            this.lblCodeRoute.TabIndex = 11;
            this.lblCodeRoute.Text = "CodeRoute:";
            // 
            // lblDescRoute
            // 
            this.lblDescRoute.AutoSize = true;
            this.lblDescRoute.Location = new System.Drawing.Point(84, 198);
            this.lblDescRoute.Name = "lblDescRoute";
            this.lblDescRoute.Size = new System.Drawing.Size(64, 13);
            this.lblDescRoute.TabIndex = 12;
            this.lblDescRoute.Text = "DescRoute:";
            // 
            // sdsForaneaRouteTypes
            // 
            this.sdsForaneaRouteTypes.Control_Id = "txtidRoute";
            this.sdsForaneaRouteTypes.DescCodi = "DescRouteType";
            this.sdsForaneaRouteTypes.ErrorText = null;
            this.sdsForaneaRouteTypes.Location = new System.Drawing.Point(0, 242);
            this.sdsForaneaRouteTypes.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaRouteTypes.Name = "sdsForaneaRouteTypes";
            this.sdsForaneaRouteTypes.NomCamp = "CodeRouteType";
            this.sdsForaneaRouteTypes.NomControl = "txtIDRoute";
            this.sdsForaneaRouteTypes.NomID = "idRouteType";
            this.sdsForaneaRouteTypes.NomTaula = "RouteTypes";
            this.sdsForaneaRouteTypes.Requerit = false;
            this.sdsForaneaRouteTypes.Size = new System.Drawing.Size(391, 46);
            this.sdsForaneaRouteTypes.TabIndex = 13;
            this.sdsForaneaRouteTypes.TextLabel = "Tipus de Ruta";
            // 
            // sdsTextBoxRouteTypes
            // 
            this.sdsTextBoxRouteTypes.CodeSector = null;
            this.sdsTextBoxRouteTypes.ColumnName = "idRouteType";
            this.sdsTextBoxRouteTypes.DescCodi = null;
            this.sdsTextBoxRouteTypes.Location = new System.Drawing.Point(330, 198);
            this.sdsTextBoxRouteTypes.Name = "sdsTextBoxRouteTypes";
            this.sdsTextBoxRouteTypes.Nom = null;
            this.sdsTextBoxRouteTypes.NomBBDD = "";
            this.sdsTextBoxRouteTypes.NomCamp = "idRouteType";
            this.sdsTextBoxRouteTypes.NomControl = "sdsForaneaRouteTypes";
            this.sdsTextBoxRouteTypes.NomTaula = "Routes";
            this.sdsTextBoxRouteTypes.Requerit = false;
            this.sdsTextBoxRouteTypes.SiEsForana = true;
            this.sdsTextBoxRouteTypes.Size = new System.Drawing.Size(20, 20);
            this.sdsTextBoxRouteTypes.TabIndex = 14;
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdsTextBoxRouteTypes);
            this.Controls.Add(this.sdsForaneaRouteTypes);
            this.Controls.Add(this.lblDescRoute);
            this.Controls.Add(this.lblCodeRoute);
            this.Controls.Add(this.sdsTextBoxDescRoute);
            this.Controls.Add(this.sdsTextBoxCodeRoute);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDescRoute, 0);
            this.Controls.SetChildIndex(this.lblCodeRoute, 0);
            this.Controls.SetChildIndex(this.lblDescRoute, 0);
            this.Controls.SetChildIndex(this.sdsForaneaRouteTypes, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxRouteTypes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MantenimientoTest.SdsTextBox sdsTextBoxCodeRoute;
        private MantenimientoTest.SdsTextBox sdsTextBoxDescRoute;
        private System.Windows.Forms.Label lblCodeRoute;
        private System.Windows.Forms.Label lblDescRoute;
        private MantenimientoForanea.sdsForanea sdsForaneaRouteTypes;
        private MantenimientoTest.SdsTextBox sdsTextBoxRouteTypes;
    }
}