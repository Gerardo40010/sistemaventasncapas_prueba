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
    public class UsuarioBss
    {
        UsuarioDal dal = new UsuarioDal();
        public DataTable ListarUsuariosBass()
        {
            return dal.ListarUsuariosDal();
        }

        public void InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }

        public Usuario ObtenerUsuarioIdBss(int id)
        {
            return dal.ObtenerUsuarioId(id);
        }

        public void EditarUsuarioBss(Usuario usuario)
        {
            dal.EditarUsuarioDal(usuario);
        }

        public void EliminarUsuarioBss(int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}
