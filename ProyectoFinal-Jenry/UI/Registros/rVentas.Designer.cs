namespace ProyectoFinal_Jenry.UI.Registros
{
    partial class rVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rVentas));
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.ModocomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Clientebutton = new System.Windows.Forms.Button();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.ITBIStextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DisponiblestextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.Articulobutton = new System.Windows.Forms.Button();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalledataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DetalledataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(7, 26);
            this.DetalledataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.RowHeadersWidth = 62;
            this.DetalledataGridView.Size = new System.Drawing.Size(663, 261);
            this.DetalledataGridView.TabIndex = 62;
            this.DetalledataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalledataGridView_CellContentClick);
            // 
            // ModocomboBox
            // 
            this.ModocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModocomboBox.FormattingEnabled = true;
            this.ModocomboBox.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.ModocomboBox.Location = new System.Drawing.Point(562, 636);
            this.ModocomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModocomboBox.Name = "ModocomboBox";
            this.ModocomboBox.Size = new System.Drawing.Size(146, 28);
            this.ModocomboBox.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 639);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Pago";
            // 
            // Clientebutton
            // 
            this.Clientebutton.BackColor = System.Drawing.Color.Teal;
            this.Clientebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clientebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clientebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clientebutton.Location = new System.Drawing.Point(611, 100);
            this.Clientebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clientebutton.Name = "Clientebutton";
            this.Clientebutton.Size = new System.Drawing.Size(93, 32);
            this.Clientebutton.TabIndex = 59;
            this.Clientebutton.Text = "+";
            this.Clientebutton.UseVisualStyleBackColor = false;
            this.Clientebutton.Click += new System.EventHandler(this.Clientebutton_Click);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(155, 104);
            this.ClientecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(448, 28);
            this.ClientecomboBox.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cliente";
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(562, 713);
            this.SubtotaltextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.ReadOnly = true;
            this.SubtotaltextBox.Size = new System.Drawing.Size(142, 26);
            this.SubtotaltextBox.TabIndex = 56;
            // 
            // ITBIStextBox
            // 
            this.ITBIStextBox.Location = new System.Drawing.Point(562, 677);
            this.ITBIStextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ITBIStextBox.Name = "ITBIStextBox";
            this.ITBIStextBox.ReadOnly = true;
            this.ITBIStextBox.Size = new System.Drawing.Size(142, 26);
            this.ITBIStextBox.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 716);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "SUBTOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 680);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "ITBIS";
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.White;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Addbutton.Image = ((System.Drawing.Image)(resources.GetObject("Addbutton.Image")));
            this.Addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbutton.Location = new System.Drawing.Point(506, 259);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(198, 49);
            this.Addbutton.TabIndex = 52;
            this.Addbutton.Text = "   + AGREGAR";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.BackColor = System.Drawing.Color.White;
            this.Removerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Removerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removerbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Removerbutton.Image = ((System.Drawing.Image)(resources.GetObject("Removerbutton.Image")));
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(45, 636);
            this.Removerbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(290, 67);
            this.Removerbutton.TabIndex = 51;
            this.Removerbutton.Text = "- REMOVER FILA";
            this.Removerbutton.UseVisualStyleBackColor = false;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(289, 24);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(68, 62);
            this.Buscarbutton.TabIndex = 50;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(155, 272);
            this.CantidadnumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(180, 26);
            this.CantidadnumericUpDown.TabIndex = 49;
            this.CantidadnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cantidad";
            // 
            // DisponiblestextBox
            // 
            this.DisponiblestextBox.Location = new System.Drawing.Point(363, 271);
            this.DisponiblestextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisponiblestextBox.Name = "DisponiblestextBox";
            this.DisponiblestextBox.ReadOnly = true;
            this.DisponiblestextBox.Size = new System.Drawing.Size(91, 26);
            this.DisponiblestextBox.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(155, 218);
            this.PreciotextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(549, 26);
            this.PreciotextBox.TabIndex = 45;
            // 
            // Articulobutton
            // 
            this.Articulobutton.BackColor = System.Drawing.Color.Teal;
            this.Articulobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Articulobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Articulobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Articulobutton.Location = new System.Drawing.Point(611, 164);
            this.Articulobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Articulobutton.Name = "Articulobutton";
            this.Articulobutton.Size = new System.Drawing.Size(93, 28);
            this.Articulobutton.TabIndex = 44;
            this.Articulobutton.Text = "+";
            this.Articulobutton.UseVisualStyleBackColor = false;
            this.Articulobutton.Click += new System.EventHandler(this.Articulobutton_Click);
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(155, 164);
            this.ProductocomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(448, 28);
            this.ProductocomboBox.TabIndex = 43;
            this.ProductocomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(155, 40);
            this.IDnumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(126, 26);
            this.IDnumericUpDown.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Location = new System.Drawing.Point(45, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 295);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(562, 749);
            this.TotaltextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(142, 26);
            this.TotaltextBox.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 752);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "TOTAL";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(43, 809);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(173, 81);
            this.Nuevobutton.TabIndex = 66;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(533, 809);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(173, 81);
            this.Eliminarbutton.TabIndex = 65;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(289, 809);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(165, 81);
            this.Guardarbutton.TabIndex = 64;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(504, 35);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FechadateTimePicker.TabIndex = 69;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 904);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ModocomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Clientebutton);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.ITBIStextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DisponiblestextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.Articulobutton);
            this.Controls.Add(this.ProductocomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDnumericUpDown);
            this.Name = "rVentas";
            this.Text = "rVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.ComboBox ModocomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Clientebutton;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.TextBox ITBIStextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DisponiblestextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Button Articulobutton;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}