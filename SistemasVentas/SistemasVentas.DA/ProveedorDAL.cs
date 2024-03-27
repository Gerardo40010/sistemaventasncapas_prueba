using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDAL
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveedorDAL(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                            "'" + proveedor.Telefono + "'," +
                                                            "'" + proveedor.Direccion + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Proveedor ObtenerProveedorIdDal(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor P = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                P.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                P.Nombre = tabla.Rows[0]["nombre"].ToString();
                P.Telefono = tabla.Rows[0]["telefono"].ToString();
                P.Direccion = tabla.Rows[0]["direccion"].ToString();
                P.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return P;
        }


        public void EditarProveedorDal(Proveedor proveedor)
        {
            string consulta = "update proveedor set nombre='" + proveedor.Nombre + "'," +
                                                        "telefono='" + proveedor.Telefono + "'," +
                                                        "direccion='" + proveedor.Direccion + "'" +
                                                        "where idproveedor=" + proveedor.IdProveedor;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }

    }
}
