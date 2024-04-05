using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolesDal()
        {
            string consulta = "select * from rol";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," +
                                                     "'" + rol.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Rol ObtenerRolId(int id)
        {
            string consulta = "select * from rol where idrol = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Rol rol = new Rol();
            if (tabla.Rows.Count > 0)
            {
                rol.IdRol = Convert.ToInt32(tabla.Rows[0]["idRol"]);
                rol.Nombre = tabla.Rows[0]["nombre"].ToString();
                rol.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return rol;
        }

        public void EditarRolDal(Rol rol)
        {
            string consulta = "update rol set nombre ='" + rol.Nombre + "'," +
                                             "estado ='" + rol.Estado + "' " +
                                    "where idrol =" + rol.IdRol;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarRolDal(int id)
        {
            string consulta = "delete from rol where idrol =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
