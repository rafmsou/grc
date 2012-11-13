using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace GRC
{
    public partial class CadastroPedido : Form
    {
        public int codigoCliente = 0;

        public CadastroPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();
            try
            {
                var cpf = Convert.ToInt64(txtCPF.Text.Replace(".", "").Replace("-", ""));

                var cliente = db.CLIENTE.Where(c => c.CPF == cpf).FirstOrDefault();

                if (cliente != null)
                {
                    this.codigoCliente = cliente.CODIGO;
                    this.lblCliente.Text = cliente.NOME;
                    return;
                }

                this.lblCliente.Text = "Cliente não encontrado.";

            }
            catch (Exception)
            {
                MessageBox.Show("CPF inválido.");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();
            var codigo = Convert.ToInt32(txtCodigoProduto.Text);
            var produto = db.PRODUTO.First(p => p.CODIGO == codigo);

            dtItems.Rows.Add(produto.CODIGO, produto.DESCRICAO, 1, produto.VALOR, produto.VALOR);

            RecalculaValorTotal();
        }

        private void dtItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // botao excluir
            if (e.ColumnIndex == 5)
            {
                dtItems.Rows.RemoveAt(e.RowIndex);
                RecalculaValorTotal();
            }
        }

        private void dtItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // txt quantidade
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        var qtde = Convert.ToInt32(dtItems.Rows[e.RowIndex].Cells["Quantidade"].Value);
                        var precoUnit = Convert.ToDecimal(dtItems.Rows[e.RowIndex].Cells["Preco"].Value);
                        var total = (qtde * precoUnit).ToString(new CultureInfo("pt-br"));
                        dtItems.Rows[e.RowIndex].Cells["Total"].Value = total;
                        RecalculaValorTotal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                   
                }
            }
        }

        private void RecalculaValorTotal()
        {
            decimal valorTotal = 0;
            foreach (DataGridViewRow row in dtItems.Rows)
            {
                valorTotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            lblTotalPedido.Text = valorTotal.ToString(new CultureInfo("pt-br"));
        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            txtCPF.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();

            if (lblCliente.Text == "Nenhum cliente selecionado")
            {
                MessageBox.Show("Necessário selecionar um cliente");
                return;
            }
            if (dtItems.Rows.Count == 0)
            {
                MessageBox.Show("Necessário adicionar pelo menos um produto ao pedido.");
                return;
            }

            try
            {
                PEDIDO p = new PEDIDO();
                p.CLIENTE = db.CLIENTE.First(c => c.CODIGO == this.codigoCliente);
                p.DATA = DateTime.Now;
                p.VALOR_TOTAL = Convert.ToDecimal(lblTotalPedido.Text);

                db.AddToPEDIDO(p);

                foreach (DataGridViewRow row in dtItems.Rows)
                {
                    PEDIDO_ITEM pedidoItem = new PEDIDO_ITEM();
                    pedidoItem.PEDIDO = p;
                    var codigoProd = Convert.ToInt32(row.Cells["Codigo"].Value);
                    pedidoItem.PRODUTO = db.PRODUTO.First(pr => pr.CODIGO == codigoProd);
                    pedidoItem.QUANTIDADE = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    pedidoItem.PRECO_UNIT = Convert.ToDecimal(row.Cells["Preco"].Value);
                    pedidoItem.TOTAL = Convert.ToDecimal(row.Cells["Total"].Value);

                    db.AddToPEDIDO_ITEM(pedidoItem);
                }

                db.SaveChanges();
                
                //limpa os campos
                txtCPF.Text = String.Empty;
                txtCodigoProduto.Text = String.Empty;
                for (int i = 0; i < dtItems.Rows.Count; i++)
                {
                    dtItems.Rows.RemoveAt(i);
                }
                lblTotalPedido.Text = "0";

                MessageBox.Show("Pedido salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
