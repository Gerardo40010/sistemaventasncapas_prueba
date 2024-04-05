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
        public DataTable ListarMarcasBass()
        {
            return dal.ListarMarcasDal();
        }

        public void InsertarMarcaBss(Marca marca)
        {
            dal.InsertarMarcaDal(marca);
        }

        public Marca ObtenerMarcaIdBss(int id)
        {
            return dal.ObtenerMarcaId(id);
        }

        public void EditarMarcaBss(Marca marca)
        {
            dal.EditarMarcaDal(marca);
        }

        public void EliminarMarcaBss(int id)
        {
            dal.EliminarMarcaDal(id);
        }
    }
}
