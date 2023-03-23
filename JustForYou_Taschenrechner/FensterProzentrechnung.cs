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
        public FensterProzentrechnung(Font startfensterFontSettings, (Color, Color, Color) startfensterMode)
        {
            InitializeComponent();
            this.fontSettings = startfensterFontSettings;
            this.mode = startfensterMode;
            changeFont();
        }
        
        // settings color, Font and more
        private Font fontSettings;
        private (Color, Color, Color) mode;

        public (Font, (Color, Color, Color)) getFontSettings()
        {
            return (this.fontSettings,this.mode);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen(fontSettings,mode);
            einstellungen.ShowDialog();
            this.fontSettings = einstellungen.getFont().Item1;
            this.mode = einstellungen.getFont().Item2;
            changeFont();
            einstellungen = null;
        }
        private void newSettigns(Font fontSettings, (Color, Color, Color) mode)
        {
            this.fontSettings = fontSettings;
            this.mode = mode;
            changeFont();
        }
        ///////////////
        // variables //
        ///////////////

        modulProzentrechnung prcModule = new modulProzentrechnung();

        private List<string> result = new List<string> {"NULL"};
        
        public List<string> getResult()
        {
            return this.result;
        }
        private void b_add_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Prozentwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables,fontSettings,mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (neededVariables[neededVariables.Count - 1] != resultsInsertModule[neededVariables.Count - 1])
            {
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
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_of_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Prozentwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables,fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (neededVariables[neededVariables.Count - 1] != resultsInsertModule[neededVariables.Count - 1])
            {
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
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_part_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Prozentsatz", "Basiswert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (neededVariables[neededVariables.Count - 1] != resultsInsertModule[neededVariables.Count - 1])
            {
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
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_sub_percent_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Prozentwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (neededVariables[neededVariables.Count - 1] != resultsInsertModule[neededVariables.Count - 1])
            {
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
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_brutto_netto_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Bruttowert", "Lebensmittel? 1 = Ja" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (neededVariables[neededVariables.Count - 1] != resultsInsertModule[neededVariables.Count - 1])
            {
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
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_netto_brutto_Click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Nettowert", "Lebensmittel? 1 = Ja" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (neededVariables[neededVariables.Count - 1] != resultsInsertModule[neededVariables.Count - 1])
            {
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
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeFont()
        {
            this.BackColor = this.mode.Item2;
            this.ForeColor = this.mode.Item3;

            btn_settings.BackColor = this.mode.Item1;
            b_add_percent.BackColor = this.mode.Item1;
            b_back.BackColor = this.mode.Item1;
            b_brutto_netto.BackColor = this.mode.Item1;
            b_netto_brutto.BackColor = this.mode.Item1;
            b_of_percent.BackColor = this.mode.Item1;
            b_part_percent.BackColor = this.mode.Item1;
            b_sub_percent.BackColor = this.mode.Item1;
            
            btn_settings.Font = this.fontSettings;
            b_add_percent.Font = this.fontSettings;
            b_back.Font = this.fontSettings;
            b_brutto_netto.Font = this.fontSettings;
            b_netto_brutto.Font = this.fontSettings;
            b_of_percent.Font = this.fontSettings;
            b_part_percent.Font = this.fontSettings;
            b_sub_percent.Font = this.fontSettings;
        }
    }
}