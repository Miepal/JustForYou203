using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KreditModul;

namespace JustForYou_Taschenrechner
{
    public partial class FensterKreditmodul : Form
    {
        public FensterKreditmodul()
        {
            InitializeComponent();
        }

        private modulKredit crd = new modulKredit();

        private List<string> result = new List<string> { "0" };

        public List<string> getResult()
        {
            return result;
        }

        private void btn_single_credit_Click(object sender, EventArgs e)
        {
            List<string> requested = new List<string> { "Kredithöhe", "Zinssatz" };
            Eingabemodul insertModule = new Eingabemodul(requested);
            insertModule.ShowDialog();

        }

        private void btn_runtime_credit_Click(object sender, EventArgs e)
        {

        }

        private void btn_rate_credit_Click(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }
    }
}
