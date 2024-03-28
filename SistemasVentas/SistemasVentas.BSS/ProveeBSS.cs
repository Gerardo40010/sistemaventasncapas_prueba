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
    public class ProveeBss
    {
        ProveeDal dal = new ProveeDal();
        public DataTable ListarProveeBss()
        {
            return dal.ListarProveeDal();
        }
        public void InsertarProveeBss(Provee provee)
        {
            dal.InsertarProveeDal(provee);
        }
        public Provee ObtenerIdBss(int id)
        {
            return dal.ObtenerProveeId(id);
        }
        public void EditarProveeBss(Provee p)
        {
            dal.EditarProveeDal(p);
        }
        public void EliminarProveeBss(int id)
        {
            dal.EliminarProveeDal(id);

        }
    }
}
