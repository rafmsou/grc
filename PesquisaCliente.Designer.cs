namespace GRC
{
    partial class PesquisaCliente
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtGrdClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(38, 155);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(232, 37);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(35, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(428, 50);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "PESQUISAR CLIENTE";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(74, 106);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(196, 20);
            this.txtCPF.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "CPF :";
            // 
            // dtGrdClientes
            // 
            this.dtGrdClientes.AllowUserToAddRows = false;
            this.dtGrdClientes.AllowUserToDeleteRows = false;
            this.dtGrdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdClientes.Location = new System.Drawing.Point(38, 211);
            this.dtGrdClientes.Name = "dtGrdClientes";
            this.dtGrdClientes.ReadOnly = true;
            this.dtGrdClientes.Size = new System.Drawing.Size(649, 275);
            this.dtGrdClientes.TabIndex = 18;
            // 
            // PesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 498);
            this.Controls.Add(this.dtGrdClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.Label2);
            this.Name = "PesquisaCliente";
            this.Text = "TELA4";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCPF;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView dtGrdClientes;

    }
}