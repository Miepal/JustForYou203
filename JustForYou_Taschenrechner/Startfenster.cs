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

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen();
            einstellungen.Show();
        }
    }
}
