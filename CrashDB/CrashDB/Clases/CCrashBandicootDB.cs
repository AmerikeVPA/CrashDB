using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrashDB.Clases
{
    internal class CCrashBandicootDB
    {
        CConnection connectionObj = new CConnection();
        public void ShowPlayers(DataGridView crashTable)
        {
            try
            {
                string query = "SELECT * FROM player";
                crashTable.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionObj.connectToDB());
                DataTable DT = new DataTable();
                adapter.Fill(DT);
                crashTable.DataSource = DT;

            }
            catch (Exception ex)
            {

            }
        }

        public void AddPlayer(TextBox playerName, DateTimePicker lastConnection)
        {
            try
            {
                string formatForMySql = lastConnection.Value.ToString("yyyy-MM-dd HH:mm");
                string query = "INSERT INTO player (Nickname, LastConnection) " +
                    $"values ('{playerName.Text}', '{formatForMySql}');";
                MySqlCommand myCommand = new MySqlCommand(query, connectionObj.connectToDB());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Datos insertados correctamente");
                connectionObj.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }

        public void UpdatePlayer(TextBox playerName, DateTimePicker lastConnection)
        {
            try
            {
                string formatForMySql = lastConnection.Value.ToString("yyyy-MM-dd HH:mm");
                string query = "UPDATE player " +
                    $"SET Nickname = '{playerName.Text}', LastConnection = '{formatForMySql}'" +
                    $"WHERE Nickname = '{playerName.Text}';";
                MySqlCommand myCommand = new MySqlCommand(query, connectionObj.connectToDB());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Datos insertados correctamente");
                connectionObj.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }

    }
}
