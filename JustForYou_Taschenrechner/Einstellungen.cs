using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JustForYou_Taschenrechner
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
        }

        // private variables
        private Font fontsettings = new Font("Sergoe UI", 10);
        private (Color, Color, Color) mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));

        // get methods
        public Font getFont()
        {
            return this.fontsettings;
        }
        public (Color, Color, Color) getMode()
        {
            return this.mode;
        }

        // Button Click Events
        private void btn_segoeUI_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(new FontFamily("Segoe UI"), fontsettings.Size);
            setFontSettings();
        }

        private void btn_arial_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(new FontFamily("Arial"), fontsettings.Size);
            setFontSettings();
        }

        private void btn_comicSansMS_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(new FontFamily("Comic Sans MS"), fontsettings.Size);
            setFontSettings();
        }

        private void btn_size10pt_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(fontsettings.FontFamily, 10);
            setFontSettings();
        }

        private void btn_size15pt_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(fontsettings.FontFamily, 15);
            setFontSettings();
        }

        private void btn_size20pt_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(fontsettings.FontFamily, 20);
            setFontSettings();
        }


        // lightmode    ... btn_background = Control Light ;; gui_background = Control ;; ForeColor = ControlText
        // contrastmode ... btn_background = ActiveCaptionText ;; gui_background = ActiveCaptionText ;; ForeColor = ControlLightLight
        // darkmode     ... btn_background = WindowFrame ;; gui_background = WindowFrame ;; ForeColor = ControlLightLight
        private void btn_lightMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));
            setFontSettings();
        }
        private void btn_contrastMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("ActiveCaptionText"), Color.FromName("ActiveCaptionText"), Color.FromName("ControlLightLight"));
            setFontSettings();
        }

        private void btn_darkMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("WindowFrame"), Color.FromName("WindowFrame"), Color.FromName("ControlLightLight"));
            setFontSettings();
        }

        private void setFontSettings() 
        {
            this.ForeColor = mode.Item3;
            this.BackColor = mode.Item2;
            btn_arial.ForeColor = mode.Item1;
            btn_close.ForeColor = mode.Item1;
            btn_comicSansMS.ForeColor = mode.Item1;
            btn_contrastMode.ForeColor = mode.Item1;
            btn_darkMode.ForeColor = mode.Item1;
            btn_lightMode.ForeColor = mode.Item1;
            btn_segoeUI.ForeColor = mode.Item1;
            btn_size10pt.ForeColor = mode.Item1;
            btn_size15pt.ForeColor = mode.Item1;
            btn_size20pt.ForeColor = mode.Item1;

            btn_arial.Font = fontsettings;
            btn_close.Font = fontsettings;
            btn_comicSansMS.Font = fontsettings;
            btn_contrastMode.Font = fontsettings;
            btn_darkMode.Font = fontsettings;
            btn_lightMode.Font = fontsettings;
            btn_segoeUI.Font = fontsettings;
            btn_size10pt.Font = fontsettings;
            btn_size15pt.Font = fontsettings;
            btn_size20pt.Font = fontsettings;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/////////////////////////////////////////////////////
// Dies sind die Einstellungen für das Starfenster //
/////////////////////////////////////////////////////
/*
 
 private Font fontSettings = new Font("Sergoe UI", 10);
        private (Color, Color, Color) mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));

        private Einstellungen einstellungen = new Einstellungen();

        private void btn_settings_Click(object sender, EventArgs e)
        {
            einstellungen.ShowDialog();
            this.fontSettings = einstellungen.getFont();
            this.mode = einstellungen.getMode();
            changeFont();
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
 
 
 */