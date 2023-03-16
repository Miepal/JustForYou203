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
        private List<string> result = new List<string> {"0"};

        public Grundrechner()
        {
            InitializeComponent();
        }

        public List<string> getResult()
        {
            return result;
        }

        public void setResult(string data)
        {
            result[0] = data;
        }

        public void addFormula(string formula) 
        {
            result.Add(formula);
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
            tb_formula.Text = tb_formula.Text.Remove(tb_formula.Text.Length - 1);
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
            check_forbidden_symbols();
            string formula = tb_formula.Text;
            Regex numberBracketFront = new Regex("\\d\\(");
            
            Regex minusPattern = new Regex("([^\\d]-\\d)|(^-\\d)");
            MatchCollection minusSigns = minusPattern.Matches(formula);
            foreach(Match match in minusSigns)
            {
                string[] workingString = new string[match.Value.Length];
                for(int i = 0; i < match.Value.Length; i++)
                {
                    if(match.Value[i].ToString() == "-")
                    {
                        workingString[i] = "MINUS";
                    }
                    else
                    {
                        workingString[i] = match.Value[i].ToString();
                    }
                }
                string minusReplacer = String.Join("", workingString);
                Regex regex = new Regex(match.Value);
                formula = regex.Replace(formula, minusReplacer);
            }
            Regex checkBracket = new Regex("[\\(\\)]");
            while (checkBracket.IsMatch(formula)) 
            { 
                Regex regex = new Regex("\\(\\d*[^()]\\d*\\)");
                MatchCollection matches = regex.Matches(formula);
                if(matches.Count != 0)
                {
                    foreach (Match match in matches)
                    {
                        string currentMatch = match.Value;
                        Regex escapeSign = new Regex("[\\(\\)+*]");
                        foreach(Match specialSign in escapeSign.Matches(currentMatch))
                        {
                            string escapedSign = "\\" + specialSign.Value;
                            Regex oneSign = new Regex(escapedSign);
                            currentMatch = oneSign.Replace(currentMatch, escapedSign);
                        }
                        Regex patternBracket = new Regex(currentMatch);
                        formula = patternBracket.Replace(formula, replace_PM(match.Value));
                    }
                    matches = regex.Matches(formula);
                }
            }
            string tmpResult = replace_PM(formula);
            tb_output.Text = tmpResult;
            setResult(tmpResult);
            addFormula(tb_formula.Text + " = " + tmpResult);
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
            Regex regex = new Regex("[\\d\\w,/*]+");
            string result = text.Value;
            MatchCollection matches = regex.Matches(text.Value);
            if(matches.Count != 0)
            {
                foreach (Match match in matches)
                {
                    Regex reg = new Regex("(MINUS)?[\\d,]+");
                    MatchCollection numbers = reg.Matches(match.Value);
                    List<double> values = new List<double>();
                    foreach (Match number in numbers)
                    {
                        Regex signPattern = new Regex("MINUS");
                        if (signPattern.IsMatch(number.Value))
                        {
                            string a = signPattern.Replace(number.Value, "-");
                            values.Add(Convert.ToDouble(a));
                        }
                        else
                        {
                            values.Add(Convert.ToDouble(number.Value));
                        }
                    }
                    Regex regexOperator = new Regex("[*/]");
                    MatchCollection matchOperator = regexOperator.Matches(match.Value);
                    string newPattern = values[0].ToString();
                    foreach(Match o in matchOperator)
                    {
                        if(o.Value == "*")
                        {
                            newPattern = newPattern + "\\*" + values[1];
                            values[0] *= values[1];
                            values.RemoveAt(1);
                        }
                        else
                        {
                            newPattern = newPattern + "/" + values[1];
                            values[0] /= values[1];
                            values.RemoveAt(1);
                        }
                    }
                    Regex calc = new Regex(newPattern);
                    result = calc.Replace(result, values[0].ToString());
                }
            }
            return result;
        }

        private string replace_PM(string text)
        {
            Regex regex = new Regex("[\\w\\d,*/+-]+");
            Match match = regex.Match(text);
            string result = replace_MD(match);
            Regex numbersPattern = new Regex("(MINUS)?[\\d,]+");
            List<double> values = new List<double>();
            MatchCollection numbers = numbersPattern.Matches(result);
            foreach(Match number in numbers)
            {
                Regex signPattern = new Regex("MINUS");
                if (signPattern.IsMatch(number.Value))
                {
                    string a = signPattern.Replace(number.Value, "-");
                    values.Add(Convert.ToDouble(a));
                }
                else
                {
                    values.Add(Convert.ToDouble(number.Value));
                }
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

        private void tb_formula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tb_formula.Text.Length >= 2)
            {
                if (tb_formula.Text[tb_formula.Text.Length - 1] == '(' && Char.IsDigit(tb_formula.Text[tb_formula.Text.Length - 2]))
                {
                    tb_formula.Text = tb_formula.Text.Remove(tb_formula.Text.Length - 1);
                    tb_formula.Text += "*(";
                }
                else if (tb_formula.Text[tb_formula.Text.Length - 2] == ')' && (Char.IsDigit(tb_formula.Text[tb_formula.Text.Length - 1]) || tb_formula.Text[tb_formula.Text.Length - 1] == '('))
                {
                    string num = tb_formula.Text[tb_formula.Text.Length - 1].ToString();
                    tb_formula.Text = tb_formula.Text.Remove(tb_formula.Text.Length - 1);
                    tb_formula.Text += ("*" + num);
                }
                tb_formula.Select(tb_formula.Text.Length, 0);
            }
        }

        private void check_forbidden_symbols()
        {
            Regex regex = new Regex("\\*\\*|\\*/|\\*\\+|/\\*|/\\+|\\+/|-/|\\+\\*|-\\*|\\d\\s\\d|,\\d*,");
            if (regex.IsMatch(tb_formula.Text))
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
                tb_formula.Clear();
                return;
            }
        }
    }
}
