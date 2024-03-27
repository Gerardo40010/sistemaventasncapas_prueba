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
     public class UsuarioRolBSS
    {
        UsuarioRolDAL dal = new UsuarioRolDAL();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol usuarioRol)
        {
            dal.InsertarUsuarioRolDAL(usuarioRol);
        }
        public UsuarioRol ObtenerUsuarioRolIdBss(int id)
        {
            return dal.ObtenerUsuarioRolIdDal(id);
        }
        public void EditarUsuarioRolBss(UsuarioRol p)
        {
            dal.EditarUsuarioRolDal(p);
        }
        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }
    }
}
