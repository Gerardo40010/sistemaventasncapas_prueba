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
    public class DetalleVentaBss
    {
        DetalleVentaDal dal = new DetalleVentaDal();
        public DataTable ListarDetallesVentaBass()
        {
            return dal.ListarDetallesVentaDal();
        }

        public void InsertarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.InsertarDetalleVentaDal(detalleVenta);
        }

        public DetalleVenta ObtenerDetalleVentaIdBss(int id)
        {
            return dal.ObtenerDetalleVentaId(id);
        }

        public void EditarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.EditarDetalleVentaDal(detalleVenta);
        }

        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);
        }
    }
}
