namespace ProyectoFinal_Jenry.UI.Registros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.Aceptarrbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClavetextBox.Location = new System.Drawing.Point(57, 406);
            this.ClavetextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(346, 26);
            this.ClavetextBox.TabIndex = 10;
            // 
            // Aceptarrbutton
            // 
            this.Aceptarrbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Aceptarrbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarrbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aceptarrbutton.Location = new System.Drawing.Point(57, 469);
            this.Aceptarrbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Aceptarrbutton.Name = "Aceptarrbutton";
            this.Aceptarrbutton.Size = new System.Drawing.Size(348, 65);
            this.Aceptarrbutton.TabIndex = 11;
            this.Aceptarrbutton.Text = "Siguiente";
            this.Aceptarrbutton.UseVisualStyleBackColor = false;
            this.Aceptarrbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(54, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "USUARIO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(52, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "CLAVE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(57, 333);
            this.UsuariotextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(346, 26);
            this.UsuariotextBox.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(487, 554);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.Aceptarrbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsuariotextBox);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.Button Aceptarrbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}