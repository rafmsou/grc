using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRC
{
    public partial class MenuPedido : Form
    {
        public MenuPedido()
        {
            InitializeComponent();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            new ListaPedido().Show();
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            new CadastroPedido().Show();
        }
    }
}
