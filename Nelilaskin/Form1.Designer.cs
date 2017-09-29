namespace Nelilaskin
{
    partial class Nelilaskin
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
            this.output = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_fraction = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output.CausesValidation = false;
            this.output.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(13, 13);
            this.output.MaximumSize = new System.Drawing.Size(200, 20);
            this.output.MaxLength = 20;
            this.output.MinimumSize = new System.Drawing.Size(170, 4);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(195, 27);
            this.output.TabIndex = 0;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.output_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_1);
            this.flowLayoutPanel1.Controls.Add(this.btn_2);
            this.flowLayoutPanel1.Controls.Add(this.btn_3);
            this.flowLayoutPanel1.Controls.Add(this.btn_4);
            this.flowLayoutPanel1.Controls.Add(this.btn_5);
            this.flowLayoutPanel1.Controls.Add(this.btn_6);
            this.flowLayoutPanel1.Controls.Add(this.btn_7);
            this.flowLayoutPanel1.Controls.Add(this.btn_8);
            this.flowLayoutPanel1.Controls.Add(this.btn_9);
            this.flowLayoutPanel1.Controls.Add(this.btn_0);
            this.flowLayoutPanel1.Controls.Add(this.btn_equal);
            this.flowLayoutPanel1.Controls.Add(this.btn_addition);
            this.flowLayoutPanel1.Controls.Add(this.btn_subtraction);
            this.flowLayoutPanel1.Controls.Add(this.btn_multiplication);
            this.flowLayoutPanel1.Controls.Add(this.btn_division);
            this.flowLayoutPanel1.Controls.Add(this.btn_fraction);
            this.flowLayoutPanel1.Controls.Add(this.btn_clear);
            this.flowLayoutPanel1.Controls.Add(this.button18);
            this.flowLayoutPanel1.Controls.Add(this.button19);
            this.flowLayoutPanel1.Controls.Add(this.button20);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 235);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(3, 3);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(40, 40);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.setOne);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(49, 3);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(40, 40);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.setTwo);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(95, 3);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(40, 40);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.setThree);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(141, 3);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(40, 40);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.setFour);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(3, 49);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(40, 40);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.setFive);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(49, 49);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(40, 40);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.setSix);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(95, 49);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(40, 40);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.setSeven);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(141, 49);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(40, 40);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.setEight);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(3, 95);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(40, 40);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.setNine);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(49, 95);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(40, 40);
            this.btn_0.TabIndex = 9;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.setZero);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(95, 95);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(40, 40);
            this.btn_equal.TabIndex = 10;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.setEqual);
            // 
            // btn_addition
            // 
            this.btn_addition.Location = new System.Drawing.Point(141, 95);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(40, 40);
            this.btn_addition.TabIndex = 11;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.setAddition);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Location = new System.Drawing.Point(3, 141);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(40, 40);
            this.btn_subtraction.TabIndex = 12;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.setSubtraction);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Location = new System.Drawing.Point(49, 141);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(40, 40);
            this.btn_multiplication.TabIndex = 13;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.setMultiplication);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(95, 141);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(40, 40);
            this.btn_division.TabIndex = 14;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.setDivision);
            // 
            // btn_fraction
            // 
            this.btn_fraction.Location = new System.Drawing.Point(141, 141);
            this.btn_fraction.Name = "btn_fraction";
            this.btn_fraction.Size = new System.Drawing.Size(40, 40);
            this.btn_fraction.TabIndex = 15;
            this.btn_fraction.Text = ",";
            this.btn_fraction.UseVisualStyleBackColor = true;
            this.btn_fraction.Click += new System.EventHandler(this.setFraction);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(3, 187);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(40, 40);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "CE";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.clearAll);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(49, 187);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 40);
            this.button18.TabIndex = 17;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(95, 187);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 40);
            this.button19.TabIndex = 18;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(141, 187);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 40);
            this.button20.TabIndex = 19;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // Nelilaskin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 307);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Nelilaskin";
            this.Text = "Nelilaskin";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_fraction;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}

