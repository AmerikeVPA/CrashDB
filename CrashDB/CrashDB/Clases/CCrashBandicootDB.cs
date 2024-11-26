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
        public void ShowPlayers(DataGridView crashTable)
        {
            try
            {
                CConnection connectionObj = new CConnection();
                string query = "SELECT * FROM pet";
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

        public void AddPlayer(TextBox nombre,/* NumericUpDown level, NumericUpDown score, */DateTimePicker lastConnection)
        {
            try
            {
                CConnection objConexion = new CConnection();
                string query = "INSERT INTO player (Nickname, LastConnection) " +
                    $"values ('{nombre.Text}', '{lastConnection.Text}';";
                MySqlCommand myCommand = new MySqlCommand(query, objConexion.connectToDB());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Datos insertados correctamente");
                objConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }

        public void UpdatePlayer(TextBox nombre, TextBox propietario, TextBox especie, TextBox sexo, TextBox birth)
        {
            try
            {
                CConnection objConexion = new CConnection();
                string query = "UPDATE pet SET owner= '{propietario.Text}', species= '{especie.Text}', sex= '{sexo.Text}', birth= '{birth.Text}' WHERE name= '{nombre.Text}';";
                MySqlCommand myCommand = new MySqlCommand(query, objConexion.connectToDB());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Datos insertados correctamente");
                objConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }

    }
}
