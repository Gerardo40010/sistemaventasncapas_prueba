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
    public class TipoProdBss
    {
        TipoProdDal dal = new TipoProdDal();
        public DataTable ListarTipoProdsBass()
        {
            return dal.ListarTipoProdsDal();
        }

        public void InsertarTipoProdBss(TipoProd tipoProd)
        {
            dal.InsertarTipoProdDal(tipoProd);
        }

        public TipoProd ObtenerTipoProdIdBss(int id)
        {
            return dal.ObtenerTipoProdId(id);
        }

        public void EditarTipoProdBss(TipoProd tipoProd)
        {
            dal.EditarTipoProdDal(tipoProd);
        }

        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProdDal(id);
        }
    }
}
