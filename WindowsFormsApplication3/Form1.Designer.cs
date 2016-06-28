namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputLengthUnit = new System.Windows.Forms.ComboBox();
            this.inputWidthUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputArea = new System.Windows.Forms.TextBox();
            this.outputPerimeter = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.inputAreaUnit = new System.Windows.Forms.ComboBox();
            this.inputPerimeterUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorLength = new System.Windows.Forms.Label();
            this.errorWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Everything you need to know about a rectangle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length";
            // 
            // inputLength
            // 
            this.inputLength.Location = new System.Drawing.Point(54, 45);
            this.inputLength.Name = "inputLength";
            this.inputLength.Size = new System.Drawing.Size(100, 20);
            this.inputLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width";
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(54, 100);
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(100, 20);
            this.inputWidth.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputLengthUnit
            // 
            this.inputLengthUnit.FormattingEnabled = true;
            this.inputLengthUnit.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "mm"});
            this.inputLengthUnit.Location = new System.Drawing.Point(161, 45);
            this.inputLengthUnit.Name = "inputLengthUnit";
            this.inputLengthUnit.Size = new System.Drawing.Size(46, 21);
            this.inputLengthUnit.TabIndex = 8;
            this.inputLengthUnit.Text = "m";
            // 
            // inputWidthUnit
            // 
            this.inputWidthUnit.FormattingEnabled = true;
            this.inputWidthUnit.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "mm"});
            this.inputWidthUnit.Location = new System.Drawing.Point(161, 100);
            this.inputWidthUnit.Name = "inputWidthUnit";
            this.inputWidthUnit.Size = new System.Drawing.Size(46, 21);
            this.inputWidthUnit.TabIndex = 9;
            this.inputWidthUnit.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Perimeter";
            // 
            // outputArea
            // 
            this.outputArea.Location = new System.Drawing.Point(70, 188);
            this.outputArea.Name = "outputArea";
            this.outputArea.ReadOnly = true;
            this.outputArea.Size = new System.Drawing.Size(100, 20);
            this.outputArea.TabIndex = 12;
            // 
            // outputPerimeter
            // 
            this.outputPerimeter.Location = new System.Drawing.Point(70, 214);
            this.outputPerimeter.Name = "outputPerimeter";
            this.outputPerimeter.ReadOnly = true;
            this.outputPerimeter.Size = new System.Drawing.Size(100, 20);
            this.outputPerimeter.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Calculate!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputAreaUnit
            // 
            this.inputAreaUnit.FormattingEnabled = true;
            this.inputAreaUnit.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "mm"});
            this.inputAreaUnit.Location = new System.Drawing.Point(176, 188);
            this.inputAreaUnit.Name = "inputAreaUnit";
            this.inputAreaUnit.Size = new System.Drawing.Size(46, 21);
            this.inputAreaUnit.TabIndex = 15;
            this.inputAreaUnit.Text = "m";
            // 
            // inputPerimeterUnit
            // 
            this.inputPerimeterUnit.FormattingEnabled = true;
            this.inputPerimeterUnit.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "mm"});
            this.inputPerimeterUnit.Location = new System.Drawing.Point(176, 213);
            this.inputPerimeterUnit.Name = "inputPerimeterUnit";
            this.inputPerimeterUnit.Size = new System.Drawing.Size(46, 21);
            this.inputPerimeterUnit.TabIndex = 16;
            this.inputPerimeterUnit.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Input non-negative integers for length and width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "-Made by: Alex Wang";
            // 
            // errorLength
            // 
            this.errorLength.AutoSize = true;
            this.errorLength.ForeColor = System.Drawing.Color.Red;
            this.errorLength.Location = new System.Drawing.Point(51, 68);
            this.errorLength.Name = "errorLength";
            this.errorLength.Size = new System.Drawing.Size(35, 13);
            this.errorLength.TabIndex = 19;
            this.errorLength.Text = "label8";
            this.errorLength.Visible = false;
            // 
            // errorWidth
            // 
            this.errorWidth.AutoSize = true;
            this.errorWidth.ForeColor = System.Drawing.Color.Red;
            this.errorWidth.Location = new System.Drawing.Point(51, 123);
            this.errorWidth.Name = "errorWidth";
            this.errorWidth.Size = new System.Drawing.Size(35, 13);
            this.errorWidth.TabIndex = 19;
            this.errorWidth.Text = "label8";
            this.errorWidth.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 276);
            this.Controls.Add(this.errorWidth);
            this.Controls.Add(this.errorLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputPerimeterUnit);
            this.Controls.Add(this.inputAreaUnit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outputPerimeter);
            this.Controls.Add(this.outputArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputWidthUnit);
            this.Controls.Add(this.inputLengthUnit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RectangleCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox inputLengthUnit;
        private System.Windows.Forms.ComboBox inputWidthUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outputArea;
        private System.Windows.Forms.TextBox outputPerimeter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox inputAreaUnit;
        private System.Windows.Forms.ComboBox inputPerimeterUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errorLength;
        private System.Windows.Forms.Label errorWidth;
    }
}

