using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace CiberFront
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }


        private void FormClientes_Load(object sender, EventArgs e)
        {
            rTxtBxClientes.Text = Gestion.MostrarClientes();
        }
    }
}
