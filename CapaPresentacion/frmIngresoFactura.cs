using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmIngresoFactura : Form
    {
        public frmIngresoFactura()
        {
            InitializeComponent();
        }
        private void btnConsultarSRI_Click(object sender, EventArgs e)
        {
            string numeroFactura = txtNumeroFactura.Text.Trim();
            string rucProveedor = txtRUCProveedor.Text.Trim();

            if (string.IsNullOrEmpty(numeroFactura) || string.IsNullOrEmpty(rucProveedor))
            {
                MessageBox.Show("Por favor ingresa el número de factura y el RUC del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🧪 Simulamos datos traídos del SRI (esto lo reemplazarías con lógica real)
            dgvDetalleFactura.Rows.Clear();

            dgvDetalleFactura.Rows.Add("P001", "Paracetamol 500mg", 2, 1.25m);
            dgvDetalleFactura.Rows.Add("P002", "Ibuprofeno 400mg", 1, 2.10m);
            dgvDetalleFactura.Rows.Add("P003", "Vitamina C", 3, 0.85m);

            txtDescuento.Text = "0.00";

            // Calculamos totales después de cargar los datos
            CalcularTotales();

            MessageBox.Show("Factura cargada correctamente desde SRI (modo simulación).", "Consulta SRI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Aquí irá la lógica para registrar los productos y stock
            MessageBox.Show("Productos registrados correctamente.");
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }


        private void dgvDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }

        private void dgvDetalleFactura_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
        }


        private void CalcularTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvDetalleFactura.Rows)
            {
                if (row.IsNewRow) continue;

                decimal cantidad = 0;
                decimal precio = 0;

                decimal.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);
                decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out precio);

                subtotal += cantidad * precio;
            }

            decimal iva = subtotal * 0.12m;

            decimal descuento = 0;
            decimal.TryParse(txtDescuento.Text, out descuento);

            decimal total = subtotal + iva - descuento;

            txtSubtotal.Text = subtotal.ToString("0.00");
            txtIVA.Text = iva.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }
    }
}
