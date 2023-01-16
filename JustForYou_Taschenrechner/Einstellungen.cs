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
        // event
        public delegate void notify();
        public event notify updateSettings;


        // private variables
        private Font fontsettings = new Font("Sergoe UI", 15);
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
        }

        private void btn_arial_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(new FontFamily("Arial"), fontsettings.Size);
        }

        private void btn_comicSansMS_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(new FontFamily("Comic Sans MS"), fontsettings.Size);
        }

        private void btn_size10pt_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(fontsettings.FontFamily, 10);
        }

        private void btn_size15pt_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(fontsettings.FontFamily, 15);
        }

        private void btn_size20pt_Click(object sender, EventArgs e)
        {
            this.fontsettings = new Font(fontsettings.FontFamily, 20);
        }


        // lightmode    ... btn_background = Control Light ;; gui_background = Control ;; ForeColor = ControlText
        // contrastmode ... btn_background = ActiveCaptionText ;; gui_background = ActiveCaptionText ;; ForeColor = ControlLightLight
        // darkmode     ... btn_background = WindowFrame ;; gui_background = WindowFrame ;; ForeColor = ControlLightLight
        private void btn_lightMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));
        }
        private void btn_contrastMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("ActiveCaptionText"), Color.FromName("ActiveCaptionText"), Color.FromName("ControlLightLight"));
        }

        private void btn_darkMode_Click(object sender, EventArgs e)
        {
            this.mode = (Color.FromName("WindowFrame"), Color.FromName("WindowFrame"), Color.FromName("ControlLightLight"));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (updateSettings != null)
                updateSettings();
            this.Hide();
        }
    }
}
