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
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
        public void InsertarMarcaBss(Marca marca)
        {
            dal.InsertarMarcaDal(marca);
        }
        public Marca ObtenerIdBss(int id)
        {
            return dal.ObtenerMarcaId(id);
        }
        public void EditarMarcaBss(Marca m)
        {
            dal.EditarMarcaDal(m);
        }
        public void EliminarMarcaBss(int id)
        {
            dal.EliminarMarcaDal(id);

        }
    }
}
