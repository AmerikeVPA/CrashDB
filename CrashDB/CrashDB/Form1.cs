using CrashDB.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrashDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CCrashBandicootDB crashObj = new Clases.CCrashBandicootDB();
            crashObj.ShowPlayers(crashDBView);
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            Clases.CConnection connectionObj = new Clases.CConnection();
            connectionObj.connectToDB();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                CConnection objConexion = new CConnection();
                string query = "SELECT * FROM player WHERE Nickname = @nombre";
                MySqlCommand myCommand = new MySqlCommand(query, objConexion.connectToDB());
                myCommand.Parameters.AddWithValue("@nombre", playerTag.Text);
                MySqlDataReader reader = myCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Player located");
                    lastConnection.Value = DateTime.Parse(reader["LastConnection"].ToString());
                }
                else
                {
                    MessageBox.Show("Player not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            Clases.CCrashBandicootDB crashObj = new Clases.CCrashBandicootDB();
            crashObj.AddPlayer(playerTag, lastConnection);
            crashObj.ShowPlayers(crashDBView);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Clases.CCrashBandicootDB crashObj = new Clases.CCrashBandicootDB();
            crashObj.UpdatePlayer(playerTag, lastConnection);
            crashObj.ShowPlayers(crashDBView);
        }
    }
}
