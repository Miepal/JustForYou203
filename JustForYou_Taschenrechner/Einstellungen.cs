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
        public Einstellungen(Font userFontSettigns, (Color, Color, Color) mode)
        {
            InitializeComponent();
            this.fontSettigns = userFontSettigns;
            this.mode = mode;
            setfontSettigns();
        }

        // private variables
        private Font fontSettigns;
        private (Color, Color, Color) mode;

        // get methods
        public (Font, (Color, Color, Color)) getFont()
        {
            return (this.fontSettigns, mode);
        }

        // Button Click Events
        private void btn_segoeUI_Click(object sender, EventArgs e)
        {
            this.fontSettigns = new Font(new FontFamily("Segoe UI"), fontSettigns.Size);
            setfontSettigns();
        }

        private void btn_arial_Click(object sender, EventArgs e)
        {
            this.fontSettigns = new Font(new FontFamily("Arial"), fontSettigns.Size);
            setfontSettigns();
        }

        private void btn_comicSansMS_Click(object sender, EventArgs e)
        {
            this.fontSettigns = new Font(new FontFamily("Comic Sans MS"), fontSettigns.Size);
            setfontSettigns();
        }

        private void btn_size10pt_Click(object sender, EventArgs e)
        {
            this.fontSettigns = new Font(fontSettigns.FontFamily, 10);
            setfontSettigns();
        }

        private void btn_size15pt_Click(object sender, EventArgs e)
        {
            this.fontSettigns = new Font(fontSettigns.FontFamily, 15);
            setfontSettigns();
        }

        private void btn_size20pt_Click(object sender, EventArgs e)
        {
            this.fontSettigns = new Font(fontSettigns.FontFamily, 20);
            setfontSettigns();
        }


        // lightmode    ... btn_background = Control Light ;; gui_background = Control ;; ForeColor = ControlText
        // contrastmode ... btn_background = ActiveCaptionText ;; gui_background = ActiveCaptionText ;; ForeColor = ControlLightLight
        // darkmode     ... btn_background = WindowFrame ;; gui_background = WindowFrame ;; ForeColor = ControlLightLight
        private void btn_lightMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));
            setfontSettigns();
        }
        private void btn_contrastMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("ActiveCaptionText"), Color.FromName("ActiveCaptionText"), Color.FromName("ControlLightLight"));
            setfontSettigns();
        }

        private void btn_darkMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("WindowFrame"), Color.FromName("WindowFrame"), Color.FromName("ControlLightLight"));
            setfontSettigns();
        }

        private void setfontSettigns() 
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

            btn_arial.Font = fontSettigns;
            btn_close.Font = fontSettigns;
            btn_comicSansMS.Font = fontSettigns;
            btn_contrastMode.Font = fontSettigns;
            btn_darkMode.Font = fontSettigns;
            btn_lightMode.Font = fontSettigns;
            btn_segoeUI.Font = fontSettigns;
            btn_size10pt.Font = fontSettigns;
            btn_size15pt.Font = fontSettigns;
            btn_size20pt.Font = fontSettigns;
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
 
 private Font fontSettigns = new Font("Sergoe UI", 10);
        private (Color, Color, Color) mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));

        private Einstellungen einstellungen = new Einstellungen();

        private void btn_settings_Click(object sender, EventArgs e)
        {
            einstellungen.ShowDialog();
            this.fontSettigns = einstellungen.getFont();
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

            btn_settings.Font = this.fontSettigns;
            b_calc.Font = this.fontSettigns;
            b_close.Font = this.fontSettigns;
            b_credit.Font = this.fontSettigns;
            b_export.Font = this.fontSettigns;
            b_geometry.Font = this.fontSettigns;
            b_import.Font = this.fontSettigns;
            b_IT.Font = this.fontSettigns;
            b_math.Font = this.fontSettigns;
            b_percent.Font = this.fontSettigns;
            b_school.Font = this.fontSettigns;

            gb_branch.ForeColor = this.mode.Item3;
            l_history.ForeColor = this.mode.Item3;
        }
 
 
 */