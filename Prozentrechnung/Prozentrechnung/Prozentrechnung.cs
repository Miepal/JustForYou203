using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prozentrechnung
{
    public class modulProzentrechnung
    {
        string results;
        //ProzentDazu
        public string percentAdd(double baseValue, double percentage)
        {
            //results.Add(Convert.ToString(baseValue + (baseValue * percentage / 100)));
            //results.Add(String.Format("{0} + ({0} * {1} / 100)",baseValue,percentage));
            return String.Format("{0} + ({0} * {1} / 100) = {2}", baseValue, percentage, baseValue + (baseValue * percentage / 100));
        }
        //ProzentWeg
        public string percentSub(double baseValue, double percentage)
        {
            //results.Add(Convert.ToString(baseValue - (baseValue * percentage / 100)));
            //results.Add(String.Format("{0} - ({0} * {1} / 100)", baseValue, percentage));
            return String.Format("{0} - ({0} * {1} / 100) = {2}", baseValue, percentage, baseValue - (baseValue * percentage / 100));
        }
        //ProzentDavon
        public string percentFrom(double baseValue, double percentage)
        {
            //results.Add(Convert.ToString(baseValue * (percentage / 100)));
            //results.Add(String.Format("{0} * ({1} / 100)", baseValue, percentage));
            return String.Format("{0} * ({1} / 100) = {2}", baseValue, percentage, baseValue * (percentage / 100));
        }
        //ProzentSatz
        public string percentage(double percentageValue, double baseValue)
        {
            //results.Add(Convert.ToString(percentageValue / baseValue));
            //results.Add(String.Format("{1} / {0}", baseValue, percentageValue));
            return String.Format("{1} / {0} = {2}", baseValue, percentageValue, percentageValue / baseValue);
        }
        //BruttoAusNetto
        public string bruttoFromNetto(double bruttoValue, bool groceries)
        {
            if (groceries)
            {
                //results.Add(Convert.ToString(bruttoValue * 1.07));
                //results.Add(String.Format("{0} * 1.07", bruttoValue));
                return String.Format("{0} * 1.07 = {1}", bruttoValue, bruttoValue * 1.07);
            }
            else
            {
                //results.Add(Convert.ToString(bruttoValue * 1.19));
                //results.Add(String.Format("{0} * 1.19", bruttoValue));
                return String.Format("{0} * 1.19 = {1}", bruttoValue, bruttoValue * 1.19);
            }
        }
        //NettoAusBrutto
        public string nettoFromBrutto(double bruttoValue, bool groceries)
        {
            if (groceries)
            {
                //results.Add(Convert.ToString(bruttoValue / 1.07));
                //results.Add(String.Format("{0} / 1.07", bruttoValue));
                return String.Format("{0} / 1.07 = {1}", bruttoValue, bruttoValue / 1.07);
            }
            else
            {
                //results.Add(Convert.ToString(bruttoValue / 1.19));
                //results.Add(String.Format("{0} / 1.19", bruttoValue));
                return String.Format("{0} / 1.19 = {1}", bruttoValue, bruttoValue / 1.19);
            }
        }
    }
}
