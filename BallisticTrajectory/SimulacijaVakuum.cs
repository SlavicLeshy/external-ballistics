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
    public partial class Form1 : Form {

        /* Simulacija u uslovima vakuuma */
        public void simulationVacuum()
        {
            /* FUNKCIONALNE PROMENLJIVE */
            int i = 0;                     //brojac iteracija
            bool simulationRunning = true; // promenljiva za pokretanje/prekidanje simulacije

            /* Stil za oznacavanje zapisa */
            DataGridViewCellStyle boja = new DataGridViewCellStyle();
            boja.ForeColor = Color.ForestGreen;
            boja.Font = new Font(Tabela.Font, FontStyle.Bold);

            try
            {

                while (simulationRunning)
                {

                    /* Upis podataka u datagridview */
                    string[] row = new string[] {
                        posX.ToString(), posY.ToString(),
                        V.ToString(), Vx.ToString(),
                        Vy.ToString(), ax.ToString(),
                        ay.ToString(), Fd.ToString(),
                        Cd.ToString(), (currAngle * 180 / Math.PI).ToString()
                    };

                    Tabela.Rows.Add(row);
                    Tabela.Rows[Tabela.Rows.Count - 2].DefaultCellStyle = boja;

                    /* Upis u grafik */
                    Grafik.Series[2].Points.AddXY(posX, posY);  // crtanje pozicije na grafiku
                    Grafik1.Series[2].Points.AddXY(posX, V);  // crtanje pozicije na grafiku

                    /* Racunanje vremena leta */
                    t += interval;


                    /* pomeranje projektila */
                    posX = posX + Vx * interval; // pomeranje po X osi
                    posY = posY + Vy * interval; // pomeranje po Y osi

                    /* Trenutna brzina */
                    V = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));          //racunanje efektivne vrednosti vektora brzine



                    /* Racunanje ubrzanja */

                    ay = g;

                    /* promena brzine u intervalu vremena */
                    Vy = Vy - ay * interval;



                    /* USLOV ZA PREKIDANJE SIMULACIJE */
                    if (posY < -1)
                    {
                        simulationRunning = false;
                        //MessageBox.Show("Vreme leta:" + t + "s");
                    }

                    i++;



                }

                // Tabela.Rows.Add(emptyRow);
                // Tabela.Rows[Tabela.Rows.Count - 2].DefaultCellStyle = zeleni;
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }




    }
}

