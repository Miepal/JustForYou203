using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JustForYou_Taschenrechner
{
    public partial class Grundrechner : Form
    {
        private float result;

        public Grundrechner()
        {
            InitializeComponent();
        }

        public float getResult()
        {
            return result;
        }

        public void setResult(float data)
        {
            result = data;
        }

        private void b_divide_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '/';
        }

        private void b_multiply_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '*';
        }

        private void b_minus_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '-';
        }

        private void b_plus_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '+';
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '7';
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '8';
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '9';
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            tb_formula.Text = "";
            tb_output.Text = "";
        }

        private void b_backspace_Click(object sender, EventArgs e)
        {
            tb_formula.Text.Remove(tb_formula.Text.Length - 1);
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '4';
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '5';
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '6';
        }

        private void b_opening_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '(';
        }

        private void b_closing_Click(object sender, EventArgs e)
        {
            tb_formula.Text += ')';
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '1';
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '2';
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '3';
        }

        private void b_sign_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '-';
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            tb_formula.Text += '0';
        }

        private void b_comma_Click(object sender, EventArgs e)
        {
            tb_formula.Text += ',';
        }

        private void b_equal_Click(object sender, EventArgs e)
        {
            string formula = tb_formula.Text;
            Regex regex = new Regex("\\(.*[^()].*\\)");
            MatchCollection matches = regex.Matches(formula);
            if(matches.Count != 0)
            {
                Regex checkBracket = new Regex("[\\(\\)]");
                while (checkBracket.IsMatch(formula))
                {
                    foreach (Match match in matches)
                    {
                        Regex patternBracket = new Regex(match.Value);
                        patternBracket.Replace(formula, replace_PM(match.Value));
                    }
                    matches = regex.Matches(formula);
                }
                tb_output.Text = formula;
            }
            else
            {
                tb_output.Text = replace_PM(tb_formula.Text);
            }

        }

        private void b_settings_Click(object sender, EventArgs e)
        {
            Einstellungen settings = new Einstellungen();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string replace_MD(Match text)
        {
            Regex regex = new Regex("[0-9,/*]+");
            string result = "";
            MatchCollection matches = regex.Matches(text.Value);
            if(matches.Count != 0)
            {
                foreach (Match match in matches)
                {
                    Regex reg = new Regex("[0-9,]");
                    MatchCollection numbers = reg.Matches(match.Value);
                    List<double> values = new List<double>();
                    foreach (Match number in numbers)
                    {
                        values.Add(Convert.ToDouble(number.Value));
                    }
                    Regex regexOperator = new Regex("[*/]");
                    MatchCollection matchOperator = regexOperator.Matches(match.Value);
                    foreach(Match o in matchOperator)
                    {
                        if(o.Value == "*")
                        {
                            values[0] *= values[1];
                            values.RemoveAt(1);
                        }
                        else
                        {
                            values[0] /= values[1];
                            values.RemoveAt(1);
                        }
                    }
                    Regex calc = new Regex(match.Value);
                    result = calc.Replace(text.Value, values[0].ToString());
                }
            }
            return result;
        }

        private string replace_PM(string text)
        {
            Regex regex = new Regex("[0-9,*/+-]*");
            Match match = regex.Match(text);
            string result = replace_MD(match);
            Regex numbersPattern = new Regex("[0-9]+");
            List<double> values = new List<double>();
            MatchCollection numbers = numbersPattern.Matches(result);
            foreach(Match number in numbers)
            {
                values.Add(Convert.ToDouble(number.Value));
            }
            Regex patternOperator = new Regex("[+-]");
            MatchCollection matchOperator = patternOperator.Matches(result);
            foreach(Match o in matchOperator)
            {
                if (o.Value == "+")
                {
                    values[0] += values[1];
                    values.RemoveAt(1);
                }
                else
                {
                    values[0] -= values[1];
                    values.RemoveAt(1);
                }
            }
            return values[0].ToString();
        }
    }
}
