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
            results.Add(String.Format("{0} + ({0} * {1} / 100)",baseValue,percentage));
            return results;
        }
        //ProzentWeg
        public List<string> percentSub(double baseValue, double percentage)
        {
            results.Add(Convert.ToString(baseValue - (baseValue * percentage / 100)));
            results.Add(String.Format("{0} - ({0} * {1} / 100)", baseValue, percentage));
            return results;
        }
        //ProzentDavon
        public List<string> percentFrom(double baseValue, double percentage)
        {
            results.Add(Convert.ToString(baseValue * (percentage / 100)));
            results.Add(String.Format("{0} * ({1} / 100)", baseValue, percentage));
            return results;
        }
        //ProzentSatz
        public List<string> percentage(double percentageValue, double baseValue)
        {
            results.Add(Convert.ToString(percentageValue / baseValue));
            results.Add(String.Format("{1} / {0}", baseValue, percentageValue));
            return results;
        }
        //BruttoAusNetto
        public List<string> bruttoFromNetto(double bruttoValue, bool groceries)
        {
            if (groceries)
            {
                results.Add(Convert.ToString(bruttoValue * 1.07));
                results.Add(String.Format("{0} * 1.07", bruttoValue));
                return results;
            }
            else
            {
                results.Add(Convert.ToString(bruttoValue * 1.19));
                results.Add(String.Format("{0} * 1.19", bruttoValue));
                return results;
            }
        }
        //NettoAusBrutto
        public List<string> nettoFromBrutto(double bruttoValue, bool groceries)
        {
            if (groceries)
            {
                results.Add(Convert.ToString(bruttoValue / 1.07));
                results.Add(String.Format("{0} / 1.07", bruttoValue));
                return results;
            }
            else
            {
                results.Add(Convert.ToString(bruttoValue / 1.19));
                results.Add(String.Format("{0} / 1.19", bruttoValue));
                return results;
            }
        }
    }
}
