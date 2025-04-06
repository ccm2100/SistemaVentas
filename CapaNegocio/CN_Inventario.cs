using CapaDatos;

namespace CapaNegocio
{
    public class CN_Inventario
    {
        private CD_Inventario objDatos = new CD_Inventario();

        public bool RegistrarMovimiento(int idProducto, string tipoMovimiento, int cantidad, string observacion, out string mensaje)
        {
            return objDatos.RegistrarMovimiento(idProducto, tipoMovimiento, cantidad, observacion, out mensaje);
        }
    }
}
