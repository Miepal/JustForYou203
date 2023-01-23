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

        private void b_geometry_Click(object sender, EventArgs e)
        {
            Geometrie Geometriemodul = new Geometrie();
            Geometriemodul.Show();
        }

        private void b_school_Click(object sender, EventArgs e)
        {
            Schule Schulmodul = new Schule();
            Schulmodul.Show();
           
        }

        private void b_percent_Click(object sender, EventArgs e)
        {
            Prozentrechnung Prozentrechnungsmodul = new Prozentrechnung();
            Prozentrechnungsmodul.Show();
            
        }

        private void b_calc_Click(object sender, EventArgs e)
        {
            Grundrechner Grundrechnermodul = new Grundrechner();
            Grundrechnermodul.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Einstellungen Einstellungsmodul = new Einstellungen();
            Einstellungsmodul.Show();
        }
    }
}
