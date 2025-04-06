namespace CapaPresentacion
{
    partial class frmControlLotesV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.colCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarLotes = new System.Windows.Forms.Button();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.btnBuscarFactura = new System.Windows.Forms.Button();

            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.SuspendLayout();

            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.dgvLotes);
            this.panelContainer.Controls.Add(this.btnRegistrarLotes);
            this.panelContainer.Controls.Add(this.txtNumeroFactura);
            this.panelContainer.Controls.Add(this.btnBuscarFactura);
            this.panelContainer.Location = new System.Drawing.Point(20, 20);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(900, 450);
            this.panelContainer.TabIndex = 1;

            // 
            // dgvLotes
            // 
            this.dgvLotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCodigoProducto,
                this.colLote,
                this.colFechaVencimiento,
                this.colCantidadLote});
            this.dgvLotes.Location = new System.Drawing.Point(20, 20);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.Size = new System.Drawing.Size(850, 300);
            this.dgvLotes.TabIndex = 0;

            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.HeaderText = "Código Producto";
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.Width = 200;

            // 
            // colLote
            // 
            this.colLote.HeaderText = "Lote";
            this.colLote.Name = "colLote";
            this.colLote.Width = 200;

            // 
            // colFechaVencimiento
            // 
            this.colFechaVencimiento.HeaderText = "Fecha Vencimiento";
            this.colFechaVencimiento.Name = "colFechaVencimiento";
            this.colFechaVencimiento.Width = 250;

            // 
            // colCantidadLote
            // 
            this.colCantidadLote.HeaderText = "Cantidad";
            this.colCantidadLote.Name = "colCantidadLote";
            this.colCantidadLote.Width = 150;

            // 
            // btnRegistrarLotes
            // 
            this.btnRegistrarLotes.Location = new System.Drawing.Point(770, 330);
            this.btnRegistrarLotes.Name = "btnRegistrarLotes";
            this.btnRegistrarLotes.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrarLotes.TabIndex = 1;
            this.btnRegistrarLotes.Text = "Registrar Lotes";
            this.btnRegistrarLotes.UseVisualStyleBackColor = true;
            this.btnRegistrarLotes.Click += new System.EventHandler(this.btnRegistrarLotes_Click);

            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(20, 340);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroFactura.TabIndex = 2;

            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Location = new System.Drawing.Point(230, 338);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarFactura.TabIndex = 3;
            this.btnBuscarFactura.Text = "Buscar Factura";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);

            // 
            // frmControlLotesV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 490);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmControlLotesV";
            this.Text = "Ingreso de Lotes";

            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadLote;
        private System.Windows.Forms.Button btnRegistrarLotes;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Button btnBuscarFactura;
    }
}
