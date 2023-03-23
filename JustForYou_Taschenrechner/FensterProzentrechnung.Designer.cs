
namespace JustForYou_Taschenrechner
{
    partial class FensterProzentrechnung
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
            this.b_add_percent = new System.Windows.Forms.Button();
            this.b_sub_percent = new System.Windows.Forms.Button();
            this.b_of_percent = new System.Windows.Forms.Button();
            this.b_part_percent = new System.Windows.Forms.Button();
            this.b_brutto_netto = new System.Windows.Forms.Button();
            this.b_netto_brutto = new System.Windows.Forms.Button();
            this.b_back = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_add_percent
            // 
            this.b_add_percent.Location = new System.Drawing.Point(12, 12);
            this.b_add_percent.Name = "b_add_percent";
            this.b_add_percent.Size = new System.Drawing.Size(100, 50);
            this.b_add_percent.TabIndex = 2;
            this.b_add_percent.Text = "% dazu";
            this.b_add_percent.UseVisualStyleBackColor = true;
            this.b_add_percent.Click += new System.EventHandler(this.b_add_percent_Click);
            // 
            // b_sub_percent
            // 
            this.b_sub_percent.Location = new System.Drawing.Point(12, 124);
            this.b_sub_percent.Name = "b_sub_percent";
            this.b_sub_percent.Size = new System.Drawing.Size(100, 50);
            this.b_sub_percent.TabIndex = 3;
            this.b_sub_percent.Text = "% weg";
            this.b_sub_percent.UseVisualStyleBackColor = true;
            this.b_sub_percent.Click += new System.EventHandler(this.b_sub_percent_Click);
            // 
            // b_of_percent
            // 
            this.b_of_percent.Location = new System.Drawing.Point(118, 12);
            this.b_of_percent.Name = "b_of_percent";
            this.b_of_percent.Size = new System.Drawing.Size(100, 50);
            this.b_of_percent.TabIndex = 4;
            this.b_of_percent.Text = "% davon";
            this.b_of_percent.UseVisualStyleBackColor = true;
            this.b_of_percent.Click += new System.EventHandler(this.b_of_percent_Click);
            // 
            // b_part_percent
            // 
            this.b_part_percent.Location = new System.Drawing.Point(12, 68);
            this.b_part_percent.Name = "b_part_percent";
            this.b_part_percent.Size = new System.Drawing.Size(100, 50);
            this.b_part_percent.TabIndex = 5;
            this.b_part_percent.Text = "% Satz";
            this.b_part_percent.UseVisualStyleBackColor = true;
            this.b_part_percent.Click += new System.EventHandler(this.b_part_percent_Click);
            // 
            // b_brutto_netto
            // 
            this.b_brutto_netto.Location = new System.Drawing.Point(118, 68);
            this.b_brutto_netto.Name = "b_brutto_netto";
            this.b_brutto_netto.Size = new System.Drawing.Size(100, 50);
            this.b_brutto_netto.TabIndex = 6;
            this.b_brutto_netto.Text = "Bruttopreis aus Nettopreis";
            this.b_brutto_netto.UseVisualStyleBackColor = true;
            this.b_brutto_netto.Click += new System.EventHandler(this.b_brutto_netto_Click);
            // 
            // b_netto_brutto
            // 
            this.b_netto_brutto.Location = new System.Drawing.Point(118, 124);
            this.b_netto_brutto.Name = "b_netto_brutto";
            this.b_netto_brutto.Size = new System.Drawing.Size(100, 50);
            this.b_netto_brutto.TabIndex = 7;
            this.b_netto_brutto.Text = "Nettopreis aus Bruttopreis";
            this.b_netto_brutto.UseVisualStyleBackColor = true;
            this.b_netto_brutto.Click += new System.EventHandler(this.b_netto_brutto_Click);
            // 
            // b_back
            // 
            this.b_back.Location = new System.Drawing.Point(118, 221);
            this.b_back.Name = "b_back";
            this.b_back.Size = new System.Drawing.Size(100, 50);
            this.b_back.TabIndex = 8;
            this.b_back.Text = "Schließen";
            this.b_back.UseVisualStyleBackColor = true;
            this.b_back.Click += new System.EventHandler(this.b_back_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(12, 221);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(50, 50);
            this.btn_settings.TabIndex = 14;
            this.btn_settings.Text = "⚙";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // FensterProzentrechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 284);
            this.ControlBox = false;
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.b_back);
            this.Controls.Add(this.b_netto_brutto);
            this.Controls.Add(this.b_brutto_netto);
            this.Controls.Add(this.b_part_percent);
            this.Controls.Add(this.b_of_percent);
            this.Controls.Add(this.b_sub_percent);
            this.Controls.Add(this.b_add_percent);
            this.Name = "FensterProzentrechnung";
            this.Text = "Prozentrechnungsmodul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_add_percent;
        private System.Windows.Forms.Button b_sub_percent;
        private System.Windows.Forms.Button b_of_percent;
        private System.Windows.Forms.Button b_part_percent;
        private System.Windows.Forms.Button b_brutto_netto;
        private System.Windows.Forms.Button b_netto_brutto;
        private System.Windows.Forms.Button b_back;
        private System.Windows.Forms.Button btn_settings;
    }
}