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
        public Eingabemodul()
        {
            InitializeComponent();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {

        }

        private void btn_returnAsParameter_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void btn_comma_Click(object sender, EventArgs e)
        {

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
                    tb_input.Text = matches[0].Value.Remove(0,1)
                }
                else
                {
                    tb_input.Text = "-" + tb_input.Text;
                }
            }
            else
            {

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
    }
}
