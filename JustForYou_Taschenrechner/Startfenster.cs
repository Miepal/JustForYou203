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
            FensterProzentrechnung prc = new FensterProzentrechnung();
            prc.ShowDialog();
            List<string> prcResults = prc.getResult();
            foreach(string element in prcResults)
            {
                rTB_History.AppendText(element+"\n");
            }
        }

        private void b_credit_Click(object sender, EventArgs e)
        {
            FensterKreditmodul crd = new FensterKreditmodul();
            crd.ShowDialog();
            List<string> crdResult = crd.getResult();
            foreach (string elem in crdResult)
            {
                rTB_History.AppendText(elem + "\n");
            }
        }
    }
}
