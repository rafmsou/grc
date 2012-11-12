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
    public partial class ListaPedido : Form
    {
        public ListaPedido()
        {
            InitializeComponent();
        }

        private void ListaPedido_Load(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();

            var result = from pedido in db.PEDIDO
                         select new
                         {
                             Codigo = pedido.CODIGO,
                             Data = pedido.DATA,
                             Cliente = pedido.CLIENTE.NOME
                         };

            dgListaPedido.DataSource = result;
            
        }

        private void dgListaPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GRCEntities db = new GRCEntities();
            var codigoPedido = Convert.ToInt32(dgListaPedido.Rows[e.RowIndex].Cells["Codigo"].Value);

            var items = db.PEDIDO_ITEM.Where(p => p.PEDIDO.CODIGO == codigoPedido);
            listItems.Items.Clear();
            foreach (var item in items)
            {

                listItems.Items.Add(db.PRODUTO.First(p => p.CODIGO == item.CODIGO_PRODUTO).DESCRICAO);
            }
        }
    }
}
