namespace GRC
{
    partial class MenuPedido
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
            this.btnListarPedidos = new System.Windows.Forms.Button();
            this.btnCadastrarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPedidos
            // 
            this.btnListarPedidos.Location = new System.Drawing.Point(161, 195);
            this.btnListarPedidos.Name = "btnListarPedidos";
            this.btnListarPedidos.Size = new System.Drawing.Size(331, 68);
            this.btnListarPedidos.TabIndex = 8;
            this.btnListarPedidos.Text = "LISTAR PEDIDOS";
            this.btnListarPedidos.UseVisualStyleBackColor = true;
            this.btnListarPedidos.Click += new System.EventHandler(this.btnListarPedidos_Click);
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.Location = new System.Drawing.Point(161, 95);
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(331, 62);
            this.btnCadastrarPedido.TabIndex = 7;
            this.btnCadastrarPedido.Text = "CADASTRAR PEDIDO";
            this.btnCadastrarPedido.UseVisualStyleBackColor = true;
            this.btnCadastrarPedido.Click += new System.EventHandler(this.btnCadastrarPedido_Click);
            // 
            // MenuPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 395);
            this.Controls.Add(this.btnListarPedidos);
            this.Controls.Add(this.btnCadastrarPedido);
            this.Name = "MenuPedido";
            this.Text = "MenuPedido";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnListarPedidos;
        internal System.Windows.Forms.Button btnCadastrarPedido;
    }
}