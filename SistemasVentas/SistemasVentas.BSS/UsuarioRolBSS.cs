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
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol usuarioRol)
        {
            dal.InsertarUsuarioRolDal(usuarioRol);
        }
        public void EditarUsuarioRolBss(UsuarioRol u)
        {
            dal.EditarUsuarioRolDal(u);
        }
        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);

        }
    }
}
