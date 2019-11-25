namespace ProyectoFinal_Jenry.UI.Consultas
{
    partial class cArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cArticulo));
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RangocheckBox = new System.Windows.Forms.CheckBox();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Imprimirbutton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimirbutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimirbutton.Image")));
            this.Imprimirbutton.Location = new System.Drawing.Point(491, 729);
            this.Imprimirbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(226, 97);
            this.Imprimirbutton.TabIndex = 40;
            this.Imprimirbutton.UseVisualStyleBackColor = false;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultadataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(25, 159);
            this.ConsultadataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.RowHeadersWidth = 62;
            this.ConsultadataGridView.Size = new System.Drawing.Size(1173, 560);
            this.ConsultadataGridView.TabIndex = 39;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(789, 76);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(300, 26);
            this.CriteriotextBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(784, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Criterio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Consultarbutton);
            this.groupBox2.Controls.Add(this.FiltrocomboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(491, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(706, 135);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Consultarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Consultarbutton.Image")));
            this.Consultarbutton.Location = new System.Drawing.Point(614, 43);
            this.Consultarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(76, 63);
            this.Consultarbutton.TabIndex = 26;
            this.Consultarbutton.UseVisualStyleBackColor = false;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Codigo",
            "Producto",
            "Proveedor",
            "Seccion",
            "Precio",
            "Costo",
            "Ganancia"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(20, 60);
            this.FiltrocomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(260, 28);
            this.FiltrocomboBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filtro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RangocheckBox);
            this.groupBox1.Controls.Add(this.HastadateTimePicker);
            this.groupBox1.Controls.Add(this.DesdedateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(458, 135);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // RangocheckBox
            // 
            this.RangocheckBox.AutoSize = true;
            this.RangocheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangocheckBox.Location = new System.Drawing.Point(18, 22);
            this.RangocheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RangocheckBox.Name = "RangocheckBox";
            this.RangocheckBox.Size = new System.Drawing.Size(153, 24);
            this.RangocheckBox.TabIndex = 10;
            this.RangocheckBox.Text = "USAR FECHA";
            this.RangocheckBox.UseVisualStyleBackColor = true;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(296, 62);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.HastadateTimePicker.TabIndex = 5;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(80, 62);
            this.DesdedateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.DesdedateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // cArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1228, 830);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cArticulo";
            this.Text = "Consultas Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox RangocheckBox;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}