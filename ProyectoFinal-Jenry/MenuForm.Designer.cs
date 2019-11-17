namespace ProyectoFinal_Jenry
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosArticulosToolStripMenuItem,
            this.registrosClienteToolStripMenuItem,
            this.registroProveedorToolStripMenuItem,
            this.registroUsuarioToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrosArticulosToolStripMenuItem
            // 
            this.registrosArticulosToolStripMenuItem.Name = "registrosArticulosToolStripMenuItem";
            this.registrosArticulosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registrosArticulosToolStripMenuItem.Text = "Registro Articulo";
            this.registrosArticulosToolStripMenuItem.Click += new System.EventHandler(this.RegistrosArticulosToolStripMenuItem_Click);
            // 
            // registrosClienteToolStripMenuItem
            // 
            this.registrosClienteToolStripMenuItem.Name = "registrosClienteToolStripMenuItem";
            this.registrosClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registrosClienteToolStripMenuItem.Text = "Registros Cliente";
            this.registrosClienteToolStripMenuItem.Click += new System.EventHandler(this.RegistrosClienteToolStripMenuItem_Click);
            // 
            // registroProveedorToolStripMenuItem
            // 
            this.registroProveedorToolStripMenuItem.Name = "registroProveedorToolStripMenuItem";
            this.registroProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registroProveedorToolStripMenuItem.Text = "Registro Proveedor";
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 673);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}

