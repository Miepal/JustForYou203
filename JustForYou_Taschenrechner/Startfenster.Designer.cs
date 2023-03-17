
namespace JustForYou_Taschenrechner
{
    partial class Startfenster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rTB_History = new System.Windows.Forms.RichTextBox();
            this.l_history = new System.Windows.Forms.Label();
            this.gb_branch = new System.Windows.Forms.GroupBox();
            this.b_IT = new System.Windows.Forms.Button();
            this.b_school = new System.Windows.Forms.Button();
            this.b_math = new System.Windows.Forms.Button();
            this.b_geometry = new System.Windows.Forms.Button();
            this.b_credit = new System.Windows.Forms.Button();
            this.b_percent = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.b_export = new System.Windows.Forms.Button();
            this.b_import = new System.Windows.Forms.Button();
            this.b_calc = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.gb_branch.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTB_History
            // 
            this.rTB_History.Location = new System.Drawing.Point(13, 42);
            this.rTB_History.Name = "rTB_History";
            this.rTB_History.Size = new System.Drawing.Size(258, 551);
            this.rTB_History.TabIndex = 0;
            this.rTB_History.Text = "";
            // 
            // l_history
            // 
            this.l_history.AutoSize = true;
            this.l_history.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_history.Location = new System.Drawing.Point(84, 9);
            this.l_history.Name = "l_history";
            this.l_history.Size = new System.Drawing.Size(79, 25);
            this.l_history.TabIndex = 1;
            this.l_history.Text = "Historie";
            // 
            // gb_branch
            // 
            this.gb_branch.Controls.Add(this.b_IT);
            this.gb_branch.Controls.Add(this.b_school);
            this.gb_branch.Controls.Add(this.b_math);
            this.gb_branch.Controls.Add(this.b_geometry);
            this.gb_branch.Controls.Add(this.b_credit);
            this.gb_branch.Controls.Add(this.b_percent);
            this.gb_branch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_branch.Location = new System.Drawing.Point(277, 69);
            this.gb_branch.Name = "gb_branch";
            this.gb_branch.Size = new System.Drawing.Size(149, 371);
            this.gb_branch.TabIndex = 9;
            this.gb_branch.TabStop = false;
            this.gb_branch.Text = "Branchenauswahl";
            // 
            // b_IT
            // 
            this.b_IT.Location = new System.Drawing.Point(6, 311);
            this.b_IT.Name = "b_IT";
            this.b_IT.Size = new System.Drawing.Size(136, 51);
            this.b_IT.TabIndex = 5;
            this.b_IT.Text = "Informationstechnik";
            this.b_IT.UseVisualStyleBackColor = true;
            // 
            // b_school
            // 
            this.b_school.Location = new System.Drawing.Point(6, 254);
            this.b_school.Name = "b_school";
            this.b_school.Size = new System.Drawing.Size(136, 51);
            this.b_school.TabIndex = 4;
            this.b_school.Text = "Schule";
            this.b_school.UseVisualStyleBackColor = true;
            // 
            // b_math
            // 
            this.b_math.Location = new System.Drawing.Point(6, 197);
            this.b_math.Name = "b_math";
            this.b_math.Size = new System.Drawing.Size(136, 51);
            this.b_math.TabIndex = 3;
            this.b_math.Text = "Mathematische Funktionen";
            this.b_math.UseVisualStyleBackColor = true;
            // 
            // b_geometry
            // 
            this.b_geometry.Location = new System.Drawing.Point(6, 140);
            this.b_geometry.Name = "b_geometry";
            this.b_geometry.Size = new System.Drawing.Size(136, 51);
            this.b_geometry.TabIndex = 2;
            this.b_geometry.Text = "Geometrie";
            this.b_geometry.UseVisualStyleBackColor = true;
            // 
            // b_credit
            // 
            this.b_credit.Location = new System.Drawing.Point(6, 83);
            this.b_credit.Name = "b_credit";
            this.b_credit.Size = new System.Drawing.Size(136, 51);
            this.b_credit.TabIndex = 1;
            this.b_credit.Text = "Kreditrechnung";
            this.b_credit.UseVisualStyleBackColor = true;
            // 
            // b_percent
            // 
            this.b_percent.Location = new System.Drawing.Point(6, 26);
            this.b_percent.Name = "b_percent";
            this.b_percent.Size = new System.Drawing.Size(136, 51);
            this.b_percent.TabIndex = 0;
            this.b_percent.Text = "Prozentrechnung";
            this.b_percent.UseVisualStyleBackColor = true;
            this.b_percent.Click += new System.EventHandler(this.b_percent_Click);
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_close.Location = new System.Drawing.Point(386, 12);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(40, 40);
            this.b_close.TabIndex = 10;
            this.b_close.Text = "✖";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_export
            // 
            this.b_export.Location = new System.Drawing.Point(283, 517);
            this.b_export.Name = "b_export";
            this.b_export.Size = new System.Drawing.Size(136, 35);
            this.b_export.TabIndex = 11;
            this.b_export.Text = "Historie exportieren";
            this.b_export.UseVisualStyleBackColor = true;
            // 
            // b_import
            // 
            this.b_import.Location = new System.Drawing.Point(283, 558);
            this.b_import.Name = "b_import";
            this.b_import.Size = new System.Drawing.Size(136, 35);
            this.b_import.TabIndex = 12;
            this.b_import.Text = "Historie importieren";
            this.b_import.UseVisualStyleBackColor = true;
            // 
            // b_calc
            // 
            this.b_calc.Location = new System.Drawing.Point(283, 460);
            this.b_calc.Name = "b_calc";
            this.b_calc.Size = new System.Drawing.Size(136, 51);
            this.b_calc.TabIndex = 6;
            this.b_calc.Text = "Grundrechner";
            this.b_calc.UseVisualStyleBackColor = true;
            this.b_calc.Click += new System.EventHandler(this.b_calc_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(340, 12);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(40, 40);
            this.btn_settings.TabIndex = 13;
            this.btn_settings.Text = "⚙";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // Startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 601);
            this.ControlBox = false;
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.b_calc);
            this.Controls.Add(this.b_import);
            this.Controls.Add(this.b_export);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.gb_branch);
            this.Controls.Add(this.l_history);
            this.Controls.Add(this.rTB_History);
            this.Name = "Startfenster";
            this.Text = "Startfenster";
            this.gb_branch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTB_History;
        private System.Windows.Forms.Label l_history;
        private System.Windows.Forms.GroupBox gb_branch;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_export;
        private System.Windows.Forms.Button b_import;
        private System.Windows.Forms.Button b_IT;
        private System.Windows.Forms.Button b_school;
        private System.Windows.Forms.Button b_math;
        private System.Windows.Forms.Button b_geometry;
        private System.Windows.Forms.Button b_credit;
        private System.Windows.Forms.Button b_percent;
        private System.Windows.Forms.Button b_calc;
        private System.Windows.Forms.Button btn_settings;
    }
}

