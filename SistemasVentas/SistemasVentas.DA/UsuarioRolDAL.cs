using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioRolDAL(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario+ "," +
                                                          "'" + usuarioRol.IdRol + "'," +
                                                          "'" + usuarioRol.FechaAsigna + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        UsuarioRol u = new UsuarioRol();
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {

                u.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                u.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                u.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                u.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                u.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return u;
        }
        public void EditarUsuarioRolDal(UsuarioRol p)
        {
            string consulta = "update usuariorol set idusuario=" + p.IdUsuario + "," +
                                                        "idrol=" + p.IdRol + "," +
                                                        "fechaasigna='" + p.FechaAsigna + "', " +
                                                        "estado='" + p.Estado + "' " +
                                                "where idusuariorol=" + p.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
