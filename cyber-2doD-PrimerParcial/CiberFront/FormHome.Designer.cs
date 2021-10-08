
namespace CiberFront
{
    partial class FormHome
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
            this.bttnAltaCliente = new System.Windows.Forms.Button();
            this.bttnListarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnAltaCliente
            // 
            this.bttnAltaCliente.Location = new System.Drawing.Point(521, 79);
            this.bttnAltaCliente.Name = "bttnAltaCliente";
            this.bttnAltaCliente.Size = new System.Drawing.Size(142, 23);
            this.bttnAltaCliente.TabIndex = 0;
            this.bttnAltaCliente.Text = "Nuevo Cliente";
            this.bttnAltaCliente.UseVisualStyleBackColor = true;
            this.bttnAltaCliente.Click += new System.EventHandler(this.bttnAltaCliente_Click);
            // 
            // bttnListarClientes
            // 
            this.bttnListarClientes.Location = new System.Drawing.Point(521, 138);
            this.bttnListarClientes.Name = "bttnListarClientes";
            this.bttnListarClientes.Size = new System.Drawing.Size(142, 23);
            this.bttnListarClientes.TabIndex = 1;
            this.bttnListarClientes.Text = "Listar Clientes";
            this.bttnListarClientes.UseVisualStyleBackColor = true;
            this.bttnListarClientes.Click += new System.EventHandler(this.bttnListarClientes_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnListarClientes);
            this.Controls.Add(this.bttnAltaCliente);
            this.Name = "FormHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAltaCliente;
        private System.Windows.Forms.Button bttnListarClientes;
    }
}