using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashDB.Clases
{
    internal class CConnection
    {
        MySqlConnection connectionObj = new MySqlConnection();
        static string servidor = "localhost"; //si el servidor está en otro equipo se sustituye por la IP
        static string bd = "crashbandicootdb";
        static string usuario = "userBandicoot";
        static string password = "WoombaFruit5";
        static string puerto = "3306";

        string conexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection connectToDB()
        {
            try
            {
                connectionObj.ConnectionString = conexion;
                connectionObj.Open();
                MessageBox.Show("Conexión a la base de datos exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos:" + ex.Message);
            }
            return connectionObj;
        }
        public void cerrarConexion()
        {
            connectionObj.Close();
        }

    }
}
