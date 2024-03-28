using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + "," +
                                                        "" + producto.IdMarca + "," +
                                                        "'" + producto.Nombre+ "'," +
                                                        "'" + producto.CodigoBarra + "'," +
                                                        "" + producto.Unidad + "," +
                                                        "'" + producto.Descripcion + "'," +
                                                        "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Producto ObtenerProductoId(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto p = new Producto();

            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                p.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                p.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }
        public void EditarProductoDal(Producto p)
        {
            string consulta = "update producto set idtipoprod=" + p.IdTipoProd + "," +
                                                  "idmarca=" + p.IdMarca + "," +
                                                  "nombre='" + p.Nombre + "'," +
                                                  "codigobarra='" + p.CodigoBarra + "'," +
                                                  "unidad=" + p.Unidad + "," +
                                                  "descripcion='" + p.Descripcion + "'" +
                                              "where idproducto=" + p.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
