namespace ProyectoFinal_Jenry.UI.Registros
{
    partial class rInventarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rInventarios));
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(165, 190);
            this.ProductocomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(344, 28);
            this.ProductocomboBox.TabIndex = 26;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(165, 245);
            this.CantidadnumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(344, 26);
            this.CantidadnumericUpDown.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cantidad";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(165, 135);
            this.FechadateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(344, 26);
            this.FechadateTimePicker.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(430, 52);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(79, 70);
            this.Buscarbutton.TabIndex = 21;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(41, 304);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(135, 81);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(219, 304);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(131, 81);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(386, 304);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(128, 81);
            this.Eliminarbutton.TabIndex = 18;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(165, 75);
            this.IDnumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(253, 26);
            this.IDnumericUpDown.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 422);
            this.Controls.Add(this.ProductocomboBox);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rInventarios";
            this.Text = "Registro Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}