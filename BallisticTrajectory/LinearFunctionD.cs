using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticTrajectory
{
    class LinearFunctionD
    {

        private double k;
        private double n;

        /* GETERI I SETERI*/
        public double K
        {
            get { return k; }
            set { k = value;}
        }

        public double N
        {
            get { return n; }
            set { n = value;}
        }

        //Prazan konstruktor
        public LinearFunctionD() { }

        //Pravi konstruktor
        public LinearFunctionD(double k, double n)
        {
            this.k = k;
            this.n = n;
        }

        //Konstruktor kopije
        public LinearFunctionD(LinearFunctionD A)
        {
            k = A.k;
            n = A.n;
        }


        //Konstruktor koji koristi dve tacke
        public LinearFunctionD(PointD A, PointD B)
        {
            k = (B.Y - A.Y) / (B.X - A.X);
            n = -1.0 * ((B.Y - A.Y) / (B.X - A.X) * A.X - A.Y);
        }
        //Funkcija za dobijanje vredenosti Y za dati X u odredjenoj funkciji
        private static double GetY(double X, LinearFunctionD A)
        {
            double Y = A.k * X + A.n;
            return Y;
        }

        //Funkcija za dobijanje vredenosti X za dati Y u odredjenoj funkciji
        private static double GetX(double Y, LinearFunctionD A)
        {
            double X = (Y - A.n) / A.k;
            return X;
        }

        //pronalazenje Y za dato X i odredjen set tacaka
        public static double LinearInterpolationY(double X, PointD[] points)
        {

            int first = 0;
            double Y;
            LinearFunctionD interpolate;
            //popravljanje cd
            for(int i = 0; i < points.Length-1; i++)
            {
                points[i].Y *= 0.999856;

            }
             
            //pronalazenje izmedju kojih tacaka se nalazi odabrano X

           
                for (int i = 0; i < points.Length-1; i++)
                {
                    if (X >= points[i].X) { first = i; break; }
                }
         
            interpolate = new LinearFunctionD(points[first], points[first + 1]);

            Y = GetY(X, interpolate);
            return Y ;
        }


        //pronalazenje Y za dato X i odredjen set tacaka
        public static double LinearInterpolationYGraph(double X, PointD[] points)
        {

            int first = 0;
            double Y;
            LinearFunctionD interpolate;
            
            //pronalazenje izmedju kojih tacaka se nalazi odabrano X

           
                for (int i = 0; i < points.Length - 1; i++)
                {
                    if (X <= points[i].X) { first = i; break; }
                }
       

                interpolate = new LinearFunctionD(points[first], points[first + 1]);
            

            
            Y = GetY(X, interpolate);
            return Y;
        }
    }
}
