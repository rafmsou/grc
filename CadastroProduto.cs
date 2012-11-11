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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();

            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Descrição não pode ser vazia.");
                return;
            }
            if (txtValor.Text == String.Empty)
            {
                MessageBox.Show("Valor não pode ser vazio.");
                return;
            }


            PRODUTO prod = new PRODUTO();
            try
            {
                prod.DESCRICAO = txtDescricao.Text;
                prod.VALOR = Convert.ToDecimal(txtValor.Text);

                db.AddToPRODUTO(prod);
                db.SaveChanges();
                MessageBox.Show("Produto salvo com sucesso.");
                txtDescricao.Text = String.Empty;
                txtValor.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
            

        }
    }
}
