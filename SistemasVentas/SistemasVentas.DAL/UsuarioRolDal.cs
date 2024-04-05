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
        public DataTable ListarUsuarioRolesDal()
        {
            string consulta = "\nSELECT     USUARIOROL.IDUSUARIOROL, USUARIO.NOMBREUSER, ROL.NOMBRE NOMBRE_ROL, USUARIOROL.FECHAASIGNA, USUARIOROL.ESTADO\nFROM        USUARIOROL INNER JOIN\n                  USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\n                  ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuarioRol values(" + usuarioRol.IdUsuario + "," +
                                                            "" + usuarioRol.IdRol + "," +
                                                           "'" + usuarioRol.FechaAsigna + "'," +
                                                           "'" + usuarioRol.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public UsuarioRol ObtenerUsuarioRolId(int id)
        {
            string consulta = "select * from usuariorol where idrol = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            UsuarioRol usuarioRol = new UsuarioRol();
            if (tabla.Rows.Count > 0)
            {
                usuarioRol.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idUsuarioRol"]);
                usuarioRol.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idUsuario"]);
                usuarioRol.IdRol = Convert.ToInt32(tabla.Rows[0]["idRol"]);
                usuarioRol.FechaAsigna = Convert.ToDateTime(tabla.Rows[0]["fechaAsigna"].ToString());
                usuarioRol.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return usuarioRol;
        }

        public void EditarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "update usuariorol set idUsuario =" + usuarioRol.IdUsuario + "," +
                                                    "idRol =" + usuarioRol.IdRol + "," +
                                                    "fechaAsigna ='" + usuarioRol.FechaAsigna + "'," +
                                                    "estado ='" + usuarioRol.Estado + "' " +
                                    "where idusuarioRol =" + usuarioRol.IdUsuarioRol;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
