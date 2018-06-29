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


        /* Simulacija sa otporom vazduha */
        public void simulationAir()
        {
            /* FUNKCIONALNE PROMENLJIVE */
            int i = 0;                     //brojac iteracija
            bool simulationRunning = true; // promenljiva za pokretanje/prekidanje simulacije


            /* Stil za oznacavanje zapisa */
            DataGridViewCellStyle boja = new DataGridViewCellStyle();
            boja.ForeColor = Color.Crimson;
            boja.Font = new Font(Tabela.Font, FontStyle.Bold);


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
                    Grafik.Series[0].Points.AddXY(posX, posY);  // crtanje pozicije na grafiku
                    Grafik1.Series[0].Points.AddXY(posX, V);  // crtanje pozicije na grafiku


                    /* Ugao vektora brzine i apscise */
                    currAngle = Math.Atan(Vy / Vx);

                    /* Racunanje vremena leta */
                    t += interval;

                    /* pomeranje projektila */
                    posX = posX + Vx * interval; // pomeranje po X osi
                    posY = posY + Vy * interval; // pomeranje po Y osi

                    /* Trenutna brzina */
                    V = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));          //racunanje efektivne vrednosti vektora brzine

                    /* otpor vazduha  IMPLEMENTIRATI INTERPOLACIJU ZA Cx */
                    Cd = LinearFunctionD.LinearInterpolationY(V, points);
                    Fd = Cd * airDensity * S * Math.Pow(Vx, 2) * 0.5;          //racunanje sile otpora vazduha


                    /* Racunanje ubraznja */
                    ax = Fd * Math.Cos(currAngle) / m;
                    ay = g + Fd * Math.Sin(currAngle) / m;

                    /* promena brzine u intervalu vremena */
                    Vx = Vx - ax * interval;
                    Vy = Vy - ay * interval;



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
