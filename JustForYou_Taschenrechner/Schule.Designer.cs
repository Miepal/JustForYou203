
namespace JustForYou_Taschenrechner
{
    partial class Schule
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
            this.b_settings = new System.Windows.Forms.Button();
            this.b_gradeCalc = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_settings
            // 
            this.b_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_settings.Location = new System.Drawing.Point(104, 12);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(50, 50);
            this.b_settings.TabIndex = 16;
            this.b_settings.Text = "⚙";
            this.b_settings.UseVisualStyleBackColor = true;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // b_gradeCalc
            // 
            this.b_gradeCalc.Location = new System.Drawing.Point(12, 108);
            this.b_gradeCalc.Name = "b_gradeCalc";
            this.b_gradeCalc.Size = new System.Drawing.Size(196, 50);
            this.b_gradeCalc.TabIndex = 18;
            this.b_gradeCalc.Text = "Notendurchschnitt berechnen";
            this.b_gradeCalc.UseVisualStyleBackColor = true;
            this.b_gradeCalc.Click += new System.EventHandler(this.b_gradeCalc_Click);
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_close.Location = new System.Drawing.Point(160, 12);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(50, 50);
            this.b_close.TabIndex = 19;
            this.b_close.Text = "✖";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // Schule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 170);
            this.ControlBox = false;
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_gradeCalc);
            this.Controls.Add(this.b_settings);
            this.Name = "Schule";
            this.Text = "Schule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.Button b_gradeCalc;
        private System.Windows.Forms.Button b_close;
    }
}