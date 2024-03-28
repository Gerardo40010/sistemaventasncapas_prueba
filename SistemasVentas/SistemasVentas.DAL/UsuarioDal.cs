using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + "," +
                                                        "'" + usuario.NombreUser + "'," +
                                                        "'" + usuario.Contraseña + "'," +
                                                        "'" + usuario.FechaReg+ "')";
            conexion.Ejecutar(consulta);
        }
       
        public Usuario ObtenerUsuarioId(int id)
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario u = new Usuario();

            if (tabla.Rows.Count > 0)
            {
                u.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                u.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                u.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                u.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                u.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);            
            }
            return u;

        }
        public void EditarUsuarioDal(Usuario u)
        {
            string consulta = "update usuario set idpersona=" + u.IdPersona + "," +
                                                  "nombreuser='" + u.NombreUser + "'," +
                                                  "contraseña='" + u.Contraseña + "'," +
                                                  "fechareg='" + u.FechaReg + "'" +                            
                                          "where idusuario=" + u.IdUsuario;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
