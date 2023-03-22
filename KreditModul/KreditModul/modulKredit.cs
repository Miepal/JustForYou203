using System;
using System.Collections.Generic;

namespace KreditModul
{
    public class modulKredit
    {
        public List<string> toStringOutput(List<double> values)
        {
            List<string> newOutput = new List<string>();
            newOutput.Add("Kreditbetrag: " + Convert.ToString(values[0]) + "€");
            newOutput.Add("Zinssatz: " + Convert.ToString(values[1]) + "%");
            newOutput.Add("Ratenhöhe: " + Convert.ToString(values[2]) + "€");
            newOutput.Add("Laufzeit in Monaten: " + Convert.ToString(values[3]));
            newOutput.Add("Schlussrate " + Convert.ToString(values[4]) + "€");
            newOutput.Add("Gesamtzinsen: " + Convert.ToString(values[5]) + "€");

            return newOutput;
        }
 
        public List<string> singleCredit(double crdAmount, double crdZins, double crdRuntime)
        {
            long amount = Convert.ToInt64(crdAmount * 100);
            double calcZins = crdZins / 100 + 1;
            long sumPay = Convert.ToInt64(amount * calcZins);
            long zins = sumPay - amount;
            List<double> output = new List<double>{ Convert.ToDouble(amount)/100, crdZins, Convert.ToDouble(amount)/100, crdRuntime, sumPay/100, zins/100 };
            return toStringOutput(output);
        }

        public List<string> rateTime(double crdAmount, double crdZins, double crdRuntime)
        {
            long amount = Convert.ToInt64(crdAmount * 100);
            //long rate = Convert.ToInt64(amount / crdRuntime);
            //double normZins = crdZins / 100;
            //double calcZins = normZins + 1;
            List<double> output = new List<double> { Convert.ToDouble(amount) / 100, crdZins, Convert.ToDouble(rate) / 100, crdRuntime, 0, 0 };

            //long amountLeft = amount;
            //long sumPay = 0;
            //long allInterest = 0;
            //for (int i = 0; i <= crdRuntime; i++)
            //{
            //    long interest = Convert.ToInt64(normZins * amountLeft);
            //    allInterest += interest;
            //    long annul = interest + rate;
            //    sumPay += annul;
            //    amountLeft -= rate;
            //}
            //output[4] = Convert.ToDouble(sumPay)/100;
            //output[5] = Convert.ToDouble(allInterest)/100;
            return toStringOutput(output);
        }

        public List<string> rateAmount(double crdAmount, double crdZins, double crdRate)
        {
            long amount = Convert.ToInt64(crdAmount * 100);
            long rate = Convert.ToInt64(crdRate / 100);
            int runtime = Convert.ToInt32(amount / rate);
            List<double> output = new List<double> { amount / 100, crdZins, rate / 100, amount / rate, 0, 0 };
            long interest;
            double faktor = 0;
            for (int i = 1; i < runtime; i++)
            {
                faktor += i;
            }
            faktor /= runtime;
            interest = Convert.ToInt64(amount * faktor * crdZins / 100 / 12);
            runtime = Convert.ToInt32((amount + interest) / rate);
            long closeRate = Convert.ToInt64((amount + interest) - (runtime - 1) * rate);
            output[4] = Convert.ToDouble(closeRate) / 100;
            output[5] = Convert.ToDouble(1);
            return toStringOutput(output);
        }
    }
}
