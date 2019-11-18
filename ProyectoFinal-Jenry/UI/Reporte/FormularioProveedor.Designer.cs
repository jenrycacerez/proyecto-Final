namespace ProyectoFinal_Jenry.UI.Reporte
{
    partial class FormularioProveedor
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
            this.VisorCrystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorCrystalReport
            // 
            this.VisorCrystalReport.ActiveViewIndex = -1;
            this.VisorCrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorCrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorCrystalReport.Location = new System.Drawing.Point(0, 0);
            this.VisorCrystalReport.Name = "VisorCrystalReport";
            this.VisorCrystalReport.Size = new System.Drawing.Size(945, 604);
            this.VisorCrystalReport.TabIndex = 0;
            this.VisorCrystalReport.Load += new System.EventHandler(this.CrystalReportViewer1_Load);
            // 
            // FormularioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 604);
            this.Controls.Add(this.VisorCrystalReport);
            this.Name = "FormularioProveedor";
            this.Text = "FormularioProveedor";
            this.Load += new System.EventHandler(this.FormularioProveedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VisorCrystalReport;
    }
}