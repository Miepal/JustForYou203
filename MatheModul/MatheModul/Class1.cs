using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathe
{
    public class modulMathe
    {
        //Falkult�t
        public string faculty(int facultyValue)
        {
            var result = System.Numerics.BigInteger.Parse("10000000000000000000000000000000000000000000");
            result = 1;
            for (int i = 1; i <= facultyValue; i++)
            {
                result *= i;
            }

            return Convert.ToString(result);
        }

        //Quadratwurzel
        public string squareRoot(double number)
        {
            double error = 0.00001; //define the precision of your result
            double s = number;

            while ((s - number / s) > error) //loop until precision satisfied 
            {
                s = (s + number / s) / 2;
            }
            return Convert.ToString(s);
        }

        //Potenz
        public string pow(double num, int pow)
        {
            double result = 1;

            if (pow > 0)
            {
                for (int i = 1; i <= pow; ++i)
                {
                    result *= num;
                }
            }
            else if (pow < 0)
            {
                for (int i = -1; i >= pow; --i)
                {
                    result /= num;
                }
            }
            return Convert.ToString(result);
        }

        //Primzahlen zwischen zwei Werten
        public string primes(int startValue, int endValue)
        {
            string primes = "";
            for (int i = startValue; i <= endValue; i++)
            {
                if (i == 1 || i == 0)
                    continue;

                int check = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        check = 0;
                        break;
                    }
                }

                if (check == 1)
                    primes = primes + i.ToString() + ", ";
            }
            return primes;
        }

        //Umwandlung Dezimalbruch 
        public string decimalFraction(double value)
        {
            int i = 0;
            //long und value gleich ohne komma stelle
            while ((long)value != value)
            {
                value *= 10;
                i++;
            }

            //ungekürzt
            long zaehler = (long)value;
            long nenner = Convert.ToInt64(pow(10, i));

            string value_string = Convert.ToString(zaehler) + " / " + Convert.ToString(nenner);


            return Convert.ToString(value_string);
        }

    }
}