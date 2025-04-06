using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMovimientoInventario : Form
    {
        public frmMovimientoInventario()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.frmMovimientoInventario_Load);
        }

        private void frmMovimientoInventario_Load(object sender, EventArgs e)
        {
            cbotipomovimiento.Items.Add(new OpcionCombo() { Valor = "ENTRADA", Texto = "Entrada" });
            cbotipomovimiento.Items.Add(new OpcionCombo() { Valor = "SALIDA", Texto = "Salida" });
            cbotipomovimiento.Items.Add(new OpcionCombo() { Valor = "AJUSTE", Texto = "Ajuste" });
            cbotipomovimiento.DisplayMember = "Texto";
            cbotipomovimiento.ValueMember = "Valor";
            cbotipomovimiento.SelectedIndex = 0;

            txtobservacion.ForeColor = Color.Gray;
            txtobservacion.Text = "Observación (opcional)";
            txtobservacion.GotFocus += Txtobservacion_GotFocus;
            txtobservacion.LostFocus += Txtobservacion_LostFocus;
        }

        private void Txtobservacion_GotFocus(object sender, EventArgs e)
        {
            if (txtobservacion.Text == "Observación (opcional)")
            {
                txtobservacion.Text = "";
                txtobservacion.ForeColor = Color.Black;
            }
        }

        private void Txtobservacion_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtobservacion.Text))
            {
                txtobservacion.Text = "Observación (opcional)";
                txtobservacion.ForeColor = Color.Gray;
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodigoproducto.Text = modal._Producto.Codigo;
                    txtnombreproducto.Text = modal._Producto.Nombre;
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtidproducto.Text == "0" || txtidproducto.Text == "")
            {
                MessageBox.Show("Seleccione un producto válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudcantidad.Value == 0)
            {
                MessageBox.Show("Ingrese una cantidad válida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoMovimiento = ((OpcionCombo)cbotipomovimiento.SelectedItem).Valor.ToString();
            int idProducto = int.Parse(txtidproducto.Text);
            int cantidad = (int)nudcantidad.Value;
            string observacion = txtobservacion.Text.Trim() == "Observación (opcional)" ? "" : txtobservacion.Text.Trim();

            CN_Inventario cnInventario = new CN_Inventario();
            string mensaje = "";

            bool respuesta = cnInventario.RegistrarMovimiento(idProducto, tipoMovimiento, cantidad, observacion, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Movimiento registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidproducto.Text = "0";
                txtcodigoproducto.Text = "";
                txtnombreproducto.Text = "";
                nudcantidad.Value = 1;
                txtobservacion.Text = "Observación (opcional)";
                txtobservacion.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Error: " + mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
