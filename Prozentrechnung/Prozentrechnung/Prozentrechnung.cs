using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prozentrechnung
{
    public class modulProzentrechnung
    {
        //ProzentDazu
        public double percentAdd(double baseValue, double percentage)
        {
            return baseValue + (baseValue * percentage / 100);
        }
        //ProzentWeg
        public double percentSub(double baseValue, double percentage)
        {
            return baseValue - (baseValue * percentage / 100);
        }
        //ProzentDavon
        public double percentFrom(double baseValue, double percentage)
        {
            return baseValue * (percentage / 100);
        }
        //ProzentSatz
        public double percentage(double percentageValue, double baseValue)
        {
            return percentageValue / baseValue;
        }
        //BruttoAusNetto
        public double bruttoFromNetto(double bruttoValue, bool groceries)
        {
            if (groceries)
            {
                return bruttoValue * 1.07;
            }
            else
            {
                return bruttoValue * 1.19;
            }
        }
        //NettoAusBrutto
        public double nettoFromBrutto(double bruttoValue, bool groceries)
        {
            if (groceries)
            {
                return bruttoValue / 1.07;
            }
            else
            {
                return bruttoValue / 1.19;
            }
        }
    }
}
