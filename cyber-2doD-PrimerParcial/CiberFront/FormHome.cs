using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiberFront
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void bttnAltaCliente_Click(object sender, EventArgs e)
        {
            FormAltaCliente alta = new FormAltaCliente();
            alta.ShowDialog();
        }

        private void bttnListarClientes_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.ShowDialog();
        }
    }
}
