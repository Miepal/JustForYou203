using System;
using System.Collections.Generic;

namespace KreditModul
{
    public class modulKredit
    {
        public List<double> singleCredit(List<double> input)
        {
            long amount = Convert.ToInt64(input[0] * 100);
            long zins = Convert.ToInt64(amount * input[1]);
            List<double> output = new List<double>{ Convert.ToDouble(amount)/100, input[1], 0, input[2], zins + amount/100, zins, 0 };
            return output;
        }

        public List<double> rateTime(List<double> input)
        {
            long amount = Convert.ToInt64(input[0] * 100);
            long rate = Convert.ToInt64(amount / input[2]);
            List<double> output = new List<double> { amount / 100, input[1], rate / 100, input[2], 0, 0 };
            long amountLeft = amount;
            long sumPay = 0;
            long allInterest = 0;
            for (int i = 0; i < input[2]; i++)
            {
                long interest = Convert.ToInt64(amountLeft * input[1]);
                allInterest += interest;
                long annul = rate + interest;
                sumPay += annul;
                amountLeft -= rate;
            }
            output[4] = sumPay;
            output[5] = allInterest;
            return output;
        }

        public List<double> rateAmount(List<double> input)
        {
            long amount = Convert.ToInt64(input[0] * 100);
            long rate = Convert.ToInt64(input[2] * 100);
            List<double> output = new List<double> { amount / 100, input[1], rate / 100, amount / rate, 0, 0 };
            long amountLeft = amount;
            long sumPay = 0;
            long allInterest = 0;
            for (int i = 0; i < output[3]; i++)
            {
                long interest = Convert.ToInt64(amountLeft * input[1]);
                allInterest += interest;
                long annul = rate + interest;
                sumPay += annul;
                amountLeft -= rate;
            }
            output[4] = sumPay;
            output[5] = allInterest;
            return output;
        }
    }
}
