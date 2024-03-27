using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleingDAL
    {
        public DataTable ListarDetalleingDal()
        {
            string consulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarDetalleingDAL(Detalleing detalleing)
        {
            string consulta = "insert into detalleing values(" + detalleing.IdIngreso + "," +
                                                          "" + detalleing.IdProducto + "," +
                                                          "'" + detalleing.FechaVenc + "'," +
                                                          "'" + detalleing.Cantidad + "'," +
                                                          "'" + detalleing.PrecioCosto + "'," +
                                                          "'" + detalleing.PrecioVenta + "'," +
                                                          "'" + detalleing.SubTotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        Detalleing p = new Detalleing();
        public Detalleing ObtenerDetalleIngIdDal(int id)
        {
            string consulta = "select * from detalleing where iddetalleing=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdDetalleing = Convert.ToInt32(tabla.Rows[0]["iddetalleing"]);
                p.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechavenc"]);
                p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                p.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["preciocosto"]);
                p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                p.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarDetalleIngDal(Detalleing p)
        {
            string consulta = "update detalleing set idingreso=" + p.IdIngreso + "," +
                                                        "idproducto=" + p.IdProducto + "," +
                                                        "fechavenc='" + p.FechaVenc + "'," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "preciocosto=" + p.PrecioCosto + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "subtotal=" + p.SubTotal + " " +
                                                "where iddetalleing=" + p.IdDetalleing;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "delete from detalleing where iddetalleing=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
