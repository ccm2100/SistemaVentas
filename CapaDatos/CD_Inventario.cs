using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Inventario
    {
        public bool RegistrarMovimiento(int idProducto, string tipoMovimiento, int cantidad, string observacion, out string mensaje)
        {
            bool resultado = false;
            mensaje = "";

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO MOVIMIENTO_INVENTARIO (IdProducto, TipoMovimiento, Cantidad, Observacion) VALUES (@IdProducto, @TipoMovimiento, @Cantidad, @Observacion)", con))
                    {
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@TipoMovimiento", tipoMovimiento);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Observacion", observacion);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                resultado = false;
            }

            return resultado;
        }
    }
}
