using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mathe;

namespace JustForYou_Taschenrechner
{
    public partial class MatheFenster : Form
    {
        public MatheFenster(Font fontSettings, (Color, Color, Color) mode)
        {
            InitializeComponent();
            this.fontSettings = fontSettings;
            this.mode = mode;
            changeFont();
        }

        // settings color, Font and more
        private Font fontSettings;
        private (Color, Color, Color) mode;

        public (Font, (Color, Color, Color)) getFontSettings()
        {
            return (this.fontSettings, this.mode);
        }

        private void newSettigns(Font fontSettings, (Color, Color, Color) mode)
        {
            this.fontSettings = fontSettings;
            this.mode = mode;
            changeFont();
        }




        private void b_settings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen(fontSettings,mode);
            einstellungen.ShowDialog();
            this.fontSettings = einstellungen.getFont().Item1;
            this.mode = einstellungen.getFont().Item2;
            changeFont();
            einstellungen = null;
        }

        ///////////////
        // variables //
        ///////////////

        modulMathe mthModule = new modulMathe();

        private List<string> result = new List<string> { "NULL" };

        public List<string> getResult()
        {
            return this.result;
        }

        private void b_faculty_click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Fakultät von:" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables,fontSettings,mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string mthModuleResults = mthModule.faculty(Convert.ToInt32(resultsInsertModule[0]));
                this.result[0] = Convert.ToString(mthModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_squareroot_click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Quadratwurzel von:" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string mthModuleResults = mthModule.squareRoot(Convert.ToDouble(resultsInsertModule[0]));
                this.result[0] = Convert.ToString(mthModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_pow_click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Basiswert", "Potenz" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string mthModuleResults = mthModule.pow(Convert.ToDouble(resultsInsertModule[0]), Convert.ToInt32(resultsInsertModule[1]));
                this.result[0] = Convert.ToString(mthModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_primes_click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Startwert", "Endwert" };
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string mthModuleResults = mthModule.primes(Convert.ToInt32(resultsInsertModule[0]), Convert.ToInt32(resultsInsertModule[1]));
                this.result[0] = Convert.ToString(mthModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void b_fraction_click(object sender, EventArgs e)
        {
            List<string> neededVariables = new List<string> { "Zahl"};
            Eingabemodul insertModule = new Eingabemodul(neededVariables, fontSettings, mode);
            insertModule.ShowDialog();
            List<string> resultsInsertModule = insertModule.getResult();
            if (resultsInsertModule.Count >= neededVariables.Count)
            {
                string mthModuleResults = mthModule.decimalFraction(Convert.ToDouble(resultsInsertModule[0]));
                this.result[0] = Convert.ToString(mthModuleResults);
                for (int i = 0; i < neededVariables.Count; ++i)
                {
                    resultsInsertModule.RemoveAt(0);
                }
                this.result.AddRange(resultsInsertModule);
            }
            newSettigns(insertModule.getFontSettings().Item1, insertModule.getFontSettings().Item2);
            this.Close();
        }

        private void changeFont()
        {
            this.BackColor = this.mode.Item2;
            this.ForeColor = this.mode.Item3;

            b_close.BackColor = this.mode.Item1;
            b_faculty.BackColor = this.mode.Item1;
            b_fraction.BackColor = this.mode.Item1;
            b_pow.BackColor = this.mode.Item1;
            b_primes.BackColor = this.mode.Item1;
            b_settings.BackColor = this.mode.Item1;
            b_squareroot.BackColor = this.mode.Item1;

            b_squareroot.Font = this.fontSettings;
            b_settings.Font = this.fontSettings;
            b_primes.Font = this.fontSettings;
            b_pow.Font = this.fontSettings;
            b_fraction.Font = this.fontSettings;
            b_faculty.Font = this.fontSettings;
            b_close.Font = this.fontSettings;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
