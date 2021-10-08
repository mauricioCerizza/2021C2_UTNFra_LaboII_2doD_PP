namespace CiberFront
{
    partial class FormAltaCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nmrcUpDwnEdad = new System.Windows.Forms.NumericUpDown();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBxDNI = new System.Windows.Forms.TextBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Location = new System.Drawing.Point(42, 105);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(179, 23);
            this.txtBxNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(42, 146);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.Location = new System.Drawing.Point(42, 167);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(179, 23);
            this.txtBxApellido.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(42, 212);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(51, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Apellido";
            // 
            // nmrcUpDwnEdad
            // 
            this.nmrcUpDwnEdad.Location = new System.Drawing.Point(42, 242);
            this.nmrcUpDwnEdad.Name = "nmrcUpDwnEdad";
            this.nmrcUpDwnEdad.Size = new System.Drawing.Size(120, 23);
            this.nmrcUpDwnEdad.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(42, 24);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI";
            // 
            // txtBxDNI
            // 
            this.txtBxDNI.Location = new System.Drawing.Point(42, 45);
            this.txtBxDNI.Name = "txtBxDNI";
            this.txtBxDNI.Size = new System.Drawing.Size(179, 23);
            this.txtBxDNI.TabIndex = 6;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(42, 303);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttnCancelar.TabIndex = 8;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(196, 303);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttnAceptar.TabIndex = 9;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 359);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtBxDNI);
            this.Controls.Add(this.nmrcUpDwnEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBxNombre);
            this.Name = "FormAltaCliente";
            this.Text = "Alta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBxApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBxDNI;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnAceptar;
    }
}

