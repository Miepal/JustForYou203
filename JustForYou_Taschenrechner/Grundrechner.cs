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

        public Grundrechner(Font fontsettings, (Color, Color, Color) mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.fontSettings = fontsettings;
            changeFont();
        }
        private Font fontSettings;
        private (Color, Color, Color) mode;

        private void b_settings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen(fontSettings, mode);
            einstellungen.ShowDialog();
            this.fontSettings = einstellungen.getFont().Item1;
            this.mode = einstellungen.getFont().Item2;
            changeFont();
            einstellungen = null;
        }
        public (Font, (Color, Color, Color)) getFontSettings()
        {
            return (this.fontSettings, this.mode);
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
            if(check_forbidden_symbols())
            {
                return;
            }
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

        private bool check_forbidden_symbols()
        {
            Regex regex = new Regex("\\*\\*|\\*/|\\*\\+|/\\*|/\\+|\\+/|-/|\\+\\*|-\\*|\\d\\s\\d|,\\d*,|\\+\\+|\\-\\-|\\+\\-");
            if (regex.IsMatch(tb_formula.Text))
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
                tb_formula.Clear();
                return true;
            }
            return false;
        }
        private void changeFont()
        {
            this.BackColor = this.mode.Item2;
            this.ForeColor = this.mode.Item3;

            btn_close.BackColor = this.mode.Item1;
            b_0.BackColor = this.mode.Item1;
            b_1.BackColor = this.mode.Item1;
            b_2.BackColor = this.mode.Item1;
            b_3.BackColor = this.mode.Item1;
            b_4.BackColor = this.mode.Item1;
            b_5.BackColor = this.mode.Item1;
            b_6.BackColor = this.mode.Item1;
            b_7.BackColor = this.mode.Item1;
            b_8.BackColor = this.mode.Item1;
            b_9.BackColor = this.mode.Item1;
            b_backspace.BackColor = this.mode.Item1;
            b_clear.BackColor = this.mode.Item1;
            b_closing.BackColor = this.mode.Item1;
            b_comma.BackColor = this.mode.Item1;
            b_divide.BackColor = this.mode.Item1;
            b_equal.BackColor = this.mode.Item1;
            b_minus.BackColor = this.mode.Item1;
            b_multiply.BackColor = this.mode.Item1;
            b_opening.BackColor = this.mode.Item1;
            b_plus.BackColor = this.mode.Item1;
            b_settings.BackColor = this.mode.Item1;
            b_sign.BackColor = this.mode.Item1;

            btn_close.Font = this.fontSettings;
            b_0.Font = this.fontSettings;
            b_1.Font = this.fontSettings;
            b_2.Font = this.fontSettings;
            b_3.Font = this.fontSettings;
            b_4.Font = this.fontSettings;
            b_5.Font = this.fontSettings;
            b_6.Font = this.fontSettings;
            b_7.Font = this.fontSettings;
            b_8.Font = this.fontSettings;
            b_9.Font = this.fontSettings;
            b_backspace.Font = this.fontSettings;
            b_clear.Font = this.fontSettings;
            b_closing.Font = this.fontSettings;
            b_comma.Font = this.fontSettings;
            b_divide.Font = this.fontSettings;
            b_equal.Font = this.fontSettings;
            b_minus.Font = this.fontSettings;
            b_multiply.Font = this.fontSettings;
            b_opening.Font = this.fontSettings;
            b_plus.Font = this.fontSettings;
            b_settings.Font = this.fontSettings;
            b_sign.Font = this.fontSettings;
        }
    }
}
