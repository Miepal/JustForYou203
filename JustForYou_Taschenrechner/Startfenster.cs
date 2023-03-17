using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustForYou_Taschenrechner
{
    public partial class Startfenster : Form
    {
        public Startfenster()
        {
            InitializeComponent();
        }

        private Font fontSettings = new Font("Sergoe UI", 10);
        private (Color, Color, Color) mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen();
            einstellungen.ShowDialog();
            this.fontSettings = einstellungen.getFont();
            this.mode = einstellungen.getMode();
            changeFont();
            einstellungen = null;
        }
         
        private void newSettigns(Font fontSettings, (Color, Color, Color) mode)
        {
            this.fontSettings = fontSettings;
            this.mode = mode;
        }









        private void b_calc_Click(object sender, EventArgs e)
        {
            Grundrechner calc = new Grundrechner();
            calc.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {

        }

        private void b_percent_Click(object sender, EventArgs e)
        {
            FensterProzentrechnung prc = new FensterProzentrechnung(this.fontSettings, this.mode);
            prc.ShowDialog();
            List<string> prcResults = prc.getResult();
            foreach(string element in prcResults)
            {
                if (element != "NULL")
                {
                    rTB_History.AppendText(element + "\n");
                }
            }
        }

        private void changeFont()
        {
            this.BackColor = this.mode.Item2;
            this.ForeColor = this.mode.Item3;

            btn_settings.BackColor = this.mode.Item1;
            b_calc.BackColor = this.mode.Item1;
            b_close.BackColor = this.mode.Item1;
            b_credit.BackColor = this.mode.Item1;
            b_export.BackColor = this.mode.Item1;
            b_geometry.BackColor = this.mode.Item1;
            b_import.BackColor = this.mode.Item1;
            b_IT.BackColor = this.mode.Item1;
            b_math.BackColor = this.mode.Item1;
            b_percent.BackColor = this.mode.Item1;
            b_school.BackColor = this.mode.Item1;

            btn_settings.Font = this.fontSettings;
            b_calc.Font = this.fontSettings;
            b_close.Font = this.fontSettings;
            b_credit.Font = this.fontSettings;
            b_export.Font = this.fontSettings;
            b_geometry.Font = this.fontSettings;
            b_import.Font = this.fontSettings;
            b_IT.Font = this.fontSettings;
            b_math.Font = this.fontSettings;
            b_percent.Font = this.fontSettings;
            b_school.Font = this.fontSettings;

            gb_branch.ForeColor = this.mode.Item3;
            l_history.ForeColor = this.mode.Item3;
        }
    }
}
