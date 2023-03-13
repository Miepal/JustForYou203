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
    public partial class Eingabemodul : Form
    {
        public Eingabemodul(List<String> moduleInput)
        {
            InitializeComponent();
            variables = moduleInput;
        }
        private Font fontSettings = new Font("Sergoe UI", 10);
        private (Color, Color, Color) mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));
        private List<double> results;
        private List<String> variables;

        Einstellungen einstellungen = new Einstellungen();

        public List<double> getResult()
        {
            return this.results;
        }


        private void btn_settings_Click(object sender, EventArgs e)
        {
            einstellungen.ShowDialog();
            this.fontSettings = einstellungen.getFont();
            this.mode = einstellungen.getMode();
            changeFont();
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            tb_input.Text = tb_input.Text.Substring(0, tb_input.Text.Length - 1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_input.Text = "";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            Grundrechner basecalc = new Grundrechner();
            basecalc.ShowDialog();
        }

        private void btn_returnAsParameter_Click(object sender, EventArgs e)
        {
            if (variables.Count > results.Count)
            {
                this.results.Add(Convert.ToDouble(tb_input.Text));
            }
            if(variables.Count == results.Count)
            {
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            tb_input.Text += ",";
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            string value = tb_input.Text;
            Regex textBoxInput = new Regex(@"^-?[0-9]+$");
            Regex sign = new Regex(@"^-");
            MatchCollection matches = textBoxInput.Matches(value);
            if (matches.Count == 1)
            {
                bool isSign = sign.IsMatch(matches[0].Value);
                if (isSign)
                {
                    tb_input.Text = matches[0].Value.Remove(0, 1);
                }
                else
                {
                    tb_input.Text = "-" + tb_input.Text;
                }
            }
            else
            {
                //wrong input / no input
            } 
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_input.Text += 0;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_input.Text += 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_input.Text += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_input.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_input.Text += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_input.Text += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_input.Text += 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_input.Text += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_input.Text += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_input.Text += 9;
        }
        private void changeFont()
        {
            this.BackColor = this.mode.Item2;
            this.ForeColor = this.mode.Item3;

            btn_settings.BackColor = this.mode.Item1;
            btn_0.BackColor = this.mode.Item1;
            btn_1.BackColor = this.mode.Item1;
            btn_2.BackColor = this.mode.Item1;
            btn_3.BackColor = this.mode.Item1;
            btn_4.BackColor = this.mode.Item1;
            btn_5.BackColor = this.mode.Item1;
            btn_6.BackColor = this.mode.Item1;
            btn_7.BackColor = this.mode.Item1;
            btn_8.BackColor = this.mode.Item1;
            btn_9.BackColor = this.mode.Item1;
            btn_backspace.BackColor = this.mode.Item1;
            btn_calc.BackColor = this.mode.Item1;
            btn_clear.BackColor = this.mode.Item1;
            btn_close.BackColor = this.mode.Item1;
            btn_comma.BackColor = this.mode.Item1;
            btn_returnAsParameter.BackColor = this.mode.Item1;
            btn_settings.BackColor = this.mode.Item1;
            btn_sign.BackColor = this.mode.Item1;


            btn_settings.Font = this.fontSettings;
            btn_0.Font = this.fontSettings;
            btn_1.Font = this.fontSettings;
            btn_2.Font = this.fontSettings;
            btn_3.Font = this.fontSettings;
            btn_4.Font = this.fontSettings;
            btn_5.Font = this.fontSettings;
            btn_6.Font = this.fontSettings;
            btn_7.Font = this.fontSettings;
            btn_8.Font = this.fontSettings;
            btn_9.Font = this.fontSettings;
            btn_backspace.Font = this.fontSettings;
            btn_calc.Font = this.fontSettings;
            btn_clear.Font = this.fontSettings;
            btn_close.Font = this.fontSettings;
            btn_comma.Font = this.fontSettings;
            btn_returnAsParameter.Font = this.fontSettings;
            btn_settings.Font = this.fontSettings;
            btn_sign.Font = this.fontSettings;
        }
    }
}
