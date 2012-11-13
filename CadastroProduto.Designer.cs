namespace GRC
{
    partial class CadastroProduto
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(155, 300);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 23);
            this.btnEnviar.TabIndex = 47;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(172, 59);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(393, 34);
            this.Label8.TabIndex = 46;
            this.Label8.Text = "CADASTRO DE PRODUTOS";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(233, 256);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(160, 20);
            this.txtValor.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(152, 263);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "VALOR :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(152, 227);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "DESCRIÇÃO :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(233, 220);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(349, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "CODIGO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(233, 185);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 492);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtDescricao);
            this.Name = "CadastroProduto";
            this.Text = "TELA9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnEnviar;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtCodigo;
    }
}