using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsrechner
{
    class Währungen
    {
        public string symbol; //Symbol der Währung 
        public double welthe; //Kurs in Euro
        public double welthg; //Gegenkurs


        /// <summary>
        /// Rechnet einen Input in eine andere Währung um
        /// </summary>
        /// <param name="input">Input an Geld</param>
        /// <param name="outw">in Umzurechnende Währung</param>
        /// <returns>Umgerechneter Geldbetrag</returns>
        public double Calc(double input, Währungen outw)
        {
            double output = 0;

            if (this.symbol == "€")
            {
                output = input * outw.welthe;
            }
            else
            {
                if (outw.symbol == "€")
                {
                    output = input * this.welthg;
                    return output;
                }
                else
                {
                    double temp = input * this.welthg;
                    output = temp * outw.welthe;
                }
            }
            return output;
        }
    }
}
