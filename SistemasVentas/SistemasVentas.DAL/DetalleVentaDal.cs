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
        public DataTable ListarDetallesVentaDal()
        {
            string consulta = "SELECT     DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, \n           DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO\nFROM        DETALLEVENTA INNER JOIN\n                  VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN\n                  PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                               "" + detalleVenta.IdProducto + "," +
                                                               "" + detalleVenta.Cantidad + "," +
                                                               "" + detalleVenta.PrecioVenta + "," +
                                                               "" + detalleVenta.SubTotal + "," +
                                                               "'" + detalleVenta.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta detalleVenta = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["idDetalleVenta"]);
                detalleVenta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                detalleVenta.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleVenta.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioVenta"].ToString());
                detalleVenta.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subTotal"].ToString());
                detalleVenta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleVenta;
        }

        public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "update detalleventa set idVenta =" + detalleVenta.IdVenta + "," +
                                                      "idProducto =" + detalleVenta.IdProducto + "," +
                                                      "cantidad =" + detalleVenta.Cantidad + "," +
                                                      "precioVenta =" + detalleVenta.PrecioVenta + "," +
                                                      "subtotal =" + detalleVenta.SubTotal + "," +
                                                      "estado ='" + detalleVenta.Estado + "' " +
                                    "where iddetalleventa =" + detalleVenta.IdDetalleVenta;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
