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
        #region Deklaracije

        /* KONSTANTE */
        public static double g = 9.81;                 //gravitaciono ubrzanje [m/s^2]
        public static double Rspec = 287.058;          //specificna konstanta gasa za suvi vazduh [J/kg * K] 
        public static double convConst = 0.0052834;    //konstanta za racunanje Cd

        /* UNESENE PROMENLJIVE */
        public static double alpha;        //ugao u odnosu na apscisu -- unos u [deg], pretvara se u [rad]
        public static double airPressure;  //vazdusni pritisak -- unos u [mbar], pretvara se u [Pa]  
        public static double temperature;  //temperatura vazduha -- unos u [C] pretvara se u [K]
        public static double deltaT;       //interval merenja simulacije - Δt [ms]
        public static double V0;           //pocetna brzina  [m/s]
        public static double m;            //masa projektila [kg]
        public static double h0;           //pocetna visina [m]
        public static double calibre;      //kalibar projektila [mm]

        /* IZVEDENE PROMENLJIVE */
        public static double t;            //proteklo vreme od ispaljivanja [s]
        public static double alphaRad;     // ugao u odnosu na apscisu - izvedena velicina izrazena u [rad]
        public static double posX;         //pozicija projektila na x osi [m]
        public static double posY;         //pozicija projektila na y osi [m]
        public static double Vx;           // x komponenta brzine [m/s]
        public static double Vy;           // y komponenta brzine [m/s]
        public static double V;            // efektivna vrednost vektora brzine [m/s]
        public static double temperatureK; // toplota vazduha - izvedena velicina izrazena u [K]
        public static double airPressurePa;// vazdusni pritisak - izvedena velicina izrazena u [Pa]   
        public static double airDensity;   // gustina vazduha [kg/m^3]
        public static double Cd;           // karakteristicna otpornost metka [/]
        public static double interval;     // frekvencija simuacije [1/s]
        public static double ax;           // ubrzanje (usporenje) po X osi pod uticajem otpora vazduha [m/s^2]
        public static double ay;           // ubrzanje (usporenje) po y osi pod uticajem otpora vazduha [m/s^2]
        public static double Fd;           // sila otpora vazduha [N]
        public static double S;            // povrsina poprecnog preseka metka [m^2]
        public static double currAngle;    // ugao koji zaklapa trenutni vektor brzine metka nad x osom [rad]
        public static double angleSpeed;   // brzina promene ugla
        public static double angleA;       //ubrzanje promene ugla

        /* PROMENLJIVE ZA REZIM  PRIKAZA I PRORACUNA */
        public static bool vakuum;
        public static bool vazduh;
        public static bool vazduhPC;
        public static bool euler;
        public static bool adams;

        #endregion



        /* Validacija unosa */
        public bool InputCheck()
        {
            double test;                                 //double promenljiva za proveru parsiranja STRING -> DOUBLE
            bool checkPass = true;                       //logicka promenljiva za proveru ispravnosti unosa
            string m = txtMasa.Text;                    // masa [g]
            string V0 = txtBrzina.Text;                  //pocetna brzina [m/s]
            string alpha = txtUgao.Text;                 //ugao u odnosu na apscisu [deg]
            string h0 = txtVisina.Text;                  //pocetna visina [m]
            string temperature = txtTemperatura.Text;    //temperatura vazduha [C] 
            string airPressure = txtPritisak.Text;       //vazdusni pritisak [mbar]
            string deltaT = txtInterval.Text;            //interval racunanja simulacije [ms]
            string calibre = txtKalibar.Text;            //kalibar projektila [mm]

            string[] check = { m, V0, alpha, h0, temperature, airPressure, deltaT, calibre };

            for (int i = 0; i < check.Length - 1; i++)
            {
                if (double.TryParse(check[i], out test))
                {

                }
                else { checkPass = false; }
            }
            return checkPass;
        }


        /* Resetovanje vrednosti promenljivih, ucitavanje unosa u promenljive, izvodjenje promenljivih */
        public void GetVariables()
        {

            /* RESETOVANJE VREDNOSTI */
            //osnovne
            t = 0;
            m = 0;
            V0 = 0;
            alpha = 0;
            h0 = 0;
            temperature = 0;
            airPressure = 0;
            deltaT = 0;
            calibre = 0;

            //izvedene
            m = 0;
            alphaRad = 0;
            posX = 0;
            posY = 0;
            Vx = 0;
            Vy = 0;
            V = 0;
            temperatureK = 0;
            airPressurePa = 0;
            airDensity = 0;
            interval = 0;
            S = 0;
            ax = 0;
            ay = 0;
            currAngle = 0;
            angleSpeed = 0;
            /* UNOS PROMENLJIVIH */
            t = 0;
            m = Convert.ToDouble(txtMasa.Text);                     // masa [g]
            V0 = Convert.ToDouble(txtBrzina.Text);                  //pocetna brzina [m/s]
            alpha = Convert.ToDouble(txtUgao.Text) * 1.2;                 //ugao u odnosu na apscisu [deg]
            h0 = Convert.ToDouble(txtVisina.Text);                  //pocetna visina [m]
            temperature = Convert.ToDouble(txtTemperatura.Text);    //temperatura vazduha [C] 
            airPressure = Convert.ToDouble(txtPritisak.Text);       //vazdusni pritisak [mbar]
            deltaT = Convert.ToDouble(txtInterval.Text);            //interval racunanja simulacije [ms]
            calibre = Convert.ToDouble(txtKalibar.Text);            //kalibar projektila [mm]

            /* IZVODJENJE PROMENLJIVIH*/

            m = m / 1000.0;                                         // masa [kg]
            alphaRad = alpha * Math.PI / 180;                       //ugao u odnosu na apscisu [rad]
            posX = 0;                                               //pozicija projektila na X osi [m]
            posY = h0;                                              //pozicija projektila na Y osi [m]
            Vx = V0 * Math.Cos(alphaRad);                           //X komponenta brzine
            Vy = V0 * Math.Sin(alphaRad);                           //Y komponenta brzine  
            V = V0;                                                 //racunanje efektivne vrednosti vektora brzine
            temperatureK = temperature + 273.15;                    //temperatura vazduha [K]
            airPressurePa = airPressure * 100;                      //vazdusni pritisak [Pa]
            airDensity = airPressurePa / (Rspec * temperatureK);    //gustina vazduha
            interval = deltaT / 1000;                               //frekvencija izvrsavanja racuna
            S = Math.PI * (calibre / 1000.0) * (calibre / 1000.0) / 4.0; // povrsina ceonog preseka metka



        }


    }
}
