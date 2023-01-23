using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JustForYou_Taschenrechner
{
    public partial class Geometrie : Form
    {
        public Geometrie()
        {
            InitializeComponent();
        }

        public void chosenFunction()
        {
            this.Close();
            Eingabemodul Eingabemodul = new Eingabemodul();
            Eingabemodul.Show();
        }



        private void Geometrie_Load(object sender, EventArgs e)
        {

        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void b_add_percent_Click(object sender, EventArgs e)
        {
            chosenFunction();
        }

        private void b_settings_Click(object sender, EventArgs e)
        {
            Einstellungen Einstellungsmodul = new Einstellungen();
            Einstellungsmodul.Show();
        }

        private void b_calc_circle_Click(object sender, EventArgs e)
        {
            chosenFunction();
        }

        private void b_parallelogram_Click(object sender, EventArgs e)
        {
            chosenFunction();
        }
    }
}
