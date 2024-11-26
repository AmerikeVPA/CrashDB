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
                string query = "SELECT * FROM pet WHERE name = @nombre";
                MySqlCommand myCommand = new MySqlCommand(query, objConexion.connectToDB());
                myCommand.Parameters.AddWithValue("@nombre", playerTag.Text);
                MySqlDataReader reader = myCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Mascota registrada");
                    textBox2.Text = reader["owner"].ToString();
                    textBox3.Text = reader["sex"].ToString();
                    textBox4.Text = reader["species"].ToString();
                    textBox5.Text = reader["birth"].ToString();
                }
                else
                {
                    MessageBox.Show("Mascota no registrada");
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
            crashObj.UpdatePlayer(playerTag, textBox2, textBox3, textBox4, textBox5);
            crashObj.ShowPlayers(crashDBView);
        }
    }
}
