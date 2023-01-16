
namespace JustForYou_Taschenrechner
{
    partial class Grundrechner
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
            this.tb_formula = new System.Windows.Forms.TextBox();
            this.b_plus = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_multiply = new System.Windows.Forms.Button();
            this.b_divide = new System.Windows.Forms.Button();
            this.b_equal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.b_opening = new System.Windows.Forms.Button();
            this.b_closing = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.b_comma = new System.Windows.Forms.Button();
            this.b_sign = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_backspace = new System.Windows.Forms.Button();
            this.b_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_formula
            // 
            this.tb_formula.Location = new System.Drawing.Point(25, 12);
            this.tb_formula.Name = "tb_formula";
            this.tb_formula.Size = new System.Drawing.Size(273, 23);
            this.tb_formula.TabIndex = 0;
            // 
            // b_plus
            // 
            this.b_plus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_plus.Location = new System.Drawing.Point(193, 81);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(106, 50);
            this.b_plus.TabIndex = 1;
            this.b_plus.Text = "+";
            this.b_plus.UseVisualStyleBackColor = true;
            this.b_plus.Click += new System.EventHandler(this.b_plus_Click);
            // 
            // b_minus
            // 
            this.b_minus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_minus.Location = new System.Drawing.Point(137, 81);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(50, 50);
            this.b_minus.TabIndex = 2;
            this.b_minus.Text = "-";
            this.b_minus.UseVisualStyleBackColor = true;
            this.b_minus.Click += new System.EventHandler(this.b_minus_Click);
            // 
            // b_multiply
            // 
            this.b_multiply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_multiply.Location = new System.Drawing.Point(81, 81);
            this.b_multiply.Name = "b_multiply";
            this.b_multiply.Size = new System.Drawing.Size(50, 50);
            this.b_multiply.TabIndex = 3;
            this.b_multiply.Text = "x";
            this.b_multiply.UseVisualStyleBackColor = true;
            this.b_multiply.Click += new System.EventHandler(this.b_multiply_Click);
            // 
            // b_divide
            // 
            this.b_divide.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_divide.Location = new System.Drawing.Point(25, 81);
            this.b_divide.Name = "b_divide";
            this.b_divide.Size = new System.Drawing.Size(50, 50);
            this.b_divide.TabIndex = 4;
            this.b_divide.Text = "/";
            this.b_divide.UseVisualStyleBackColor = true;
            this.b_divide.Click += new System.EventHandler(this.b_divide_Click);
            // 
            // b_equal
            // 
            this.b_equal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_equal.Location = new System.Drawing.Point(193, 305);
            this.b_equal.Name = "b_equal";
            this.b_equal.Size = new System.Drawing.Size(106, 50);
            this.b_equal.TabIndex = 5;
            this.b_equal.Text = "=";
            this.b_equal.UseVisualStyleBackColor = true;
            this.b_equal.Click += new System.EventHandler(this.b_equal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(158, 41);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(141, 23);
            this.tb_output.TabIndex = 8;
            // 
            // b_opening
            // 
            this.b_opening.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_opening.Location = new System.Drawing.Point(193, 193);
            this.b_opening.Name = "b_opening";
            this.b_opening.Size = new System.Drawing.Size(50, 50);
            this.b_opening.TabIndex = 9;
            this.b_opening.Text = "(";
            this.b_opening.UseVisualStyleBackColor = true;
            this.b_opening.Click += new System.EventHandler(this.b_opening_Click);
            // 
            // b_closing
            // 
            this.b_closing.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_closing.Location = new System.Drawing.Point(249, 193);
            this.b_closing.Name = "b_closing";
            this.b_closing.Size = new System.Drawing.Size(50, 50);
            this.b_closing.TabIndex = 10;
            this.b_closing.Text = ")";
            this.b_closing.UseVisualStyleBackColor = true;
            this.b_closing.Click += new System.EventHandler(this.b_closing_Click);
            // 
            // b_3
            // 
            this.b_3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_3.Location = new System.Drawing.Point(137, 249);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(50, 50);
            this.b_3.TabIndex = 11;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_2
            // 
            this.b_2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_2.Location = new System.Drawing.Point(81, 249);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(50, 50);
            this.b_2.TabIndex = 12;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_1
            // 
            this.b_1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_1.Location = new System.Drawing.Point(25, 249);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(50, 50);
            this.b_1.TabIndex = 13;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_6
            // 
            this.b_6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_6.Location = new System.Drawing.Point(137, 193);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(50, 50);
            this.b_6.TabIndex = 14;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
            // 
            // b_5
            // 
            this.b_5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_5.Location = new System.Drawing.Point(81, 193);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(50, 50);
            this.b_5.TabIndex = 15;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
            // 
            // b_4
            // 
            this.b_4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_4.Location = new System.Drawing.Point(25, 193);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(50, 50);
            this.b_4.TabIndex = 16;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // b_9
            // 
            this.b_9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_9.Location = new System.Drawing.Point(137, 137);
            this.b_9.Name = "b_9";
            this.b_9.Size = new System.Drawing.Size(50, 50);
            this.b_9.TabIndex = 17;
            this.b_9.Text = "9";
            this.b_9.UseVisualStyleBackColor = true;
            this.b_9.Click += new System.EventHandler(this.b_9_Click);
            // 
            // b_8
            // 
            this.b_8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_8.Location = new System.Drawing.Point(81, 137);
            this.b_8.Name = "b_8";
            this.b_8.Size = new System.Drawing.Size(50, 50);
            this.b_8.TabIndex = 18;
            this.b_8.Text = "8";
            this.b_8.UseVisualStyleBackColor = true;
            this.b_8.Click += new System.EventHandler(this.b_8_Click);
            // 
            // b_7
            // 
            this.b_7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_7.Location = new System.Drawing.Point(25, 137);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(50, 50);
            this.b_7.TabIndex = 19;
            this.b_7.Text = "7";
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.Click += new System.EventHandler(this.b_7_Click);
            // 
            // b_0
            // 
            this.b_0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_0.Location = new System.Drawing.Point(25, 305);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(106, 50);
            this.b_0.TabIndex = 20;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = true;
            this.b_0.Click += new System.EventHandler(this.b_0_Click);
            // 
            // b_comma
            // 
            this.b_comma.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_comma.Location = new System.Drawing.Point(137, 305);
            this.b_comma.Name = "b_comma";
            this.b_comma.Size = new System.Drawing.Size(50, 50);
            this.b_comma.TabIndex = 21;
            this.b_comma.Text = ",";
            this.b_comma.UseVisualStyleBackColor = true;
            this.b_comma.Click += new System.EventHandler(this.b_comma_Click);
            // 
            // b_sign
            // 
            this.b_sign.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_sign.Location = new System.Drawing.Point(193, 249);
            this.b_sign.Name = "b_sign";
            this.b_sign.Size = new System.Drawing.Size(106, 50);
            this.b_sign.TabIndex = 22;
            this.b_sign.Text = "+/-";
            this.b_sign.UseVisualStyleBackColor = true;
            this.b_sign.Click += new System.EventHandler(this.b_sign_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(193, 381);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 50);
            this.btn_close.TabIndex = 23;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // b_clear
            // 
            this.b_clear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_clear.Location = new System.Drawing.Point(193, 137);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(50, 49);
            this.b_clear.TabIndex = 42;
            this.b_clear.Text = "C";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_backspace
            // 
            this.b_backspace.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_backspace.Location = new System.Drawing.Point(248, 137);
            this.b_backspace.Name = "b_backspace";
            this.b_backspace.Size = new System.Drawing.Size(50, 49);
            this.b_backspace.TabIndex = 41;
            this.b_backspace.Text = "⌫";
            this.b_backspace.UseVisualStyleBackColor = true;
            this.b_backspace.Click += new System.EventHandler(this.b_backspace_Click);
            // 
            // b_settings
            // 
            this.b_settings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_settings.Location = new System.Drawing.Point(25, 381);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(50, 50);
            this.b_settings.TabIndex = 43;
            this.b_settings.Text = "⚙";
            this.b_settings.UseVisualStyleBackColor = true;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // Grundrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 445);
            this.ControlBox = false;
            this.Controls.Add(this.b_settings);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.b_backspace);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.b_sign);
            this.Controls.Add(this.b_comma);
            this.Controls.Add(this.b_0);
            this.Controls.Add(this.b_7);
            this.Controls.Add(this.b_8);
            this.Controls.Add(this.b_9);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_5);
            this.Controls.Add(this.b_6);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_closing);
            this.Controls.Add(this.b_opening);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_equal);
            this.Controls.Add(this.b_divide);
            this.Controls.Add(this.b_multiply);
            this.Controls.Add(this.b_minus);
            this.Controls.Add(this.b_plus);
            this.Controls.Add(this.tb_formula);
            this.Name = "Grundrechner";
            this.Text = "Grundrechenarten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_formula;
        private System.Windows.Forms.Button b_plus;
        private System.Windows.Forms.Button b_minus;
        private System.Windows.Forms.Button b_multiply;
        private System.Windows.Forms.Button b_divide;
        private System.Windows.Forms.Button b_equal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button b_opening;
        private System.Windows.Forms.Button b_closing;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_6;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_9;
        private System.Windows.Forms.Button b_8;
        private System.Windows.Forms.Button b_7;
        private System.Windows.Forms.Button b_0;
        private System.Windows.Forms.Button b_comma;
        private System.Windows.Forms.Button b_sign;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_backspace;
        private System.Windows.Forms.Button b_settings;
    }
}