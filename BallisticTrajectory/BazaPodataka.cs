using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BallisticTrajectory
{
    public partial class Form1 : Form
    {
        /* PROMENLJIVE ZA BAZU */
        public static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Ballistics.mdf';Integrated Security = True;";
        SqlConnection connection = new SqlConnection(conString);
        SqlCommand command;
        SqlDataReader reader;


        /* Ucitavanje metaka iz baze podataka */
        public void LoadBullets()
        {

            string sql = "SELECT naziv FROM Metak ORDER BY kalibar";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbxMetak.Items.Add(reader[0].ToString());

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { connection.Close(); }

            cbxMetak.SelectedItem = cbxMetak.Items[0];


        }

        /* Ucitavanje karakteristika odabranog metka iz baze podataka */
        public void LoadBulletValues()
        {
            string sql = "SELECT masa, pocetnaBrzina, ugao, kalibar FROM Metak WHERE naziv='" + cbxMetak.SelectedItem.ToString() + "'";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {


                    txtMasa.Text = reader[0].ToString();
                    txtBrzina.Text = reader[1].ToString();
                    txtUgao.Text = reader[2].ToString();
                    txtKalibar.Text = reader[3].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { connection.Close(); }

        }


    }
}
