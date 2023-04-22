namespace Vista
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MostrarContraseña = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(120, 86);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(100, 20);
            this.UsuariotextBox.TabIndex = 2;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(120, 115);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(100, 20);
            this.ContraseñatextBox.TabIndex = 3;
            // 
            // AceptarButtom
            // 
            this.AceptarButtom.Location = new System.Drawing.Point(87, 154);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(75, 23);
            this.AceptarButtom.TabIndex = 4;
            this.AceptarButtom.Text = "Aceptar";
            this.AceptarButtom.UseVisualStyleBackColor = true;
            this.AceptarButtom.Click += new System.EventHandler(this.AceptarButtom_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MostrarContraseña
            // 
            this.MostrarContraseña.Location = new System.Drawing.Point(235, 113);
            this.MostrarContraseña.Name = "MostrarContraseña";
            this.MostrarContraseña.Size = new System.Drawing.Size(115, 23);
            this.MostrarContraseña.TabIndex = 5;
            this.MostrarContraseña.Text = "Mostrar Contraseña";
            this.MostrarContraseña.UseVisualStyleBackColor = true;
            this.MostrarContraseña.Click += new System.EventHandler(this.MostrarContraseña_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(182, 154);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 299);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.MostrarContraseña);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button MostrarContraseña;
        private System.Windows.Forms.Button Cancelarbutton;
    }
}

