
namespace JustForYou_Taschenrechner
{
    partial class Geometrie
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
            this.b_triangle = new System.Windows.Forms.Button();
            this.b_circle = new System.Windows.Forms.Button();
            this.b_parallelogram = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_settings
            // 
            this.b_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_settings.Location = new System.Drawing.Point(105, 11);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(50, 50);
            this.b_settings.TabIndex = 15;
            this.b_settings.Text = "⚙";
            this.b_settings.UseVisualStyleBackColor = true;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // b_triangle
            // 
            this.b_triangle.Location = new System.Drawing.Point(15, 105);
            this.b_triangle.Name = "b_triangle";
            this.b_triangle.Size = new System.Drawing.Size(196, 50);
            this.b_triangle.TabIndex = 17;
            this.b_triangle.Text = "Dreieck berechnen";
            this.b_triangle.UseVisualStyleBackColor = true;
            this.b_triangle.Click += new System.EventHandler(this.b_add_percent_Click);
            // 
            // b_circle
            // 
            this.b_circle.Location = new System.Drawing.Point(15, 161);
            this.b_circle.Name = "b_circle";
            this.b_circle.Size = new System.Drawing.Size(196, 50);
            this.b_circle.TabIndex = 18;
            this.b_circle.Text = "Kreis berechnen";
            this.b_circle.UseVisualStyleBackColor = true;
            this.b_circle.Click += new System.EventHandler(this.b_calc_circle_Click);
            // 
            // b_parallelogram
            // 
            this.b_parallelogram.Location = new System.Drawing.Point(15, 217);
            this.b_parallelogram.Name = "b_parallelogram";
            this.b_parallelogram.Size = new System.Drawing.Size(196, 50);
            this.b_parallelogram.TabIndex = 19;
            this.b_parallelogram.Text = "Parallelogramm berechnen";
            this.b_parallelogram.UseVisualStyleBackColor = true;
            this.b_parallelogram.Click += new System.EventHandler(this.b_parallelogram_Click);
            // 
            // b_close
            // 
            this.b_close.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_close.Location = new System.Drawing.Point(161, 11);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(50, 50);
            this.b_close.TabIndex = 20;
            this.b_close.Text = "✖";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // Geometrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 279);
            this.ControlBox = false;
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_parallelogram);
            this.Controls.Add(this.b_circle);
            this.Controls.Add(this.b_triangle);
            this.Controls.Add(this.b_settings);
            this.Name = "Geometrie";
            this.Text = "Geometrie";
            this.Load += new System.EventHandler(this.Geometrie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.Button b_triangle;
        private System.Windows.Forms.Button b_circle;
        private System.Windows.Forms.Button b_parallelogram;
        private System.Windows.Forms.Button b_close;
    }
}