using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDAL
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarTipoProdDAL(TipoProd tipoprod)
        {
            string consulta = "insert into TipoProd values('" + tipoprod.Nombre+ "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public TipoProd ObtenerTipoProdIdDal(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProd t= new TipoProd();
            if (tabla.Rows.Count > 0)
            {
                t.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                t.Nombre = tabla.Rows[0]["nombre"].ToString();
                t.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return t;

        }


        public void EditarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "update tipoprod set nombre='" + tipoProd.Nombre + "'" +
                                                          "where idtipoprod=" + tipoProd.IdTipoProd;
            conexion.Ejecutar(consulta);
        }

        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }

    }
}
