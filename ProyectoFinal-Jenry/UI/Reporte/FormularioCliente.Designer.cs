﻿namespace ProyectoFinal_Jenry.UI.Reporte
{
    partial class FormularioCliente
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
            this.VisorCrystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorCrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorCrystalReport.Location = new System.Drawing.Point(0, 0);
            this.VisorCrystalReport.Name = "VisorCrystalReport";
            this.VisorCrystalReport.Size = new System.Drawing.Size(1359, 721);
            this.VisorCrystalReport.TabIndex = 0;
            this.VisorCrystalReport.Load += new System.EventHandler(this.VisorCrystalReport_Load);
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1359, 721);
            this.Controls.Add(this.VisorCrystalReport);
            this.Name = "FormularioCliente";
            this.Text = "Formulario Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VisorCrystalReport;
    }
}