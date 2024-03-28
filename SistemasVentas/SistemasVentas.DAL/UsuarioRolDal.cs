using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuarioRol values(" + usuarioRol.IdUsuario + "," +
                                                        "" + usuarioRol.IdRol + "," +
                                                        "'" + usuarioRol.FechaAsigna.ToString("yyyy-MM-dd HH:mm:ss") + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public void EditarUsuarioRolDal(UsuarioRol u)
        {
            string consulta = "update usuariorol set idusuario=" + u.IdUsuario + "," +
                                                  "idrol=" + u.IdRol + "," +
                                                  "fechaasigna='" + u.FechaAsigna + "'" +
                                              "where idusuariorol=" + u.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
