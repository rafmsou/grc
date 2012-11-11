namespace GRC
{
    partial class Produto
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
            this.btnListaProduto = new System.Windows.Forms.Button();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListaProduto
            // 
            this.btnListaProduto.Location = new System.Drawing.Point(21, 215);
            this.btnListaProduto.Name = "btnListaProduto";
            this.btnListaProduto.Size = new System.Drawing.Size(331, 68);
            this.btnListaProduto.TabIndex = 9;
            this.btnListaProduto.Text = "LISTA DE PRODUTO";
            this.btnListaProduto.UseVisualStyleBackColor = true;
            this.btnListaProduto.Click += new System.EventHandler(this.btnListaProduto_Click);
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Location = new System.Drawing.Point(21, 115);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(331, 62);
            this.btnCadastraProduto.TabIndex = 8;
            this.btnCadastraProduto.Text = "CADASTRAR PRODUTO";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(213, 50);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "PRODUTO";
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 512);
            this.Controls.Add(this.btnListaProduto);
            this.Controls.Add(this.btnCadastraProduto);
            this.Controls.Add(this.Label1);
            this.Name = "Produto";
            this.Text = "TELA8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnListaProduto;
        internal System.Windows.Forms.Button btnCadastraProduto;
        internal System.Windows.Forms.Label Label1;
    }
}