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
    public class DetalleingBSS
    {
        DetalleingDAL dal = new DetalleingDAL();
        public DataTable ListarDetalleingBss()
        {
            return dal.ListarDetalleingDal();
        }

        public void InsertarDetalleingBss(Detalleing detalleing)
        {
            dal.InsertarDetalleingDAL(detalleing);
        }
        public Detalleing ObtenerDetalleIngIdBss(int id)
        {
            return dal.ObtenerDetalleIngIdDal(id);
        }
        public void EditarDetalleIngBss(Detalleing p)
        {
            dal.EditarDetalleIngDal(p);
        }
        public void EliminarDetalleIngBss(int id)
        {
            dal.EliminarDetalleIngDal(id);
        }
    }

}
