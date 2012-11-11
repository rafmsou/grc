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
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GRCEntities db = new GRCEntities();
            try
            {
                var cpf = Convert.ToInt64(txtCPF.Text.Replace(".", "").Replace("-", ""));

                var resultado = from cliente in db.CLIENTE
                                where cliente.CPF == cpf
                                select new { 
                                    Nome = cliente.NOME,
                                    CPF = cliente.CPF,
                                    Telefone = cliente.TELEFONE,
                                    Email = cliente.EMAIL,
                                    Endereco = cliente.ENDERECO.LOGRADOURO
                                };

                dtGrdClientes.DataSource = resultado;

            }
            catch (Exception)
            {
                MessageBox.Show("CPF inválido.");  
            }
        }
    }
}
