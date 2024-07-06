using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace POSDesktop.Datos
{
    public static class Conexion
    {
        private static string cadenaConexion = "Server=localhost; Database=siscoad; Integrated Security = True;";

        public static SqlConnection ConectarDB()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;

        }


        public static void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();    
            }
        }
    }
}
