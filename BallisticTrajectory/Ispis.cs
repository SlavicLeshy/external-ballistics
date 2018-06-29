using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace BallisticTrajectory
{
    public partial class Form1 : Form
    {
      
        /* Popunjavanje druge tabele */
        public void MiniTablePopulate()
        {

            if (vakuum)
            {

                PointD[] points = new PointD[Grafik.Series[2].Points.Count];
                PointD[] points1 = new PointD[Grafik1.Series[2].Points.Count];

                for (int i = 0; i < Grafik.Series[2].Points.Count - 1; i++)
                {

                    points[i] = new PointD(Grafik.Series[2].Points[i]);
                    points1[i] = new PointD(Grafik1.Series[2].Points[i]);
                }

                /* Stil za oznacavanje zapisa */
                DataGridViewCellStyle boja = new DataGridViewCellStyle();
                boja.ForeColor = Color.ForestGreen;
                boja.Font = new Font(Tabela.Font, FontStyle.Bold);

                for (int i = 0; i < 350; i += 50)
                {
                    Tabela1.Rows.Add(i, LinearFunctionD.LinearInterpolationYGraph(i, points), LinearFunctionD.LinearInterpolationYGraph(i, points1));
                    Tabela1.Rows[Tabela1.Rows.Count - 2].DefaultCellStyle = boja;
                }
            }

            if (vazduh)
            {

                PointD[] points = new PointD[Grafik.Series[0].Points.Count];
                PointD[] points1 = new PointD[Grafik1.Series[0].Points.Count];

                for (int i = 0; i < Grafik.Series[0].Points.Count - 1; i++)
                {

                    points[i] = new PointD(Grafik.Series[0].Points[i]);
                    points1[i] = new PointD(Grafik1.Series[0].Points[i]);


                }
                /* Stil za oznacavanje zapisa */
                DataGridViewCellStyle boja = new DataGridViewCellStyle();
                boja.ForeColor = Color.Crimson;
                boja.Font = new Font(Tabela.Font, FontStyle.Bold);

                for (int i = 0; i < 350; i += 50)
                {
                    Tabela1.Rows.Add(i, LinearFunctionD.LinearInterpolationYGraph(i, points), LinearFunctionD.LinearInterpolationYGraph(i, points1));
                    Tabela1.Rows[Tabela1.Rows.Count - 2].DefaultCellStyle = boja;
                }
            }

            if (vazduhPC)
            {
                PointD[] points = new PointD[Grafik.Series[1].Points.Count];
                PointD[] points1 = new PointD[Grafik1.Series[1].Points.Count];

                for (int i = 0; i < Grafik.Series[1].Points.Count - 1; i++)
                {

                    points[i] = new PointD(Grafik.Series[1].Points[i]);
                    points1[i] = new PointD(Grafik1.Series[1].Points[i]);


                }

                /* Stil za oznacavanje zapisa */
                DataGridViewCellStyle boja = new DataGridViewCellStyle();
                boja.ForeColor = Color.Purple;
                boja.Font = new Font(Tabela.Font, FontStyle.Bold);


                for (int i = 0; i < 350; i += 50)
                {
                    Tabela1.Rows.Add(i, LinearFunctionD.LinearInterpolationYGraph(i, points), LinearFunctionD.LinearInterpolationYGraph(i, points1));
                    Tabela1.Rows[Tabela1.Rows.Count - 2].DefaultCellStyle = boja;
                }
            }

            if (euler)
            {
                PointD[] points = new PointD[Grafik.Series[3].Points.Count];
                PointD[] points1 = new PointD[Grafik1.Series[3].Points.Count];

                for (int i = 0; i < Grafik.Series[3].Points.Count - 1; i++)
                {

                    points[i] = new PointD(Grafik.Series[3].Points[i]);
                    points1[i] = new PointD(Grafik1.Series[3].Points[i]);


                }
                /* Stil za oznacavanje zapisa */
                DataGridViewCellStyle boja = new DataGridViewCellStyle();
                boja.ForeColor = Color.DarkOrange;
                boja.Font = new Font(Tabela.Font, FontStyle.Bold);

                
                for (int i = 0; i < 350; i += 50)
                {
                    Tabela1.Rows.Add(i, LinearFunctionD.LinearInterpolationYGraph(i, points), LinearFunctionD.LinearInterpolationYGraph(i, points1));
                    Tabela1.Rows[Tabela1.Rows.Count - 2].DefaultCellStyle = boja;
                } 
            }

            if (adams)
            {
                PointD[] points = new PointD[Grafik.Series[4].Points.Count];
                PointD[] points1 = new PointD[Grafik1.Series[4].Points.Count];

                for (int i = 0; i < Grafik.Series[4].Points.Count - 1; i++)
                {

                    points[i] = new PointD(Grafik.Series[4].Points[i]);
                    points1[i] = new PointD(Grafik1.Series[4].Points[i]);


                }
                /* Stil za oznacavanje zapisa */
                DataGridViewCellStyle boja = new DataGridViewCellStyle();
                boja.ForeColor = Color.DarkCyan;
                boja.Font = new Font(Tabela.Font, FontStyle.Bold);


                for (int i = 0; i < 350; i += 50)
                {
                    Tabela1.Rows.Add(i, LinearFunctionD.LinearInterpolationYGraph(i, points), LinearFunctionD.LinearInterpolationYGraph(i, points1));
                    Tabela1.Rows[Tabela1.Rows.Count - 2].DefaultCellStyle = boja;
                }
            }
        }



        /* Podesavanja grafika */
        public void GraphSettings()
        {
            // PODESAVANJA Serija (linija na grafiku)
            var series = new Series("Sa otporom vazduha");
            var series1 = new Series("Sa otporom vazduha: prediktor-korektor metoda");
            var series2 = new Series("U vakuumu");
            var series3 = new Series("Sa otporom vazduha: Eulerov metod");
            var series4 = new Series("Sa otporom vazduha: Adamsov metod");

            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Crimson;
            series.YValuesPerPoint = 1;

            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.MediumPurple;
            series1.YValuesPerPoint = 1;

            series2.ChartType = SeriesChartType.Line;
            series2.Color = Color.ForestGreen;
            series2.YValuesPerPoint = 1;

            series3.ChartType = SeriesChartType.Line;
            series3.Color = Color.DarkOrange;
            series3.YValuesPerPoint = 1;

            series4.ChartType = SeriesChartType.Line;
            series4.Color = Color.DarkCyan;
            series4.YValuesPerPoint = 1;

            // PODESAVANJA Grafika
            Grafik.Series.Add(series);
            Grafik.Series.Add(series1);
            Grafik.Series.Add(series2);
            Grafik.Series.Add(series3);
            Grafik.Series.Add(series4);
            Grafik.Palette = ChartColorPalette.BrightPastel;
            // Prvi parametar su podaci po X osi, drugi su podaci po Y osi
            Grafik.Series[0].Points.AddXY(0, 0);
            Grafik.Series[1].Points.AddXY(0, 0);
            Grafik.Series[2].Points.AddXY(0, 0);
            Grafik.Series[3].Points.AddXY(0, 0);
            Grafik.Series[4].Points.AddXY(0, 0);





            // PODESAVANJA Serija (linija na grafiku)
            var bseries = new Series("Sa otporom vazduha");
            var bseries1 = new Series("Sa otporom vazduha: prediktor-korektor metod");
            var bseries2 = new Series("U vakuumu");
            var bseries3 = new Series("Sa otporom vazduha: Eulerov metod");
            var bseries4 = new Series("Sa otporom vazduha: Adamsov metod");

            bseries.ChartType = SeriesChartType.Line;
            bseries.Color = Color.Crimson;
            bseries.YValuesPerPoint = 1;

            bseries1.ChartType = SeriesChartType.Line;
            bseries1.Color = Color.MediumPurple;
            bseries1.YValuesPerPoint = 1;

            bseries2.ChartType = SeriesChartType.Line;
            bseries2.Color = Color.ForestGreen;
            bseries2.YValuesPerPoint = 1;

            bseries3.ChartType = SeriesChartType.Line;
            bseries3.Color = Color.DarkOrange;
            bseries3.YValuesPerPoint = 1;

            bseries4.ChartType = SeriesChartType.Line;
            bseries4.Color = Color.DarkCyan;
            bseries4.YValuesPerPoint = 1;

            // PODESAVANJA Grafika
            Grafik1.Series.Add(bseries);
            Grafik1.Series.Add(bseries1);
            Grafik1.Series.Add(bseries2);
            Grafik1.Series.Add(bseries3);
            Grafik1.Series.Add(bseries4);
            Grafik1.Palette = ChartColorPalette.BrightPastel;
            // Prvi parametar su podaci po X osi, drugi su podaci po Y osi
            Grafik1.Series[0].Points.AddXY(0, 0);
            Grafik1.Series[1].Points.AddXY(0, 0);
            Grafik1.Series[2].Points.AddXY(0, 0);
            Grafik1.Series[3].Points.AddXY(0, 0);
            Grafik1.Series[4].Points.AddXY(0, 0);


            //Podesavanje grafika za prikaz okruglih vrednosti na podeocima
            Grafik.ChartAreas[0].AxisX.RoundAxisValues();
            Grafik.ChartAreas[0].AxisX.Minimum = 0;
            Grafik1.ChartAreas[0].AxisX.RoundAxisValues();
            Grafik1.ChartAreas[0].AxisX.Minimum = 0;
        }

        /* Podesavanja dataGridView-a */
        public void TableSettings()
        {
            Tabela.Columns.Add("PosX", "PosX");
            Tabela.Columns.Add("PosY", "PosY");
            Tabela.Columns.Add("V", "V");
            Tabela.Columns.Add("Vx", "Vx");
            Tabela.Columns.Add("Vy", "Vy");
            Tabela.Columns.Add("Ax", "Ax");
            Tabela.Columns.Add("Ay", "Ay");
            Tabela.Columns.Add("Fd", "Fd");
            Tabela.Columns.Add("Cd", "Cd");
            Tabela.Columns.Add("Angle", "Angle");

            Tabela1.Columns.Add("PosX", "PosX");
            Tabela1.Columns.Add("PosY", "PosY");
            Tabela1.Columns.Add("V", "V");

        }



        /* Kod za prikazivanje vrednosti na grafiku prelaskom misa preko linije grafika */

        //Grafik pozicije
        private void Grafik_MouseMove(object sender, MouseEventArgs e)
        {
            Point? prevPosition = null;
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;

            prevPosition = pos;
            var results = Grafik.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {

                    double xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                    double yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);

                    txtLoc.Text = "Vrednost X: " + xVal.ToString() + "\r\nVrednost Y:  " + yVal.ToString();
                }
            }
        }

        //Grafik brzine
        private void Grafik1_MouseMove(object sender, MouseEventArgs e)
        {
            Point? prevPosition = null;
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;

            prevPosition = pos;
            var results = Grafik1.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {

                    double xVal = result.ChartArea.AxisX.PixelPositionToValue(pos.X);
                    double yVal = result.ChartArea.AxisY.PixelPositionToValue(pos.Y);

                    txtLoc.Text = "Vrednost X: " + xVal.ToString() + Environment.NewLine + "Vrednost Y:  " + yVal.ToString();
                }
            }
        }




        /* Ciscenje prethodnog ispisa */
        public void ClearOutput()
        {

            Grafik.Series[0].Points.Clear();
            Grafik.Series[1].Points.Clear();
            Grafik.Series[2].Points.Clear();
            Grafik.Series[3].Points.Clear();
            Grafik.Series[4].Points.Clear();

            Grafik1.Series[0].Points.Clear();
            Grafik1.Series[1].Points.Clear();
            Grafik1.Series[2].Points.Clear();
            Grafik1.Series[3].Points.Clear();
            Grafik1.Series[4].Points.Clear();

            Tabela.Rows.Clear();
            Tabela1.Rows.Clear();
        }

    }
}
