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
    public class MarcaBSS
    {
        MarcaDAL dal = new MarcaDAL();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
        public void InsertarMarcaBss(Marca marca)
        {
            dal.InsertarMarcaDAL(marca);
        }

        public Marca ObtenerMarcaIdBss(int id)
        {
            return dal.ObtenerMarcaIdDal(id);
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
