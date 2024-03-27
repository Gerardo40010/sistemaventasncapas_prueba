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
    public class ProveeBSS
    {
        ProveeDAL dal = new ProveeDAL();
        public DataTable ListarProveeBss()
        {
            return dal.ListarProveeDal();
        }
        public void InsertarProveeBss(Provee provee)
        {
            dal.InsertarProveeDAL(provee);
        }
        public Provee ObtenerProveeIdBss(int id)
        {
            return dal.ObtenerProveeIdDal(id);
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
