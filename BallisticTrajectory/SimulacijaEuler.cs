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



        /* Simulacija koristeci Eulerov metod*/
        public void simulationEuler()
        {
            /* FUNKCIONALNE PROMENLJIVE */
            int i = 0;                     //brojac iteracija
            bool simulationRunning = true; // promenljiva za pokretanje/prekidanje simulacije


            /* Stil za oznacavanje zapisa */
            DataGridViewCellStyle boja = new DataGridViewCellStyle();
            boja.ForeColor = Color.DarkOrange;
            boja.Font = new Font(Tabela.Font, FontStyle.Bold);

            double axPrim;
            double ayPrim;
            double axSec;
            double aySec;

            PointD[] points =
             {                   new PointD(865, 0.296221041243509),
                                 new PointD(815, 0.362064203509306),
                                 new PointD(776, 0.371578055743002),
                                 new PointD(737, 0.382525045298620),
                                 new PointD(700, 0.382835165547702),
                                 new PointD(664, 0.384235165547702),
                                 new PointD(629, 0.385786703294031),
             };
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
                    Grafik.Series[3].Points.AddXY(posX, posY);  // crtanje pozicije na grafiku
                    Grafik1.Series[3].Points.AddXY(posX, V);  // crtanje pozicije na grafiku


                    /* Ugao vektora brzine i apscise */
                    angleA = g / V * Math.Cos(currAngle);
                    angleSpeed = angleSpeed + angleA * interval;
                    currAngle = Math.Atan(Vy / Vx) - angleSpeed * interval;
                   
                    /* Racunanje vremena leta */
                    t += interval;

                    /* pomeranje projektila */
                    posX = posX + Vx * interval - 0.5 * Math.Pow(interval,2) * ax; // pomeranje po X osi
                    posY = posY + Vy * interval - 0.5 * Math.Pow(interval, 2) * ay; // pomeranje po Y osi

                    /* Trenutna brzina */
                    V = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));          //racunanje efektivne vrednosti vektora brzine

                    /* otpor vazduha  IMPLEMENTIRATI INTERPOLACIJU ZA Cx */
                    Cd = LinearFunctionD.LinearInterpolationY(V, points);
                    Fd = Cd * airDensity * S * Math.Pow(Vx, 2) * 0.5;          //racunanje sile otpora vazduha


                    /* Racunanje ubraznja */

                    axPrim = airDensity * S * Cd * Vx * ax;
                    ayPrim = airDensity * S * Cd * Vy * ay;
                    axSec = airDensity * S * Cd * axPrim;
                    aySec = airDensity * S * Cd * ayPrim;

                    ax = Fd * Math.Cos(currAngle) / m + axPrim * interval + 0.5 * Math.Pow(interval, 2) * axSec;
                    ay = g + Fd * Math.Sin(currAngle) / m + ayPrim* interval + 0.5 * Math.Pow(interval, 2) * aySec;

                    /* promena brzine u intervalu vremena */
                    Vx = Vx - ax * interval - 0.5 * Math.Pow(interval, 2) * axPrim;
                    Vy = Vy - ay * interval - 0.5 * Math.Pow(interval, 2) * axPrim;



                    /* USLOV ZA PREKIDANJE SIMULACIJE */
                    if (posY < -1)
                    {
                        simulationRunning = false;
                        //MessageBox.Show("Vreme leta:" + t + "s");
                    }

                    i++;

                }


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

    }
}
