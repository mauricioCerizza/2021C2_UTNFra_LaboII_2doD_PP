
namespace CiberFront
{
    partial class FormClientes
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
            this.rTxtBxClientes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTxtBxClientes
            // 
            this.rTxtBxClientes.Location = new System.Drawing.Point(51, 72);
            this.rTxtBxClientes.Name = "rTxtBxClientes";
            this.rTxtBxClientes.Size = new System.Drawing.Size(689, 293);
            this.rTxtBxClientes.TabIndex = 0;
            this.rTxtBxClientes.Text = "";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtBxClientes);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtBxClientes;
    }
}