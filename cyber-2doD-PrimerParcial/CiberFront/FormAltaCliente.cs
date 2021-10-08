using System.Windows.Forms;
using Biblioteca.Negocio;

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
            Gestion.GuardarCliente(new Cliente(txtBxNombre.Text, txtBxApellido.Text, txtBxDNI.Text, nmrcUpDwnEdad.Value));
        }
    }
}
