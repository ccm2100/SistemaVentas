namespace CapaPresentacion
{
    partial class frmMovimientoInventario
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudcantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbotipomovimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.btnregistrar = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(252, 11);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(420, 320);
            this.label10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(264, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Movimiento de Inventario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.btnbuscarproducto);
            this.groupBox1.Controls.Add(this.txtcodigoproducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombreproducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudcantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbotipomovimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtobservacion);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Location = new System.Drawing.Point(270, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(310, 25);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(64, 20);
            this.txtidproducto.TabIndex = 0;
            this.txtidproducto.Visible = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 18;
            this.btnbuscarproducto.Location = new System.Drawing.Point(271, 20);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(33, 25);
            this.btnbuscarproducto.TabIndex = 1;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Location = new System.Drawing.Point(130, 25);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(140, 20);
            this.txtcodigoproducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Producto:";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(130, 60);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.ReadOnly = true;
            this.txtnombreproducto.Size = new System.Drawing.Size(200, 20);
            this.txtnombreproducto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto:";
            // 
            // nudcantidad
            // 
            this.nudcantidad.Location = new System.Drawing.Point(130, 95);
            this.nudcantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcantidad.Name = "nudcantidad";
            this.nudcantidad.Size = new System.Drawing.Size(120, 20);
            this.nudcantidad.TabIndex = 6;
            this.nudcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // cbotipomovimiento
            // 
            this.cbotipomovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipomovimiento.Location = new System.Drawing.Point(130, 130);
            this.cbotipomovimiento.Name = "cbotipomovimiento";
            this.cbotipomovimiento.Size = new System.Drawing.Size(200, 21);
            this.cbotipomovimiento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Movimiento:";
            // 
            // txtobservacion
            // 
            this.txtobservacion.Location = new System.Drawing.Point(20, 165);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(310, 40);
            this.txtobservacion.TabIndex = 10;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnregistrar.IconColor = System.Drawing.Color.White;
            this.btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrar.IconSize = 30;
            this.btnregistrar.Location = new System.Drawing.Point(132, 211);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(91, 30);
            this.btnregistrar.TabIndex = 11;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // frmMovimientoInventario
            // 
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frmMovimientoInventario";
            this.Text = "Movimiento de Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidproducto;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbotipomovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtobservacion;
        private FontAwesome.Sharp.IconButton btnregistrar;
    }
}