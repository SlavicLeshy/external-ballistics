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

        /* Simulacija sa otporom vazduha - prediktor-korektor */
        public void simulationAdams()
        {
            /* FUNKCIONALNE PROMENLJIVE */

            bool simulationRunning = true; // promenljiva za pokretanje/prekidanje simulacije



            /* Stil za oznacavanje zapisa */
            DataGridViewCellStyle boja = new DataGridViewCellStyle();
            boja.ForeColor = Color.Purple;
            boja.Font = new Font(Tabela.Font, FontStyle.Bold);


            //promenljive za poziciju, brzinu i ubrzanje - nizovi zbog koraka prediktor-korektor metode
            double[] posXPC = new double[3];
            double[] posYPC = new double[3];
            double[] VxPC = new double[3];
            double[] VyPC = new double[3];
            double[] axPC = new double[3];
            double[] ayPC = new double[3];
            double[] currAnglePC = new double[3];
            double[] angleSpeedPC = new double[3];
            double[] angleAPC = new double[3];

            //promenljive za poziciju, brzinu i ubrzanje - nizovi zbog koraka adamsovog metod
            double[] posStep = new double[3];
            double[] posYStep = new double[3];
            double[] VxStep = new double[3];
            double[] VyStep = new double[3];
            double[] axStep = new double[3];
            double[] ayStep = new double[3];
            double[] currAngleStep = new double[3];
            double[] angleSpeedStep = new double[3];
            double[] angleAStep = new double[3];


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
                for(int i = 0; i < 4; i++)
                {

                    /* Upis podataka u datagridview */
                    string[] row = new string[]
                    {
                        posX.ToString(), posY.ToString(),
                        V.ToString(), Vx.ToString(),
                        Vy.ToString(), ax.ToString(),
                        ay.ToString(), Fd.ToString(),
                        Cd.ToString(), (currAngle * 180 / Math.PI).ToString()
                    };

                    Tabela.Rows.Add(row);
                    Tabela.Rows[Tabela.Rows.Count - 2].DefaultCellStyle = boja;
                    /* Upis u grafik */

                    Grafik.Series[1].Points.AddXY(posX, posY);  // crtanje pozicije na grafiku
                    Grafik1.Series[1].Points.AddXY(posX, V);  // crtanje pozicije na grafiku


                    /* PREDIKTOR start */

                    /* Ugao vektora brzine i apscise */
                    angleAPC[0] = g / V * Math.Cos(currAngle);
                    angleSpeedPC[0] = angleSpeedPC[0] + angleAPC[0] * interval;
                    currAnglePC[0] = Math.Atan(Vy / Vx) - angleSpeedPC[0] * interval;


                    /* Racunanje vremena leta */
                    t += interval;

                    /* pomeranje projektila */
                    posXPC[0] = posX + Vx * interval; // pomeranje po X osi
                    posYPC[0] = posY + Vy * interval; // pomeranje po Y osi

                    /* Trenutna brzina */
                    V = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));          //racunanje efektivne vrednosti vektora brzine

                    /* otpor vazduha*/
                    Cd = LinearFunctionD.LinearInterpolationY(V, points);
                    Fd = Cd * airDensity * S * Math.Pow(Vx, 2) * 0.5;          //racunanje sile otpora vazduha


                    /* Racunanje ubraznja */
                    axPC[0] = Fd * Math.Cos(currAngle) / m;
                    ayPC[0] = g + Fd * Math.Sin(currAngle) / m;

                    /* promena brzine u intervalu vremena */
                    VxPC[0] = Vx - ax * interval;
                    VyPC[0] = Vy - ay * interval;



                    /* Ugao vektora brzine i apscise */
                    angleAPC[1] = g / V * Math.Cos(currAnglePC[0]);
                    angleSpeedPC[1] = angleSpeedPC[0] + angleAPC[1] * interval;
                    currAnglePC[1] = Math.Atan(VyPC[0] / VxPC[0]) - angleSpeedPC[1] * interval;



                    /* Racunanje vremena leta */
                    t += interval;

                    /* pomeranje projektila */
                    posXPC[1] = posXPC[0] + VxPC[0] * interval; // pomeranje po X osi
                    posYPC[1] = posYPC[0] + VyPC[0] * interval; // pomeranje po Y osi

                    /* Trenutna brzina */
                    V = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));          //racunanje efektivne vrednosti vektora brzine

                    /* otpor vazduha  IMPLEMENTIRATI INTERPOLACIJU ZA Cx */
                    Cd = LinearFunctionD.LinearInterpolationY(V, points);
                    Fd = Cd * airDensity * S * Math.Pow(VxPC[0], 2) * 0.5;          //racunanje sile otpora vazduha


                    /* Racunanje ubrzanja */
                    axPC[1] = Fd * Math.Cos(currAngle) / m;
                    ayPC[1] = g + Fd * Math.Sin(currAngle) / m;

                    /* promena brzine u intervalu vremena */
                    VxPC[1] = VxPC[0] - axPC[0] * interval;
                    VyPC[1] = VyPC[0] - ayPC[0] * interval;

                    /* PREDIKTOR end*/

                    /* KOREKTOR start */

                    axPC[2] = (axPC[0] + axPC[1]) / 2.0;
                    ayPC[2] = (ayPC[0] + ayPC[1]) / 2.0;
                    VxPC[2] = (VxPC[0] + VxPC[1]) / 2.0;
                    VyPC[2] = (VyPC[0] + VyPC[1]) / 2.0;
                    posXPC[2] = (posXPC[0] + posXPC[1]) / 2.0;
                    posYPC[2] = (posYPC[0] + posYPC[1]) / 2.0;

                    angleAPC[2] = (angleAPC[0] + angleAPC[1]) / 2.0;
                    angleSpeedPC[2] = (angleSpeedPC[0] + angleSpeedPC[1]) / 2.0;
                    currAnglePC[2] = (currAnglePC[0] + currAnglePC[1]) / 2.0;


                    ax = axPC[2];
                    ay = ayPC[2];
                    Vx = VxPC[2];
                    Vy = VyPC[2];
                    posX = posXPC[2];
                    posY = posYPC[2];
                    angleA = angleAPC[2];
                    angleSpeed = angleSpeedPC[2];
                    currAngle = currAnglePC[2];
                    V = Math.Sqrt(Math.Pow(Vx, 2) + Math.Pow(Vy, 2));

                    /*KOREKTOR end */


                    /* USLOV ZA PREKIDANJE SIMULACIJE */
                    if (posY < -1)
                    {
                        simulationRunning = false;
                        //MessageBox.Show("Vreme leta:" + t + "s");
                    }
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }



    }
}
