namespace GRC
{
    partial class CadastroPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtItems = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(398, 482);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(161, 51);
            this.btnEnviar.TabIndex = 55;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(363, 9);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(246, 27);
            this.Label8.TabIndex = 54;
            this.Label8.Text = "CADASTRO DE PEDIDO";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(946, 451);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(44, 21);
            this.lblTotalPedido.TabIndex = 57;
            this.lblTotalPedido.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cliente (Digite o CPF)";
            // 
            // dtItems
            // 
            this.dtItems.AllowUserToAddRows = false;
            this.dtItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Quantidade,
            this.Preco,
            this.Total,
            this.btnExcluir});
            this.dtItems.Location = new System.Drawing.Point(368, 123);
            this.dtItems.Name = "dtItems";
            this.dtItems.Size = new System.Drawing.Size(664, 312);
            this.dtItems.TabIndex = 61;
            this.dtItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtItems_CellContentClick);
            this.dtItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtItems_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo Produto";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Descricao";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preco Unit";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Total do pedido:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(41, 78);
            this.txtCPF.Mask = "009,009,009-09";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(183, 22);
            this.txtCPF.TabIndex = 63;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(241, 78);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCliente.TabIndex = 64;
            this.btnPesquisaCliente.Text = "Pesquisar";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(37, 123);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(206, 21);
            this.lblCliente.TabIndex = 65;
            this.lblCliente.Text = "Nenhum cliente selecionado";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(546, 82);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 67;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(368, 83);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(161, 22);
            this.txtCodigoProduto.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Código do Produto";
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.Label8);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastroPedido";
            this.Text = "Cadastro de Pedido";
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnEnviar;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblTotalPedido;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtItems;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnPesquisaCliente;
        internal System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
    }
}