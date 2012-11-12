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
    public partial class ListaProduto : Form
    {
        public ListaProduto()
        {
            InitializeComponent();
        }

        private void ListaProduto_Load(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();
            var produtos = from p in db.PRODUTO
                           select new { 
                            Codigo = p.CODIGO,
                            Descricao = p.DESCRICAO,
                            Preco_Unit = p.VALOR
                           };

            dgProdutos.DataSource = produtos;
        }
    }
}
