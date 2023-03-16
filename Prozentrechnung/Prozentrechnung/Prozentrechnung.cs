using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prozentrechnung
{
    public class modulProzentrechnung
    {
        List<string> results = new List<string> { };
        //ProzentDazu
        public List<string> percentAdd(double baseValue, double percentage)
        {
            results.Add(Convert.ToString(baseValue + (baseValue * percentage / 100)));
            results.Add("baseValue  + (baseValue * percentage / 100)",.format());
            return baseValue + (baseValue * percentage / 100);
        }
        //ProzentWeg
        public List<string> percentSub(double baseValue, double percentage)
        {
            return baseValue - (baseValue * percentage / 100);
        }
        //ProzentDavon
        public List<string> percentFrom(double baseValue, double percentage)
        {
            return baseValue * (percentage / 100);
        }
        //ProzentSatz
        public List<string> percentage(double percentageValue, double baseValue)
        {
            return percentageValue / baseValue;
        }
        //BruttoAusNetto
        public List<string> bruttoFromNetto(double bruttoValue, bool groceries)
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
        public List<string> nettoFromBrutto(double bruttoValue, bool groceries)
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
