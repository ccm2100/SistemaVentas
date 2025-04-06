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
    public partial class frmControlLotesV : Form
    {
        public frmControlLotesV()
        {
            InitializeComponent();
        }

        private void btnRegistrarLotes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvLotes.Rows)
            {
                if (row.IsNewRow) continue;

                string codigo = row.Cells["colCodigoProducto"]?.Value?.ToString();
                string lote = row.Cells["colLote"]?.Value?.ToString();
                string fechaVto = row.Cells["colFechaVencimiento"]?.Value?.ToString();
                string cantidad = row.Cells["colCantidadLote"]?.Value?.ToString();

                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(lote) ||
                    string.IsNullOrWhiteSpace(fechaVto) || string.IsNullOrWhiteSpace(cantidad))
                {
                    MessageBox.Show("Completa todos los campos antes de registrar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aquí iría tu lógica para guardar en base de datos o enviar a la API.
                Console.WriteLine($"Registrando: {codigo} | {lote} | {fechaVto} | {cantidad}");
            }

            MessageBox.Show("Lotes registrados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            string numeroFactura = txtNumeroFactura.Text.Trim();
            if (string.IsNullOrEmpty(numeroFactura))
            {
                MessageBox.Show("Ingrese un número de factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simulación de productos cargados por número de factura
            List<(string codigo, string descripcion)> productosFactura = new List<(string, string)>
                {
                    ("P001", "Paracetamol 500mg"),
                    ("P002", "Ibuprofeno 400mg"),
                    ("P003", "Amoxicilina 500mg")
                };

            foreach (var producto in productosFactura)
            {
                dgvLotes.Rows.Add(producto.codigo, "", "", ""); // Solo el código, los demás campos a llenar
            }

            MessageBox.Show("Productos cargados. Completa los datos de lote, vencimiento y cantidad.", "Factura encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
