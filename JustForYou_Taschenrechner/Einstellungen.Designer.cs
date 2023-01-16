
namespace JustForYou_Taschenrechner
{
    partial class Einstellungen
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
            this.btn_segoeUI = new System.Windows.Forms.Button();
            this.btn_arial = new System.Windows.Forms.Button();
            this.btn_comicSansMS = new System.Windows.Forms.Button();
            this.gb_font = new System.Windows.Forms.GroupBox();
            this.gb_fontSize = new System.Windows.Forms.GroupBox();
            this.btn_size10pt = new System.Windows.Forms.Button();
            this.btn_size15pt = new System.Windows.Forms.Button();
            this.btn_size20pt = new System.Windows.Forms.Button();
            this.gb_backgroundColor = new System.Windows.Forms.GroupBox();
            this.btn_lightMode = new System.Windows.Forms.Button();
            this.btn_contrastMode = new System.Windows.Forms.Button();
            this.btn_darkMode = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_font.SuspendLayout();
            this.gb_fontSize.SuspendLayout();
            this.gb_backgroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_segoeUI
            // 
            this.btn_segoeUI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_segoeUI.Location = new System.Drawing.Point(6, 22);
            this.btn_segoeUI.Name = "btn_segoeUI";
            this.btn_segoeUI.Size = new System.Drawing.Size(136, 51);
            this.btn_segoeUI.TabIndex = 0;
            this.btn_segoeUI.Text = "Segoe UI";
            this.btn_segoeUI.UseVisualStyleBackColor = false;
            this.btn_segoeUI.Click += new System.EventHandler(this.btn_segoeUI_Click);
            // 
            // btn_arial
            // 
            this.btn_arial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_arial.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_arial.Location = new System.Drawing.Point(157, 22);
            this.btn_arial.Name = "btn_arial";
            this.btn_arial.Size = new System.Drawing.Size(136, 51);
            this.btn_arial.TabIndex = 1;
            this.btn_arial.Text = "Arial";
            this.btn_arial.UseVisualStyleBackColor = false;
            this.btn_arial.Click += new System.EventHandler(this.btn_arial_Click);
            // 
            // btn_comicSansMS
            // 
            this.btn_comicSansMS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_comicSansMS.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_comicSansMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_comicSansMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_comicSansMS.Location = new System.Drawing.Point(309, 22);
            this.btn_comicSansMS.Name = "btn_comicSansMS";
            this.btn_comicSansMS.Size = new System.Drawing.Size(136, 51);
            this.btn_comicSansMS.TabIndex = 2;
            this.btn_comicSansMS.Text = "Comic Sans MS";
            this.btn_comicSansMS.UseVisualStyleBackColor = false;
            this.btn_comicSansMS.Click += new System.EventHandler(this.btn_comicSansMS_Click);
            // 
            // gb_font
            // 
            this.gb_font.Controls.Add(this.btn_segoeUI);
            this.gb_font.Controls.Add(this.btn_arial);
            this.gb_font.Controls.Add(this.btn_comicSansMS);
            this.gb_font.Location = new System.Drawing.Point(24, 25);
            this.gb_font.Name = "gb_font";
            this.gb_font.Size = new System.Drawing.Size(454, 100);
            this.gb_font.TabIndex = 9;
            this.gb_font.TabStop = false;
            this.gb_font.Text = "Schriftart";
            // 
            // gb_fontSize
            // 
            this.gb_fontSize.Controls.Add(this.btn_size10pt);
            this.gb_fontSize.Controls.Add(this.btn_size15pt);
            this.gb_fontSize.Controls.Add(this.btn_size20pt);
            this.gb_fontSize.Location = new System.Drawing.Point(24, 142);
            this.gb_fontSize.Name = "gb_fontSize";
            this.gb_fontSize.Size = new System.Drawing.Size(454, 100);
            this.gb_fontSize.TabIndex = 10;
            this.gb_fontSize.TabStop = false;
            this.gb_fontSize.Text = "Schriftgröße";
            // 
            // btn_size10pt
            // 
            this.btn_size10pt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_size10pt.Location = new System.Drawing.Point(6, 22);
            this.btn_size10pt.Name = "btn_size10pt";
            this.btn_size10pt.Size = new System.Drawing.Size(136, 51);
            this.btn_size10pt.TabIndex = 0;
            this.btn_size10pt.Text = "10pt";
            this.btn_size10pt.UseVisualStyleBackColor = false;
            this.btn_size10pt.Click += new System.EventHandler(this.btn_size10pt_Click);
            // 
            // btn_size15pt
            // 
            this.btn_size15pt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_size15pt.Location = new System.Drawing.Point(157, 22);
            this.btn_size15pt.Name = "btn_size15pt";
            this.btn_size15pt.Size = new System.Drawing.Size(136, 51);
            this.btn_size15pt.TabIndex = 1;
            this.btn_size15pt.Text = "15pt";
            this.btn_size15pt.UseVisualStyleBackColor = false;
            this.btn_size15pt.Click += new System.EventHandler(this.btn_size15pt_Click);
            // 
            // btn_size20pt
            // 
            this.btn_size20pt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_size20pt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_size20pt.Location = new System.Drawing.Point(309, 22);
            this.btn_size20pt.Name = "btn_size20pt";
            this.btn_size20pt.Size = new System.Drawing.Size(136, 51);
            this.btn_size20pt.TabIndex = 2;
            this.btn_size20pt.Text = "20pt";
            this.btn_size20pt.UseVisualStyleBackColor = false;
            this.btn_size20pt.Click += new System.EventHandler(this.btn_size20pt_Click);
            // 
            // gb_backgroundColor
            // 
            this.gb_backgroundColor.Controls.Add(this.btn_lightMode);
            this.gb_backgroundColor.Controls.Add(this.btn_contrastMode);
            this.gb_backgroundColor.Controls.Add(this.btn_darkMode);
            this.gb_backgroundColor.Location = new System.Drawing.Point(24, 259);
            this.gb_backgroundColor.Name = "gb_backgroundColor";
            this.gb_backgroundColor.Size = new System.Drawing.Size(454, 100);
            this.gb_backgroundColor.TabIndex = 10;
            this.gb_backgroundColor.TabStop = false;
            this.gb_backgroundColor.Text = "Hintergrundfarbe";
            // 
            // btn_lightMode
            // 
            this.btn_lightMode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_lightMode.Location = new System.Drawing.Point(6, 22);
            this.btn_lightMode.Name = "btn_lightMode";
            this.btn_lightMode.Size = new System.Drawing.Size(136, 51);
            this.btn_lightMode.TabIndex = 0;
            this.btn_lightMode.Text = "Hell";
            this.btn_lightMode.UseVisualStyleBackColor = false;
            this.btn_lightMode.Click += new System.EventHandler(this.btn_lightMode_Click);
            // 
            // btn_contrastMode
            // 
            this.btn_contrastMode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_contrastMode.Location = new System.Drawing.Point(157, 22);
            this.btn_contrastMode.Name = "btn_contrastMode";
            this.btn_contrastMode.Size = new System.Drawing.Size(136, 51);
            this.btn_contrastMode.TabIndex = 1;
            this.btn_contrastMode.Text = "Kontrast";
            this.btn_contrastMode.UseVisualStyleBackColor = false;
            this.btn_contrastMode.Click += new System.EventHandler(this.btn_contrastMode_Click);
            // 
            // btn_darkMode
            // 
            this.btn_darkMode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_darkMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_darkMode.Location = new System.Drawing.Point(309, 22);
            this.btn_darkMode.Name = "btn_darkMode";
            this.btn_darkMode.Size = new System.Drawing.Size(136, 51);
            this.btn_darkMode.TabIndex = 2;
            this.btn_darkMode.Text = "Dunkel";
            this.btn_darkMode.UseVisualStyleBackColor = false;
            this.btn_darkMode.Click += new System.EventHandler(this.btn_darkMode_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(333, 381);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(136, 51);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 455);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gb_fontSize);
            this.Controls.Add(this.gb_backgroundColor);
            this.Controls.Add(this.gb_font);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.gb_font.ResumeLayout(false);
            this.gb_fontSize.ResumeLayout(false);
            this.gb_backgroundColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_segoeUI;
        private System.Windows.Forms.Button btn_arial;
        private System.Windows.Forms.Button btn_comicSansMS;
        private System.Windows.Forms.GroupBox gb_font;
        private System.Windows.Forms.GroupBox gb_fontSize;
        private System.Windows.Forms.Button btn_size10pt;
        private System.Windows.Forms.Button btn_size15pt;
        private System.Windows.Forms.Button btn_size20pt;
        private System.Windows.Forms.GroupBox gb_backgroundColor;
        private System.Windows.Forms.Button btn_lightMode;
        private System.Windows.Forms.Button btn_contrastMode;
        private System.Windows.Forms.Button btn_darkMode;
        private System.Windows.Forms.Button btn_close;
    }
}