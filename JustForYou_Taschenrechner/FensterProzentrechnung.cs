using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Prozentrechnung;

namespace JustForYou_Taschenrechner
{
    public partial class FensterProzentrechnung : Form
    {
        public FensterProzentrechnung()
        {
            InitializeComponent();
        }
        modulProzentrechnung prcModule = new modulProzentrechnung();

        private List<string> result = new List<string> {"0"};
        
        public List<string> getResult()
        {
            return this.result;
        }
        private void b_add_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Prozentwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= 2) { 
                this.result[0] = Convert.ToString(prcModule.percentAdd(Convert.ToDouble(resultsInsertModule[0]), Convert.ToDouble(resultsInsertModule[1])));
                resultsInsertModule.RemoveAt(0);
                resultsInsertModule.RemoveAt(0);
                foreach(string element in resultsInsertModule)
                {
                    this.result.Add(element);
                }
            }
            this.Close();
        }
    }
}