using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemasVentas.DAL
{
    public class Conexion
    {
        public static string CONECTAR
        {
            get { return @"Data Source=DESKTOP-H3MALBM\MSSQLSERVER01; Initial Catalog=TIENDABDZ; Integrated Security=True; TrustServerCertificate=true;"; }
            //get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
        }
        public static DataSet EjecutarDataSet(string consulta)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "TABLA");
            return ds;
        }

        public static void Ejecutar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            cmd.ExecuteNonQuery();
        }

        public static int EjecutarEscalar(string consulta)
        {
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            conectar.Open();

            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            int dev = Convert.ToInt32(cmd.ExecuteScalar());
            return dev;
        }
        public static DataTable EjecutarDataTabla(string consulta, string tabla)
        {
            string p = Conexion.CONECTAR;
            SqlConnection conectar = new SqlConnection(Conexion.CONECTAR);
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            cmd.CommandTimeout = 5000;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable(tabla);
            da.Fill(dt);
            return dt;
        }

        public static bool ValidarCredenciales(string NOMBREUSER, string CONTRASEÑA)
        {
            string consulta = "SELECT COUNT(*) FROM USUARIO WHERE NOMBREUSER = @NOMBREUSER AND CONTRASEÑA = @CONTRASEÑA";

            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conectar))
                {
                    cmd.Parameters.AddWithValue("@NOMBREUSER", NOMBREUSER);
                    cmd.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA);

                    conectar.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static bool VerificadorCredenciales(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(1) FROM usuario U INNER JOIN USUARIOROL UR ON U.IDUSUARIO = UR.IDUSUARIO WHERE U.nombreuser = @Usuario AND U.contraseña = @Contraseña AND UR.IDROL = (SELECT IDROL FROM ROL WHERE NOMBRE = 'gerente')";
            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }
        public static bool VerificadorCredenciales2(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(1) FROM usuario U INNER JOIN USUARIOROL UR ON U.IDUSUARIO = UR.IDUSUARIO WHERE U.nombreuser = @Usuario AND U.contraseña = @Contraseña AND UR.IDROL IN (SELECT IDROL FROM ROL WHERE NOMBRE IN ('cajero', 'vendedor'))";
            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }
        public static bool VerificadorCredenciales3(string usuario, string contraseña)
        {
            string consulta = "SELECT COUNT(1) FROM usuario U INNER JOIN USUARIOROL UR ON U.IDUSUARIO = UR.IDUSUARIO WHERE U.nombreuser = @Usuario AND U.contraseña = @Contraseña AND UR.IDROL IN (SELECT IDROL FROM ROL WHERE NOMBRE IN ('guia', 'cliente'))";
            using (SqlConnection conectar = new SqlConnection(CONECTAR))
            {
                conectar.Open();
                SqlCommand cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }

        public string AutenticarUsuario(string usuario, string contraseña)
        {
            string cargo = null;

            using (SqlConnection connection = new SqlConnection(CONECTAR))
            {
                string query = "SELECT r.NOMBRE " +
                               "FROM USUARIO u " +
                               "INNER JOIN USUARIOROL ur ON u.IDUSUARIO = ur.IDUSUARIO " +
                               "INNER JOIN ROL r ON ur.IDROL = r.IDROL " +
                               "WHERE NOMBREUSER = @Usuario AND CONTRASEÑA = @Contraseña";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        cargo = reader["NOMBRE"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al autenticar usuario: " + ex.Message);
                }
            }

            return cargo;
        }
    }
}