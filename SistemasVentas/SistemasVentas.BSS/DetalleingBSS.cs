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
    public class DetalleIngBss
    {
        DetalleIngDal dal = new DetalleIngDal();
        public DataTable ListarDetallesIngBass()
        {
            return dal.ListarDetallesIngDal();
        }

        public void InsertarDetalleIngBss(DetalleIng detalleIng)
        {
            dal.InsertarDetalleIngDal(detalleIng);
        }

        public DetalleIng ObtenerDetalleIngIdBss(int id)
        {
            return dal.ObtenerDetalleIngId(id);
        }

        public void EditarDetalleIngBss(DetalleIng detalleIng)
        {
            dal.EditarDetalleIngDal(detalleIng);
        }

        public void EliminarDetalleIngBss(int id)
        {
            dal.EliminarDetalleIngDal(id);
        }
    }
}
