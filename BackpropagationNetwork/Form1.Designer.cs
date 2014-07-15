namespace BackpropagationNetwork
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericTextBox_t2 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_t1 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_y2 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_y1 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_z4 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_z3 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_z2 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_z1 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_x3 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_x2 = new BackpropagationNetwork.NumericTextBox();
            this.numericTextBox_x1 = new BackpropagationNetwork.NumericTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericTextBox_y2);
            this.groupBox3.Controls.Add(this.numericTextBox_y1);
            this.groupBox3.Location = new System.Drawing.Point(315, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(147, 137);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıktı Katmanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "y[1] =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "y[2] =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericTextBox_x3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericTextBox_x2);
            this.groupBox2.Controls.Add(this.numericTextBox_x1);
            this.groupBox2.Location = new System.Drawing.Point(9, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(147, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Girdi Katmanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "x[1] =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "x[2] =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "x[3] =";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 61);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Öğret";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LearnInput);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 61);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QueryInput);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericTextBox_z4);
            this.groupBox1.Controls.Add(this.numericTextBox_z3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericTextBox_z2);
            this.groupBox1.Controls.Add(this.numericTextBox_z1);
            this.groupBox1.Location = new System.Drawing.Point(162, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(147, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saklı Katman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "z[1] =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "z[2] =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "z[3] =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "z[3] =";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.numericTextBox_t2);
            this.groupBox5.Controls.Add(this.numericTextBox_t1);
            this.groupBox5.Location = new System.Drawing.Point(9, 155);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(147, 137);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Öğretici Çıktı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(18, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 1;
            this.label13.Text = "t[1] =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(18, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "t[2] =";
            // 
            // numericTextBox_t2
            // 
            this.numericTextBox_t2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_t2.Location = new System.Drawing.Point(72, 77);
            this.numericTextBox_t2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_t2.Multiline = true;
            this.numericTextBox_t2.Name = "numericTextBox_t2";
            this.numericTextBox_t2.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_t2.TabIndex = 1;
            this.numericTextBox_t2.Text = "0";
            // 
            // numericTextBox_t1
            // 
            this.numericTextBox_t1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_t1.Location = new System.Drawing.Point(72, 52);
            this.numericTextBox_t1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_t1.Multiline = true;
            this.numericTextBox_t1.Name = "numericTextBox_t1";
            this.numericTextBox_t1.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_t1.TabIndex = 0;
            this.numericTextBox_t1.Text = "0";
            // 
            // numericTextBox_y2
            // 
            this.numericTextBox_y2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_y2.Location = new System.Drawing.Point(72, 77);
            this.numericTextBox_y2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_y2.Multiline = true;
            this.numericTextBox_y2.Name = "numericTextBox_y2";
            this.numericTextBox_y2.ReadOnly = true;
            this.numericTextBox_y2.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_y2.TabIndex = 2;
            this.numericTextBox_y2.TabStop = false;
            this.numericTextBox_y2.Text = "0";
            // 
            // numericTextBox_y1
            // 
            this.numericTextBox_y1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_y1.Location = new System.Drawing.Point(72, 52);
            this.numericTextBox_y1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_y1.Multiline = true;
            this.numericTextBox_y1.Name = "numericTextBox_y1";
            this.numericTextBox_y1.ReadOnly = true;
            this.numericTextBox_y1.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_y1.TabIndex = 2;
            this.numericTextBox_y1.TabStop = false;
            this.numericTextBox_y1.Text = "0";
            // 
            // numericTextBox_z4
            // 
            this.numericTextBox_z4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_z4.Location = new System.Drawing.Point(72, 101);
            this.numericTextBox_z4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_z4.Multiline = true;
            this.numericTextBox_z4.Name = "numericTextBox_z4";
            this.numericTextBox_z4.ReadOnly = true;
            this.numericTextBox_z4.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_z4.TabIndex = 2;
            this.numericTextBox_z4.TabStop = false;
            this.numericTextBox_z4.Text = "0";
            // 
            // numericTextBox_z3
            // 
            this.numericTextBox_z3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_z3.Location = new System.Drawing.Point(72, 77);
            this.numericTextBox_z3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_z3.Multiline = true;
            this.numericTextBox_z3.Name = "numericTextBox_z3";
            this.numericTextBox_z3.ReadOnly = true;
            this.numericTextBox_z3.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_z3.TabIndex = 2;
            this.numericTextBox_z3.TabStop = false;
            this.numericTextBox_z3.Text = "0";
            // 
            // numericTextBox_z2
            // 
            this.numericTextBox_z2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_z2.Location = new System.Drawing.Point(72, 53);
            this.numericTextBox_z2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_z2.Multiline = true;
            this.numericTextBox_z2.Name = "numericTextBox_z2";
            this.numericTextBox_z2.ReadOnly = true;
            this.numericTextBox_z2.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_z2.TabIndex = 2;
            this.numericTextBox_z2.TabStop = false;
            this.numericTextBox_z2.Text = "0";
            // 
            // numericTextBox_z1
            // 
            this.numericTextBox_z1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_z1.Location = new System.Drawing.Point(72, 29);
            this.numericTextBox_z1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_z1.Multiline = true;
            this.numericTextBox_z1.Name = "numericTextBox_z1";
            this.numericTextBox_z1.ReadOnly = true;
            this.numericTextBox_z1.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_z1.TabIndex = 2;
            this.numericTextBox_z1.TabStop = false;
            this.numericTextBox_z1.Text = "0";
            // 
            // numericTextBox_x3
            // 
            this.numericTextBox_x3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_x3.Location = new System.Drawing.Point(72, 92);
            this.numericTextBox_x3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_x3.Multiline = true;
            this.numericTextBox_x3.Name = "numericTextBox_x3";
            this.numericTextBox_x3.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_x3.TabIndex = 2;
            this.numericTextBox_x3.Text = "0";
            // 
            // numericTextBox_x2
            // 
            this.numericTextBox_x2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_x2.Location = new System.Drawing.Point(72, 63);
            this.numericTextBox_x2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_x2.Multiline = true;
            this.numericTextBox_x2.Name = "numericTextBox_x2";
            this.numericTextBox_x2.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_x2.TabIndex = 1;
            this.numericTextBox_x2.Text = "0";
            // 
            // numericTextBox_x1
            // 
            this.numericTextBox_x1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericTextBox_x1.Location = new System.Drawing.Point(72, 34);
            this.numericTextBox_x1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericTextBox_x1.Multiline = true;
            this.numericTextBox_x1.Name = "numericTextBox_x1";
            this.numericTextBox_x1.Size = new System.Drawing.Size(58, 23);
            this.numericTextBox_x1.TabIndex = 0;
            this.numericTextBox_x1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "Form1";
            this.Text = "Geri Yayılımlı Ağ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private NumericTextBox numericTextBox_x1;
        private System.Windows.Forms.Label label1;
        private NumericTextBox numericTextBox_x3;
        private NumericTextBox numericTextBox_x2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private NumericTextBox numericTextBox_y2;
        private NumericTextBox numericTextBox_y1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private NumericTextBox numericTextBox_z4;
        private NumericTextBox numericTextBox_z3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private NumericTextBox numericTextBox_z2;
        private NumericTextBox numericTextBox_z1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private NumericTextBox numericTextBox_t2;
        private NumericTextBox numericTextBox_t1;
    }
}

