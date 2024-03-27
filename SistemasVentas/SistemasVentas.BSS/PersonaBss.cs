
using SistemasVentas.Modelos;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        { 
            return dal.ListarPersonasDal();
        }

        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDAL(persona);
        }
        public Persona ObtenerPersonaIdBss (int id)
        {
            return dal.ObtenerPersonaIdDal(id);
        }
         public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }

        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
