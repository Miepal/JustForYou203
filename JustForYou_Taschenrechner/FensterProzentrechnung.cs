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
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string prcModuleResults = prcModule.percentAdd(Convert.ToDouble(resultsInsertModule[0]), Convert.ToDouble(resultsInsertModule[1]));
                this.result[0] = Convert.ToString(prcModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            this.Close();
        }

        private void b_of_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Prozentwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string prcModuleResults = prcModule.percentFrom(Convert.ToDouble(resultsInsertModule[0]), Convert.ToDouble(resultsInsertModule[1]));
                this.result[0] = Convert.ToString(prcModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            this.Close();
        }

        private void b_part_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Prozentsatz", "Basiswert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string prcModuleResults = prcModule.percentage(Convert.ToDouble(resultsInsertModule[0]), Convert.ToDouble(resultsInsertModule[1]));
                this.result[0] = Convert.ToString(prcModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            this.Close();
        }

        private void b_sub_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Prozentwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string prcModuleResults = prcModule.percentSub(Convert.ToDouble(resultsInsertModule[0]), Convert.ToDouble(resultsInsertModule[1]));
                this.result[0] = Convert.ToString(prcModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            this.Close();
        }

        private void b_brutto_netto_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Bruttowert", "Lebensmittel? 1 = Ja" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                bool isGroceries = false;
                if (resultsInsertModule[1] == "1")
                {
                    isGroceries = true;
                }
                string prcModuleResults = prcModule.bruttoFromNetto(Convert.ToDouble(resultsInsertModule[0]), isGroceries);
                this.result[0] = Convert.ToString(prcModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            this.Close();
        }

        private void b_netto_brutto_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Nettowert", "Lebensmittel? 1 = Ja" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                bool isGroceries = false;
                if (resultsInsertModule[1] == "1")
                {
                    isGroceries = true;
                }
                string prcModuleResults = prcModule.nettoFromBrutto(Convert.ToDouble(resultsInsertModule[0]), isGroceries);
                this.result[0] = Convert.ToString(prcModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            this.Close();
        }
    }
}