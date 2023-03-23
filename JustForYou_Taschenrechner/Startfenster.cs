using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace JustForYou_Taschenrechner
{
    public partial class Startfenster : Form
    {
        public Startfenster()
        {
            InitializeComponent();
            changeFont();

            this.myAes = Aes.Create();
            this.myAes.Mode = CipherMode.CBC;
            this.myAes.KeySize = 128;
            this.myAes.BlockSize = 128;
            this.myAes.FeedbackSize = 128;
            this.myAes.Padding = PaddingMode.Zeros;
            this.myAes.Key = Encoding.ASCII.GetBytes("MySuperSecretKey");
            this.myAes.GenerateIV(); 
        }

        private Font fontSettings = new Font("Sergoe UI", 10);
        private (Color, Color, Color) mode = (Color.FromName("Control Light"), Color.FromName("Control"), Color.FromName("ControlText"));
        private Aes myAes;



        static byte[] EncryptStringToBytes_Aes(string plainText, Aes myAes)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, myAes.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] plainTextBytes = Encoding.ASCII.GetBytes(plainText);
            cs.Write(plainTextBytes, 0, plainText.Length);
            var tmp = ms.ToArray();
            var tmp2 = System.Text.Encoding.ASCII.GetString(plainTextBytes);
            return tmp;

        }
        static string DecryptStringFromBytes_Aes(byte[] cipherText, Aes myAes)
        {
            byte[] plainText;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, myAes.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherText, 0, cipherText.Length);
            var test = ms.GetBuffer();
            plainText = ms.ToArray();
            var tmp = System.Text.Encoding.ASCII.GetString(plainText);
            return tmp;
        }





        private void btn_settings_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen(fontSettings, mode);
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

        private void b_calc_Click(object sender, EventArgs e)
        {
            Grundrechner calc = new Grundrechner(fontSettings, mode);
            calc.Show();
            newSettigns(calc.getFontSettings().Item1, calc.getFontSettings().Item2);
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_percent_Click(object sender, EventArgs e)
        {
            FensterProzentrechnung prc = new FensterProzentrechnung(this.fontSettings, this.mode);
            prc.ShowDialog();
            List<string> prcResults = prc.getResult();
            string tmpRTBHistory = rTB_History.Text;
            rTB_History.Text = "";
            foreach (string element in prcResults)
            {
                if (element != "NULL")
                {
                    rTB_History.AppendText(element + "\n");
                }
            }
            rTB_History.Text += tmpRTBHistory;

            newSettigns(prc.getFontSettings().Item1, prc.getFontSettings().Item2);
        }

        private void b_export_Click(object sender, EventArgs e)
        {
            Aes myAes = Aes.Create();
            string path = Path.GetDirectoryName(Application.ExecutablePath);

            path += @"\Calculator_History.txt";
            byte[] encrypted = EncryptStringToBytes_Aes(rTB_History.Text, myAes);
            File.WriteAllBytes(path,encrypted);
        }

        private void b_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filename = ofd.FileName;
            byte[] cipherText = File.ReadAllBytes(filename);
            
            rTB_History.Text = DecryptStringFromBytes_Aes(cipherText, myAes);
        }



        private void changeFont()
        {
            this.BackColor = this.mode.Item2;
            this.ForeColor = this.mode.Item3;

            btn_settings.BackColor = this.mode.Item1;
            b_calc.BackColor = this.mode.Item1;
            b_close.BackColor = this.mode.Item1;
            b_credit.BackColor = this.mode.Item1;
            b_export.BackColor = this.mode.Item1;
            b_geometry.BackColor = this.mode.Item1;
            b_import.BackColor = this.mode.Item1;
            b_IT.BackColor = this.mode.Item1;
            b_math.BackColor = this.mode.Item1;
            b_percent.BackColor = this.mode.Item1;
            b_school.BackColor = this.mode.Item1;

            btn_settings.Font = this.fontSettings;
            b_calc.Font = this.fontSettings;
            b_close.Font = this.fontSettings;
            b_credit.Font = this.fontSettings;
            b_export.Font = this.fontSettings;
            b_geometry.Font = this.fontSettings;
            b_import.Font = this.fontSettings;
            b_IT.Font = this.fontSettings;
            b_math.Font = this.fontSettings;
            b_percent.Font = this.fontSettings;
            b_school.Font = this.fontSettings;

            gb_branch.ForeColor = this.mode.Item3;
            l_history.ForeColor = this.mode.Item3;
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