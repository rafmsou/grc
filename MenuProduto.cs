﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRC
{
    public partial class MenuProduto : Form
    {
        public MenuProduto()
        {
            InitializeComponent();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            new CadastroProduto().ShowDialog();
        }

        private void btnListaProduto_Click(object sender, EventArgs e)
        {
            new ListaProduto().ShowDialog();
        }
    }
}
