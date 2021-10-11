using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca;

namespace CiberFront
{
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void bttnAceptar_Click(object sender, System.EventArgs e)
        {

        }

        //private Cliente ObtenerCliente() 
        //{
        //    Cliente cliente = new Cliente(txtBxNombre.Text, txtBxApellido.Text, txtBxDNI.Text, nmrcUpDwnEdad.Value);
        //    return cliente;
        //}

        //private Computadora ObtenerComputadora() 
        //{
           
        //    return Computadora;
        //}

        private List<string> ObtenerSoftwares()
        {
            List<string> softwares = new List<string>();

            foreach (Control item in grpBxSoftware.Controls) 
            {
                if (((CheckBox)item).CheckState == CheckState.Checked) 
                {
                    softwares.Add(item.Text);
                }
            }
            return softwares;
        }

        private List<string> ObtenerPerifericos()
        {
            List<string> perifericos = new List<string>();

            foreach (Control item in grpBxPeriferico.Controls)
            {
                if (((CheckBox)item).CheckState == CheckState.Checked) 
                {
                    perifericos.Add(item.Text);
                }
            }
            return perifericos;
        }

        private List<string> ObtenerJuegos()
        {
            List<string> juegos = new List<string>();

            foreach (Control item in gBxJuegos.Controls)
            {
                if (((CheckBox)item).CheckState == CheckState.Checked)
                {
                    juegos.Add(item.Text);
                }
            }
            return juegos;
        }
    }
}
