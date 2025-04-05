namespace CapaPresentacion
{
    partial class frmIngresoFactura
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRUCProveedor;
        private System.Windows.Forms.Button btnConsultarSRI;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRUCProveedor = new System.Windows.Forms.TextBox();
            this.btnConsultarSRI = new System.Windows.Forms.Button();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.labelIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.txtNumeroFactura);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.txtRUCProveedor);
            this.panelContainer.Controls.Add(this.btnConsultarSRI);
            this.panelContainer.Controls.Add(this.dgvDetalleFactura);
            this.panelContainer.Controls.Add(this.labelSubtotal);
            this.panelContainer.Controls.Add(this.txtSubtotal);
            this.panelContainer.Controls.Add(this.labelIVA);
            this.panelContainer.Controls.Add(this.txtIVA);
            this.panelContainer.Controls.Add(this.labelDescuento);
            this.panelContainer.Controls.Add(this.txtDescuento);
            this.panelContainer.Controls.Add(this.labelTotal);
            this.panelContainer.Controls.Add(this.txtTotal);
            this.panelContainer.Controls.Add(this.btnRegistrar);
            this.panelContainer.Location = new System.Drawing.Point(50, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(900, 409);
            this.panelContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(150, 17);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(150, 20);
            this.txtNumeroFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(320, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "RUC Proveedor:";
            // 
            // txtRUCProveedor
            // 
            this.txtRUCProveedor.Location = new System.Drawing.Point(420, 17);
            this.txtRUCProveedor.Name = "txtRUCProveedor";
            this.txtRUCProveedor.Size = new System.Drawing.Size(150, 20);
            this.txtRUCProveedor.TabIndex = 3;
            // 
            // btnConsultarSRI
            // 
            this.btnConsultarSRI.Location = new System.Drawing.Point(600, 15);
            this.btnConsultarSRI.Name = "btnConsultarSRI";
            this.btnConsultarSRI.Size = new System.Drawing.Size(150, 23);
            this.btnConsultarSRI.TabIndex = 4;
            this.btnConsultarSRI.Text = "Consultar SRI";
            this.btnConsultarSRI.Click += new System.EventHandler(this.btnConsultarSRI_Click);
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDetalleFactura.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(20, 46);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(850, 250);
            this.dgvDetalleFactura.TabIndex = 5;
            this.dgvDetalleFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleFactura_CellValueChanged);
            this.dgvDetalleFactura.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalleFactura_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Name = "Cantidad"; // <-- este nombre debe existir

            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Name = "Precio"; // <-- asegúrate de que se llame Precio

            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Location = new System.Drawing.Point(20, 330);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(74, 23);
            this.labelSubtotal.TabIndex = 6;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(100, 327);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            // 
            // labelIVA
            // 
            this.labelIVA.Location = new System.Drawing.Point(220, 330);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(44, 23);
            this.labelIVA.TabIndex = 8;
            this.labelIVA.Text = "IVA:";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(270, 327);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 9;
            // 
            // labelDescuento
            // 
            this.labelDescuento.Location = new System.Drawing.Point(380, 330);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(74, 23);
            this.labelDescuento.TabIndex = 10;
            this.labelDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(460, 327);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(580, 330);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 23);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(630, 327);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 370);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmIngresoFactura
            // 
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmIngresoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Factura";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
