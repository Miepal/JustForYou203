
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gb_font = new System.Windows.Forms.GroupBox();
            this.gb_fontSize = new System.Windows.Forms.GroupBox();
            this.b_size10pt = new System.Windows.Forms.Button();
            this.b_size15pt = new System.Windows.Forms.Button();
            this.b_size20pt = new System.Windows.Forms.Button();
            this.gb_backgroundColor = new System.Windows.Forms.GroupBox();
            this.b_lightMode = new System.Windows.Forms.Button();
            this.b_grey = new System.Windows.Forms.Button();
            this.b_darkMode = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.gb_font.SuspendLayout();
            this.gb_fontSize.SuspendLayout();
            this.gb_backgroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Segoe UI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Arial";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(309, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Comic Sans MS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gb_font
            // 
            this.gb_font.Controls.Add(this.button1);
            this.gb_font.Controls.Add(this.button2);
            this.gb_font.Controls.Add(this.button3);
            this.gb_font.Location = new System.Drawing.Point(24, 25);
            this.gb_font.Name = "gb_font";
            this.gb_font.Size = new System.Drawing.Size(454, 100);
            this.gb_font.TabIndex = 9;
            this.gb_font.TabStop = false;
            this.gb_font.Text = "Schriftart";
            // 
            // gb_fontSize
            // 
            this.gb_fontSize.Controls.Add(this.b_size10pt);
            this.gb_fontSize.Controls.Add(this.b_size15pt);
            this.gb_fontSize.Controls.Add(this.b_size20pt);
            this.gb_fontSize.Location = new System.Drawing.Point(24, 142);
            this.gb_fontSize.Name = "gb_fontSize";
            this.gb_fontSize.Size = new System.Drawing.Size(454, 100);
            this.gb_fontSize.TabIndex = 10;
            this.gb_fontSize.TabStop = false;
            this.gb_fontSize.Text = "Schriftgröße";
            // 
            // b_size10pt
            // 
            this.b_size10pt.Location = new System.Drawing.Point(6, 22);
            this.b_size10pt.Name = "b_size10pt";
            this.b_size10pt.Size = new System.Drawing.Size(136, 51);
            this.b_size10pt.TabIndex = 0;
            this.b_size10pt.Text = "10pt";
            this.b_size10pt.UseVisualStyleBackColor = true;
            // 
            // b_size15pt
            // 
            this.b_size15pt.Location = new System.Drawing.Point(157, 22);
            this.b_size15pt.Name = "b_size15pt";
            this.b_size15pt.Size = new System.Drawing.Size(136, 51);
            this.b_size15pt.TabIndex = 1;
            this.b_size15pt.Text = "15pt";
            this.b_size15pt.UseVisualStyleBackColor = true;
            // 
            // b_size20pt
            // 
            this.b_size20pt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_size20pt.Location = new System.Drawing.Point(309, 22);
            this.b_size20pt.Name = "b_size20pt";
            this.b_size20pt.Size = new System.Drawing.Size(136, 51);
            this.b_size20pt.TabIndex = 2;
            this.b_size20pt.Text = "20pt";
            this.b_size20pt.UseVisualStyleBackColor = true;
            // 
            // gb_backgroundColor
            // 
            this.gb_backgroundColor.Controls.Add(this.b_lightMode);
            this.gb_backgroundColor.Controls.Add(this.b_grey);
            this.gb_backgroundColor.Controls.Add(this.b_darkMode);
            this.gb_backgroundColor.Location = new System.Drawing.Point(24, 259);
            this.gb_backgroundColor.Name = "gb_backgroundColor";
            this.gb_backgroundColor.Size = new System.Drawing.Size(454, 100);
            this.gb_backgroundColor.TabIndex = 10;
            this.gb_backgroundColor.TabStop = false;
            this.gb_backgroundColor.Text = "Hintergrundfarbe";
            // 
            // b_lightMode
            // 
            this.b_lightMode.Location = new System.Drawing.Point(6, 22);
            this.b_lightMode.Name = "b_lightMode";
            this.b_lightMode.Size = new System.Drawing.Size(136, 51);
            this.b_lightMode.TabIndex = 0;
            this.b_lightMode.Text = "Hell";
            this.b_lightMode.UseVisualStyleBackColor = true;
            // 
            // b_grey
            // 
            this.b_grey.Location = new System.Drawing.Point(157, 22);
            this.b_grey.Name = "b_grey";
            this.b_grey.Size = new System.Drawing.Size(136, 51);
            this.b_grey.TabIndex = 1;
            this.b_grey.Text = "Grau";
            this.b_grey.UseVisualStyleBackColor = true;
            // 
            // b_darkMode
            // 
            this.b_darkMode.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_darkMode.Location = new System.Drawing.Point(309, 22);
            this.b_darkMode.Name = "b_darkMode";
            this.b_darkMode.Size = new System.Drawing.Size(136, 51);
            this.b_darkMode.TabIndex = 2;
            this.b_darkMode.Text = "Dunkel";
            this.b_darkMode.UseVisualStyleBackColor = true;
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_close.Location = new System.Drawing.Point(333, 381);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(136, 51);
            this.b_close.TabIndex = 11;
            this.b_close.Text = "Schließen";
            this.b_close.UseVisualStyleBackColor = true;
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 455);
            this.ControlBox = false;
            this.Controls.Add(this.b_close);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gb_font;
        private System.Windows.Forms.GroupBox gb_fontSize;
        private System.Windows.Forms.Button b_size10pt;
        private System.Windows.Forms.Button b_size15pt;
        private System.Windows.Forms.Button b_size20pt;
        private System.Windows.Forms.GroupBox gb_backgroundColor;
        private System.Windows.Forms.Button b_lightMode;
        private System.Windows.Forms.Button b_grey;
        private System.Windows.Forms.Button b_darkMode;
        private System.Windows.Forms.Button b_close;
    }
}