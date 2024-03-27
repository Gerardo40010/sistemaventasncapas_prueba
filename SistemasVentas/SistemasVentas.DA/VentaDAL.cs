using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarVentaDAL(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                          "" + venta.IdVendedor + "," +
                                                          "'" + venta.Fecha + "'," +
                                                          "'" + venta.Total + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }

        public Venta ObtenerVentaIdDal(int id)
        {
            string consulta = "select * from venta where idventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Venta v= new Venta();
            if (tabla.Rows.Count > 0)
            {
                v.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                v.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                v.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                v.Total = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                v.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return v;

        }
        public void EditarVentaDal(Venta v)
        {
            string consulta = "update venta set idcliente=" + v.IdCliente + "," +
                                                        "idvendedor=" + v.IdVendedor + "," +
                                                        "fecha='" + v.Fecha + "', " +
                                                        "total=" + v.Total + "," +
                                                        "estado='" + v.Estado + "' " +
                                                "where idventa=" + v.IdVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
