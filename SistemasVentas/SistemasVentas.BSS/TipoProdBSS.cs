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
    public class TipoProdBSS
    {
        TipoProdDAL dal = new TipoProdDAL();
        public DataTable ListarTipoProdBss()
        {
            return dal.ListarTipoProdDal();
        }
        public void InsertarTipoProdBss(TipoProd tipoprod)
        {
            dal.InsertarTipoProdDAL(tipoprod);
        }
        public TipoProd ObtenerTipoProdIdBss(int id)
        {
            return dal.ObtenerTipoProdIdDal(id);
        }

        public void EditarTipoProdBss(TipoProd t)
        {
            dal.EditarTipoProdDal(t);
        }

        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }
    }
}
