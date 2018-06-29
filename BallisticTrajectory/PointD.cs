using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace BallisticTrajectory
{
    class PointD
    {

        private double x;
        private double y;

        /* GETERI I SETERI */
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        //prazan konstruktor
        public PointD() { }

        //pravi konstruktor
        public PointD(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //konstruktor kopije
        public PointD(PointD A)
        {
            x = A.x;
            y = A.y;
        }


        //konstruktor kopije
        public PointD(DataPoint A)
        {
            x = A.XValue;
            y = A.YValues[0];
        }



    }
}
