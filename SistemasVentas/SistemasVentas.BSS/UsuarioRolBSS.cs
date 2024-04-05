using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListarUsuarioRolesBass()
        {
            return dal.ListarUsuarioRolesDal();
        }

        public void InsertarUsuarioRolBss(UsuarioRol usuarioRol)
        {
            dal.InsertarUsuarioRolDal(usuarioRol);
        }

        public UsuarioRol ObtenerUsuarioRolIdBss(int id)
        {
            return dal.ObtenerUsuarioRolId(id);
        }

        public void EditarUsuarioRolBss(UsuarioRol usuarioRol)
        {
            dal.EditarUsuarioRolDal(usuarioRol);
        }

        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }
    }
}
