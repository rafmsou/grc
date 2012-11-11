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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();

            try
            {
                CLIENTE cliente = new CLIENTE();
                cliente.NOME = txtNome.Text;
                cliente.CPF = Convert.ToInt64(txtCPF.Text.Replace(".", String.Empty).Replace("-", String.Empty));
                cliente.EMAIL = txtEmail.Text;
                cliente.TELEFONE = txtTelefone.Text;

                //endereco
                ENDERECO endereco = new ENDERECO();
                endereco.LOGRADOURO = cbLogradouro.SelectedItem + " " + txtEndereco.Text;
                endereco.NUMERO = Convert.ToInt32(txtNumero.Text);
                endereco.BAIRRO = txtBairro.Text;
                endereco.CIDADE = txtCidade.Text;
                endereco.ESTADO = cbUF.SelectedItem.ToString();

                db.AddToENDERECO(endereco);
                cliente.ENDERECO = endereco;

                db.AddToCLIENTE(cliente);

                db.SaveChanges();

                MessageBox.Show("Cliente salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            
        }
    }
}
