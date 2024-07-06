using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;



namespace POSDesktop.Datos
{
    public static class ConexionMDB
    {
        private static string cadenaConexion = "Server=hassler.ec;Database=hasslere_sc_facturacion;Uid=hasslere_siscon;Pwd=Machala2022;";
        public static MySqlConnection ObtenerConexion() 
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;

        }

        public static void CerrarConexion(MySqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }


    }
}
