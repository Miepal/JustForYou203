using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JustForYou_Taschenrechner
{
    public partial class Schule : Form
    {
        public Schule()
        {
            InitializeComponent();
        }

        public void chosenFunction()
        {
            this.Close();
            Eingabemodul Eingabemodul = new Eingabemodul();
            Eingabemodul.Show();
        }


        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_settings_Click(object sender, EventArgs e)
        {
            Einstellungen Einstellungsmodul = new Einstellungen();
            Einstellungsmodul.Show();
        }

        private void b_gradeCalc_Click(object sender, EventArgs e)
        {
            chosenFunction();
        }
    }
}
