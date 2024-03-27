using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDAL
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarIngresoDAL(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," +
                                                          "'" + ingreso.FechaIngreso + "'," +
                                                          "'" + ingreso.Total + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Ingreso ObtenerIngresoIdDal(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Ingreso i = new Ingreso();
            if (tabla.Rows.Count > 0)
            {
                i.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                i.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                i.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                i.Total = Convert.ToInt32(tabla.Rows[0]["total"]);
                i.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return i;

        }
        public void EditarIngresoDal(Ingreso p)
        {
            string consulta = "update ingreso set idproveedor=" + p.IdProveedor + "," +
                                                        "fechaingreso='" + p.FechaIngreso + "'," +
                                                        "total=" + p.Total + "," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idingreso=" + p.IdIngreso;
            conexion.Ejecutar(consulta);
        }
        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
