using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveesDal()
        {
            string consulta = "SELECT        PROVEE.IDPROVEE, PRODUCTO.NOMBRE AS NOMBRE_PRODUCTO, PROVEEDOR.NOMBRE AS NOMBRE_PROVEEDOR, PROVEE.FECHA, PROVEE.PRECIO\nFROM            PROVEE INNER JOIN\n                         PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\n                         PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + "," +
                                                        "" + provee.IdProveedor + "," +
                                                        "'" + provee.Fecha + "'," +
                                                        "" + provee.Precio + ")";
            Conexion.Ejecutar(consulta);
        }

        public Provee ObtenerProveeId(int id)
        {
            string consulta = "select * from provee where idprovee = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Provee provee = new Provee();
            if (tabla.Rows.Count > 0)
            {
                provee.IdProvee = Convert.ToInt32(tabla.Rows[0]["idProvee"]);
                provee.IdProducto = Convert.ToInt32(tabla.Rows[0]["idProducto"]);
                provee.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idProveedor"]);
                provee.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                provee.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
            }
            return provee;
        }

        public void EditarProveeDal(Provee provee)
        {
            string consulta = "update provee set idProducto =" + provee.IdProducto + "," +
                                                 "idProveedor =" + provee.IdProveedor + "," +
                                                 "fecha ='" + provee.Fecha + "'," +
                                                 "precio ='" + provee.Precio + "' " +
                                    "where idprovee=" + provee.IdProvee;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarProveeDal(int id)
        {
            string consulta = "delete from provee where idprovee =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
