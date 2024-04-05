using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresosDal()
        {
            string consulta = "SELECT        INGRESO.IDINGRESO, PROVEEDOR.NOMBRE, INGRESO.FECHAINGRESO, INGRESO.TOTAL, INGRESO.ESTADO\nFROM            INGRESO INNER JOIN\n                         PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," +
                                                         "'" + ingreso.FechaIngreso + "'," +
                                                         "" + ingreso.Total+ "," +
                                                         "'" + ingreso.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Ingreso ObtenerIngresoId(int id)
        {
            string consulta = "select * from ingreso where idingreso = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Ingreso ingreso = new Ingreso();
            if (tabla.Rows.Count > 0)
            {
                ingreso.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idIngreso"]);
                ingreso.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idProveedor"]);
                ingreso.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaIngreso"]);
                ingreso.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                ingreso.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return ingreso;
        }

        public void EditarIngresoDal(Ingreso ingreso)
        {
            string consulta = "update ingreso set idProveedor =" + ingreso.IdProveedor + "," +
                                                 "fechaIngreso ='" + ingreso.FechaIngreso + "'," +
                                                 "total =" + ingreso.Total + "," +
                                                 "estado ='" + ingreso.Estado + "' " +
                                    "where idingreso =" + ingreso.IdIngreso;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
