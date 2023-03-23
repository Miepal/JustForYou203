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

        private List<string> result = new List<string>();

        public List<string> getResult()
        {
            return result;
        }

        private void btn_single_credit_Click(object sender, EventArgs e)
        {
            List<string> requested = new List<string> { "Kredithöhe in €", "Zinssatz in %", "Laufzeit in Monaten" };
            Eingabemodul insertModule = new Eingabemodul(requested);
            insertModule.ShowDialog();
            List<string> resultInput = insertModule.getResult();
            if (resultInput.Count >= 3)
            {
                result.AddRange(crd.singleCredit(Convert.ToDouble(resultInput[0]), Convert.ToDouble(resultInput[1]), Convert.ToDouble(resultInput[2])));
                resultInput.RemoveRange(0, 3);
                result.AddRange(resultInput);
            }
            Close();
        }

        private void btn_runtime_credit_Click(object sender, EventArgs e)
        {
            List<string> requested = new List<string> { "Kredithöhe in €", "Zinssatz in %", "Laufzeit in Monaten" };
            Eingabemodul insertModule = new Eingabemodul(requested);
            insertModule.ShowDialog();
            List<string> resultInput = insertModule.getResult();
            if (resultInput.Count >= 3)
            {
                result.AddRange(crd.rateTime(Convert.ToDouble(resultInput[0]), Convert.ToDouble(resultInput[1]), Convert.ToDouble(resultInput[2])));
                resultInput.RemoveRange(0, 3);
                result.AddRange(resultInput);
            }
            Close();
        }

        private void btn_rate_credit_Click(object sender, EventArgs e)
        {
            List<string> requested = new List<string> { "Kredithöhe in €", "Zinssatz in %", "Rate in €" };
            Eingabemodul insertModule = new Eingabemodul(requested);
            insertModule.ShowDialog();
            List<string> resultInput = insertModule.getResult();
            if (resultInput.Count >= 3)
            {
                result.AddRange(crd.rateAmount(Convert.ToDouble(resultInput[0]), Convert.ToDouble(resultInput[1]), Convert.ToDouble(resultInput[2])));
                resultInput.RemoveRange(0, 3);
                result.AddRange(resultInput);
            }
            Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
