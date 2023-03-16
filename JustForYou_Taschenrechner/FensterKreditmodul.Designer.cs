
namespace JustForYou_Taschenrechner
{
    partial class FensterKreditmodul
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
            this.btn_single_credit = new System.Windows.Forms.Button();
            this.btn_runtime_credit = new System.Windows.Forms.Button();
            this.btn_rate_credit = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_single_credit
            // 
            this.btn_single_credit.Location = new System.Drawing.Point(12, 12);
            this.btn_single_credit.Name = "btn_single_credit";
            this.btn_single_credit.Size = new System.Drawing.Size(147, 73);
            this.btn_single_credit.TabIndex = 0;
            this.btn_single_credit.Text = "Kredit Einmalzahlung";
            this.btn_single_credit.UseVisualStyleBackColor = true;
            this.btn_single_credit.Click += new System.EventHandler(this.btn_single_credit_Click);
            // 
            // btn_runtime_credit
            // 
            this.btn_runtime_credit.Location = new System.Drawing.Point(12, 92);
            this.btn_runtime_credit.Name = "btn_runtime_credit";
            this.btn_runtime_credit.Size = new System.Drawing.Size(147, 77);
            this.btn_runtime_credit.TabIndex = 1;
            this.btn_runtime_credit.Text = "Ratenkredit nach Laufzeit";
            this.btn_runtime_credit.UseVisualStyleBackColor = true;
            this.btn_runtime_credit.Click += new System.EventHandler(this.btn_runtime_credit_Click);
            // 
            // btn_rate_credit
            // 
            this.btn_rate_credit.Location = new System.Drawing.Point(12, 176);
            this.btn_rate_credit.Name = "btn_rate_credit";
            this.btn_rate_credit.Size = new System.Drawing.Size(147, 75);
            this.btn_rate_credit.TabIndex = 2;
            this.btn_rate_credit.Text = "Ratenkredit nach Rate";
            this.btn_rate_credit.UseVisualStyleBackColor = true;
            this.btn_rate_credit.Click += new System.EventHandler(this.btn_rate_credit_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(12, 278);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(50, 50);
            this.btn_settings.TabIndex = 15;
            this.btn_settings.Text = "⚙";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(82, 278);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 50);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FensterKreditmodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 340);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_rate_credit);
            this.Controls.Add(this.btn_runtime_credit);
            this.Controls.Add(this.btn_single_credit);
            this.Name = "FensterKreditmodul";
            this.Text = "FensterKreditmodul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_single_credit;
        private System.Windows.Forms.Button btn_runtime_credit;
        private System.Windows.Forms.Button btn_rate_credit;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_close;
    }
}