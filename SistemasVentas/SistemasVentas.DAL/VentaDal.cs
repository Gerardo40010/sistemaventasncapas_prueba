using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentasDal()
        {
            string consulta = "SELECT     VENTA.IDVENTA, VENTA.IDCLIENTE, USUARIO.NOMBREUSER NOMBRE_VENDEDOR, \n           VENTA.FECHA, VENTA.TOTAL, VENTA.ESTADO\nFROM        VENTA INNER JOIN\n                  USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                       "" + venta.IdVendedor + "," +
                                                      "'" + venta.Fecha + "'," +
                                                       "" + venta.Total + "," +
                                                      "'" + venta.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Venta ObtenerVentaId(int id)
        {
            string consulta = "select * from venta where idventa = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Venta venta = new Venta();
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idVenta"]);
                venta.IdCliente = Convert.ToInt32(tabla.Rows[0]["idCliente"]);
                venta.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idVendedor"]);
                venta.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                venta.Total = Convert.ToDecimal(tabla.Rows[0]["total"].ToString());
                venta.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return venta;
        }

        public void EditarVentaDal(Venta venta)
        {
            string consulta = "update venta set idcliente =" + venta.IdCliente + "," +
                                               "idVendedor =" + venta.IdVendedor+ "," +
                                               "fecha ='" + venta.Fecha + "'," +
                                               "total =" + venta.Total + "," +
                                               "estado ='" + venta.Estado + "'" +
                                    "where idventa =" + venta.IdVenta;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
