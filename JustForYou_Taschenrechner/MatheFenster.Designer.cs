
namespace JustForYou_Taschenrechner
{
    partial class MatheFenster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_faculty = new System.Windows.Forms.Button();
            this.b_squareroot = new System.Windows.Forms.Button();
            this.b_pow = new System.Windows.Forms.Button();
            this.b_primes = new System.Windows.Forms.Button();
            this.b_fraction = new System.Windows.Forms.Button();
            this.b_settings = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_faculty
            // 
            this.b_faculty.Location = new System.Drawing.Point(12, 12);
            this.b_faculty.Name = "b_faculty";
            this.b_faculty.Size = new System.Drawing.Size(98, 53);
            this.b_faculty.TabIndex = 0;
            this.b_faculty.Text = "Fakultät";
            this.b_faculty.UseVisualStyleBackColor = true;
            this.b_faculty.Click += new System.EventHandler(this.b_faculty_click);
            // 
            // b_squareroot
            // 
            this.b_squareroot.Location = new System.Drawing.Point(127, 12);
            this.b_squareroot.Name = "b_squareroot";
            this.b_squareroot.Size = new System.Drawing.Size(98, 53);
            this.b_squareroot.TabIndex = 1;
            this.b_squareroot.Text = "Wurzel";
            this.b_squareroot.UseVisualStyleBackColor = true;
            this.b_squareroot.Click += new System.EventHandler(this.b_squareroot_click);
            // 
            // b_pow
            // 
            this.b_pow.Location = new System.Drawing.Point(12, 71);
            this.b_pow.Name = "b_pow";
            this.b_pow.Size = new System.Drawing.Size(98, 53);
            this.b_pow.TabIndex = 2;
            this.b_pow.Text = "Potenz";
            this.b_pow.UseVisualStyleBackColor = true;
            this.b_pow.Click += new System.EventHandler(this.b_pow_click);
            // 
            // b_primes
            // 
            this.b_primes.Location = new System.Drawing.Point(127, 71);
            this.b_primes.Name = "b_primes";
            this.b_primes.Size = new System.Drawing.Size(98, 53);
            this.b_primes.TabIndex = 3;
            this.b_primes.Text = "Primzahl";
            this.b_primes.UseVisualStyleBackColor = true;
            this.b_primes.Click += new System.EventHandler(this.b_primes_click);
            // 
            // b_fraction
            // 
            this.b_fraction.Location = new System.Drawing.Point(12, 130);
            this.b_fraction.Name = "b_fraction";
            this.b_fraction.Size = new System.Drawing.Size(213, 53);
            this.b_fraction.TabIndex = 4;
            this.b_fraction.Text = "Umwandlung Dezimalbruch";
            this.b_fraction.UseVisualStyleBackColor = true;
            this.b_fraction.Click += new System.EventHandler(this.b_fraction_click);
            // 
            // b_settings
            // 
            this.b_settings.Location = new System.Drawing.Point(36, 223);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(41, 37);
            this.b_settings.TabIndex = 6;
            this.b_settings.Text = "⚙";
            this.b_settings.UseVisualStyleBackColor = true;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(127, 215);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(98, 53);
            this.b_close.TabIndex = 7;
            this.b_close.Text = "Schließen";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // MatheFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 279);
            this.ControlBox = false;
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_settings);
            this.Controls.Add(this.b_fraction);
            this.Controls.Add(this.b_primes);
            this.Controls.Add(this.b_pow);
            this.Controls.Add(this.b_squareroot);
            this.Controls.Add(this.b_faculty);
            this.Name = "MatheFenster";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_faculty;
        private System.Windows.Forms.Button b_squareroot;
        private System.Windows.Forms.Button b_pow;
        private System.Windows.Forms.Button b_primes;
        private System.Windows.Forms.Button b_fraction;
        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.Button b_close;
    }
}