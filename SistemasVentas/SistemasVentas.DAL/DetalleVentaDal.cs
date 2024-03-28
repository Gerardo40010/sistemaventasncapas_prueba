using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                        "" + detalleVenta.IdProducto + "," +
                                                        "" + detalleVenta.Cantidad + "," +
                                                        "" + detalleVenta.PrecioVenta + "," +
                                                        "" + detalleVenta.Subtotal + "," +
                                                        "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        public void EditarDetalleVentaDal(DetalleVenta d)
        {
            string consulta = "update detalleventa set idventa=" + d.IdVenta + "," +
                                                  "idproducto=" + d.IdProducto + "," +
                                                  "cantidad=" + d.Cantidad + "," +
                                                  "precioventa=" + d.PrecioVenta + "," +
                                                  "subtotal=" + d.Subtotal + "," +
                                              "where iddetalleventa=" + d.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
