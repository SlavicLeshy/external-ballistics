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
        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            /* Rezim racunanja */

            vazduhPC = true;
            cbxVazduhPC.Checked = true;
           
            GraphSettings(); //ucitavanje podesavanja grafika
            TableSettings(); //ucitavanje podesavanja datagridview-a
            LoadBullets(); //ucitavanje metaka iz baze u listbox

        }

        /* Dugme za pokretanje odabrane simulacije - Event handler */
        private void btnSimulacija_Click(object sender, EventArgs e)
        {

            if (!InputCheck()) { MessageBox.Show("Nepravilan unos!"); }
            else
            {

                /* SIMULACIJA */
                ClearOutput(); //ciscenje prethodnog ispisa

                if (vakuum)
                {
                     
                    GetVariables();
                    simulationVacuum();

                }
                 if (vazduh)
                {
                    
                    GetVariables();
                    simulationAir();
                }
               if (vazduhPC)
                {
                    GetVariables();
                    simulationAirPC();

                }
                if (euler)
                {
                    GetVariables();
                    simulationEuler();

                }
                if (adams)
                {
                    GetVariables();
                    simulationAdams();

                }

                MiniTablePopulate();
            }
        }
       
    
        /* Odabir metka - event handler */
        private void cbxMetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBulletValues();
        }

        /* Postavka standardnih pocetnih uslova */
        private void btnUslovi_Click(object sender, EventArgs e)
        {
            /* standardni meteo uslovi, bez pocetne visine, simulacija vrsi merenje na 5ms */
            txtInterval.Text = "1";
            txtVisina.Text = "-0.05";
            txtTemperatura.Text = "15";
            txtPritisak.Text = "1000";

            
        }

    
        /* odabir rezima rada */
        private void cbxVakuum_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxVakuum.Checked) { vakuum = true; }
            else { vakuum = false; }
        }

        private void cbxVazduh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVazduh.Checked) { vazduh = true; }
            else { vazduh = false; }
        }

        private void cbxVazduhPC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVazduhPC.Checked) { vazduhPC = true; }
            else { vazduhPC = false; }
        }

        private void cbxEuler_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEuler.Checked) { euler = true; }
            else { euler = false; }
        }

        private void cbxAdams_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAdams.Checked) { adams = true; }
            else { adams = false; }
        }
    }
}
