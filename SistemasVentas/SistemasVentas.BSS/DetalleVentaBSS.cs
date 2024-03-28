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
        public DataTable ListarDetalleVentaBss()
        {
            return dal.ListarDetalleVentaDal();
        }
        public void InsertarDetalleVentaBss(DetalleVenta detalleVenta)
        {
            dal.InsertarDetalleVentaDal(detalleVenta);
        }
        public void EditarDetalleVentaBss(DetalleVenta d)
        {
            dal.EditarDetalleVentaDal(d);
        }
        public void EliminarDetalleVentaBss(int id)
        {
            dal.EliminarDetalleVentaDal(id);

        }
    }
}
