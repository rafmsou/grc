namespace GRC
{
    partial class ListaPedido
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
            this.Label8 = new System.Windows.Forms.Label();
            this.dgListaPedido = new System.Windows.Forms.DataGridView();
            this.listItems = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(34, 23);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(293, 50);
            this.Label8.TabIndex = 54;
            this.Label8.Text = "LISTA PEDIDO";
            // 
            // dgListaPedido
            // 
            this.dgListaPedido.AllowUserToAddRows = false;
            this.dgListaPedido.AllowUserToDeleteRows = false;
            this.dgListaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPedido.Location = new System.Drawing.Point(31, 92);
            this.dgListaPedido.Name = "dgListaPedido";
            this.dgListaPedido.ReadOnly = true;
            this.dgListaPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaPedido.Size = new System.Drawing.Size(515, 409);
            this.dgListaPedido.TabIndex = 56;
            this.dgListaPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaPedido_CellClick);
            // 
            // listItems
            // 
            this.listItems.Location = new System.Drawing.Point(581, 137);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(333, 244);
            this.listItems.TabIndex = 57;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Itens";
            // 
            // ListaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.dgListaPedido);
            this.Controls.Add(this.Label8);
            this.Name = "ListaPedido";
            this.Text = "Lista Pedido";
            this.Load += new System.EventHandler(this.ListaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.DataGridView dgListaPedido;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.Label label1;
    }
}