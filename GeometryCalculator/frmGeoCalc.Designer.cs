namespace GeometryCalculator
{
    partial class frmGeoCalc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.radTrapezoid = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.radRhombus = new System.Windows.Forms.RadioButton();
            this.radParallelogram = new System.Windows.Forms.RadioButton();
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.radPerimeter = new System.Windows.Forms.RadioButton();
            this.radAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMeasurement1 = new System.Windows.Forms.Label();
            this.lblMeasurement2 = new System.Windows.Forms.Label();
            this.lblMeasurement3 = new System.Windows.Forms.Label();
            this.lblMeasurement4 = new System.Windows.Forms.Label();
            this.lblMeasurement5 = new System.Windows.Forms.Label();
            this.txtMeasurement1 = new System.Windows.Forms.TextBox();
            this.txtMeasurement2 = new System.Windows.Forms.TextBox();
            this.txtMeasurement3 = new System.Windows.Forms.TextBox();
            this.txtMeasurement4 = new System.Windows.Forms.TextBox();
            this.txtMeasurement5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAnswerOne = new System.Windows.Forms.TextBox();
            this.txtAnswerTwo = new System.Windows.Forms.TextBox();
            this.lblAnswerOne = new System.Windows.Forms.Label();
            this.lblAnswerTwo = new System.Windows.Forms.Label();
            this.lblFormulaOneName = new System.Windows.Forms.Label();
            this.lblFormulaTwoName = new System.Windows.Forms.Label();
            this.lblFormulaOne = new System.Windows.Forms.Label();
            this.lblFormulaTwo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCircle);
            this.groupBox1.Controls.Add(this.radTrapezoid);
            this.groupBox1.Controls.Add(this.radTriangle);
            this.groupBox1.Controls.Add(this.radRhombus);
            this.groupBox1.Controls.Add(this.radParallelogram);
            this.groupBox1.Controls.Add(this.radSquare);
            this.groupBox1.Controls.Add(this.radRectangle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Location = new System.Drawing.Point(19, 168);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(51, 17);
            this.radCircle.TabIndex = 6;
            this.radCircle.TabStop = true;
            this.radCircle.Text = "Circle";
            this.radCircle.UseVisualStyleBackColor = true;
            this.radCircle.Click += new System.EventHandler(this.radShape_Click);
            // 
            // radTrapezoid
            // 
            this.radTrapezoid.AutoSize = true;
            this.radTrapezoid.Location = new System.Drawing.Point(19, 145);
            this.radTrapezoid.Name = "radTrapezoid";
            this.radTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.radTrapezoid.TabIndex = 5;
            this.radTrapezoid.TabStop = true;
            this.radTrapezoid.Text = "Trapezoid";
            this.radTrapezoid.UseVisualStyleBackColor = true;
            this.radTrapezoid.Click += new System.EventHandler(this.radShape_Click);
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.Location = new System.Drawing.Point(19, 122);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(63, 17);
            this.radTriangle.TabIndex = 4;
            this.radTriangle.TabStop = true;
            this.radTriangle.Text = "Triangle";
            this.radTriangle.UseVisualStyleBackColor = true;
            this.radTriangle.Click += new System.EventHandler(this.radShape_Click);
            // 
            // radRhombus
            // 
            this.radRhombus.AutoSize = true;
            this.radRhombus.Location = new System.Drawing.Point(19, 99);
            this.radRhombus.Name = "radRhombus";
            this.radRhombus.Size = new System.Drawing.Size(70, 17);
            this.radRhombus.TabIndex = 3;
            this.radRhombus.TabStop = true;
            this.radRhombus.Text = "Rhombus";
            this.radRhombus.UseVisualStyleBackColor = true;
            this.radRhombus.Click += new System.EventHandler(this.radShape_Click);
            // 
            // radParallelogram
            // 
            this.radParallelogram.AutoSize = true;
            this.radParallelogram.Location = new System.Drawing.Point(19, 76);
            this.radParallelogram.Name = "radParallelogram";
            this.radParallelogram.Size = new System.Drawing.Size(88, 17);
            this.radParallelogram.TabIndex = 2;
            this.radParallelogram.TabStop = true;
            this.radParallelogram.Text = "Parallelogram";
            this.radParallelogram.UseVisualStyleBackColor = true;
            this.radParallelogram.Click += new System.EventHandler(this.radShape_Click);
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.Location = new System.Drawing.Point(19, 53);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(59, 17);
            this.radSquare.TabIndex = 1;
            this.radSquare.TabStop = true;
            this.radSquare.Text = "Square";
            this.radSquare.UseVisualStyleBackColor = true;
            this.radSquare.Click += new System.EventHandler(this.radShape_Click);
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.Checked = true;
            this.radRectangle.Location = new System.Drawing.Point(19, 30);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(74, 17);
            this.radRectangle.TabIndex = 0;
            this.radRectangle.TabStop = true;
            this.radRectangle.Text = "Rectangle";
            this.radRectangle.UseVisualStyleBackColor = true;
            this.radRectangle.Click += new System.EventHandler(this.radShape_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radArea);
            this.groupBox2.Controls.Add(this.radPerimeter);
            this.groupBox2.Controls.Add(this.radAreaPerimeter);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aera && Perimeter";
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Checked = true;
            this.radArea.Location = new System.Drawing.Point(6, 22);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(47, 17);
            this.radArea.TabIndex = 7;
            this.radArea.TabStop = true;
            this.radArea.Text = "Area";
            this.radArea.UseVisualStyleBackColor = true;
            this.radArea.Click += new System.EventHandler(this.radArea_Click);
            // 
            // radPerimeter
            // 
            this.radPerimeter.AutoSize = true;
            this.radPerimeter.Location = new System.Drawing.Point(6, 45);
            this.radPerimeter.Name = "radPerimeter";
            this.radPerimeter.Size = new System.Drawing.Size(69, 17);
            this.radPerimeter.TabIndex = 8;
            this.radPerimeter.TabStop = true;
            this.radPerimeter.Text = "Perimeter";
            this.radPerimeter.UseVisualStyleBackColor = true;
            this.radPerimeter.Click += new System.EventHandler(this.radArea_Click);
            // 
            // radAreaPerimeter
            // 
            this.radAreaPerimeter.AutoSize = true;
            this.radAreaPerimeter.Location = new System.Drawing.Point(6, 68);
            this.radAreaPerimeter.Name = "radAreaPerimeter";
            this.radAreaPerimeter.Size = new System.Drawing.Size(103, 17);
            this.radAreaPerimeter.TabIndex = 9;
            this.radAreaPerimeter.TabStop = true;
            this.radAreaPerimeter.Text = "Area && Perimeter";
            this.radAreaPerimeter.UseVisualStyleBackColor = true;
            this.radAreaPerimeter.Click += new System.EventHandler(this.radArea_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(218, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMeasurement1
            // 
            this.lblMeasurement1.AutoSize = true;
            this.lblMeasurement1.Location = new System.Drawing.Point(221, 157);
            this.lblMeasurement1.Name = "lblMeasurement1";
            this.lblMeasurement1.Size = new System.Drawing.Size(35, 13);
            this.lblMeasurement1.TabIndex = 3;
            this.lblMeasurement1.Text = "label1";
            this.lblMeasurement1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMeasurement1.Visible = false;
            // 
            // lblMeasurement2
            // 
            this.lblMeasurement2.AutoSize = true;
            this.lblMeasurement2.Location = new System.Drawing.Point(221, 184);
            this.lblMeasurement2.Name = "lblMeasurement2";
            this.lblMeasurement2.Size = new System.Drawing.Size(35, 13);
            this.lblMeasurement2.TabIndex = 4;
            this.lblMeasurement2.Text = "label2";
            this.lblMeasurement2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMeasurement2.Visible = false;
            // 
            // lblMeasurement3
            // 
            this.lblMeasurement3.AutoSize = true;
            this.lblMeasurement3.Location = new System.Drawing.Point(221, 208);
            this.lblMeasurement3.Name = "lblMeasurement3";
            this.lblMeasurement3.Size = new System.Drawing.Size(35, 13);
            this.lblMeasurement3.TabIndex = 5;
            this.lblMeasurement3.Text = "label3";
            this.lblMeasurement3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMeasurement3.Visible = false;
            // 
            // lblMeasurement4
            // 
            this.lblMeasurement4.AutoSize = true;
            this.lblMeasurement4.Location = new System.Drawing.Point(221, 234);
            this.lblMeasurement4.Name = "lblMeasurement4";
            this.lblMeasurement4.Size = new System.Drawing.Size(35, 13);
            this.lblMeasurement4.TabIndex = 6;
            this.lblMeasurement4.Text = "label4";
            this.lblMeasurement4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMeasurement4.Visible = false;
            // 
            // lblMeasurement5
            // 
            this.lblMeasurement5.AutoSize = true;
            this.lblMeasurement5.Location = new System.Drawing.Point(221, 260);
            this.lblMeasurement5.Name = "lblMeasurement5";
            this.lblMeasurement5.Size = new System.Drawing.Size(35, 13);
            this.lblMeasurement5.TabIndex = 7;
            this.lblMeasurement5.Text = "label5";
            this.lblMeasurement5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMeasurement5.Visible = false;
            // 
            // txtMeasurement1
            // 
            this.txtMeasurement1.Location = new System.Drawing.Point(262, 154);
            this.txtMeasurement1.Name = "txtMeasurement1";
            this.txtMeasurement1.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurement1.TabIndex = 8;
            this.txtMeasurement1.Tag = "1";
            this.txtMeasurement1.Visible = false;
            this.txtMeasurement1.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            this.txtMeasurement1.Enter += new System.EventHandler(this.txtBoxGetFocus_Enter);
            // 
            // txtMeasurement2
            // 
            this.txtMeasurement2.Location = new System.Drawing.Point(262, 180);
            this.txtMeasurement2.Name = "txtMeasurement2";
            this.txtMeasurement2.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurement2.TabIndex = 9;
            this.txtMeasurement2.Tag = "3";
            this.txtMeasurement2.Visible = false;
            this.txtMeasurement2.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            this.txtMeasurement2.Enter += new System.EventHandler(this.txtBoxGetFocus_Enter);
            // 
            // txtMeasurement3
            // 
            this.txtMeasurement3.Location = new System.Drawing.Point(262, 205);
            this.txtMeasurement3.Name = "txtMeasurement3";
            this.txtMeasurement3.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurement3.TabIndex = 10;
            this.txtMeasurement3.Tag = "5";
            this.txtMeasurement3.Visible = false;
            this.txtMeasurement3.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            this.txtMeasurement3.Enter += new System.EventHandler(this.txtBoxGetFocus_Enter);
            // 
            // txtMeasurement4
            // 
            this.txtMeasurement4.Location = new System.Drawing.Point(262, 231);
            this.txtMeasurement4.Name = "txtMeasurement4";
            this.txtMeasurement4.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurement4.TabIndex = 11;
            this.txtMeasurement4.Tag = "7";
            this.txtMeasurement4.Visible = false;
            this.txtMeasurement4.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            this.txtMeasurement4.Enter += new System.EventHandler(this.txtBoxGetFocus_Enter);
            // 
            // txtMeasurement5
            // 
            this.txtMeasurement5.Location = new System.Drawing.Point(262, 257);
            this.txtMeasurement5.Name = "txtMeasurement5";
            this.txtMeasurement5.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurement5.TabIndex = 12;
            this.txtMeasurement5.Tag = "9";
            this.txtMeasurement5.Visible = false;
            this.txtMeasurement5.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            this.txtMeasurement5.Enter += new System.EventHandler(this.txtBoxGetFocus_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(433, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 168);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAnswerOne
            // 
            this.txtAnswerOne.Location = new System.Drawing.Point(171, 312);
            this.txtAnswerOne.Name = "txtAnswerOne";
            this.txtAnswerOne.ReadOnly = true;
            this.txtAnswerOne.Size = new System.Drawing.Size(100, 20);
            this.txtAnswerOne.TabIndex = 15;
            this.txtAnswerOne.Visible = false;
            // 
            // txtAnswerTwo
            // 
            this.txtAnswerTwo.Location = new System.Drawing.Point(171, 358);
            this.txtAnswerTwo.Name = "txtAnswerTwo";
            this.txtAnswerTwo.ReadOnly = true;
            this.txtAnswerTwo.Size = new System.Drawing.Size(100, 20);
            this.txtAnswerTwo.TabIndex = 16;
            this.txtAnswerTwo.Visible = false;
            // 
            // lblAnswerOne
            // 
            this.lblAnswerOne.AutoSize = true;
            this.lblAnswerOne.Location = new System.Drawing.Point(113, 315);
            this.lblAnswerOne.Name = "lblAnswerOne";
            this.lblAnswerOne.Size = new System.Drawing.Size(35, 13);
            this.lblAnswerOne.TabIndex = 17;
            this.lblAnswerOne.Text = "label6";
            this.lblAnswerOne.Visible = false;
            // 
            // lblAnswerTwo
            // 
            this.lblAnswerTwo.AutoSize = true;
            this.lblAnswerTwo.Location = new System.Drawing.Point(113, 361);
            this.lblAnswerTwo.Name = "lblAnswerTwo";
            this.lblAnswerTwo.Size = new System.Drawing.Size(35, 13);
            this.lblAnswerTwo.TabIndex = 18;
            this.lblAnswerTwo.Text = "label7";
            this.lblAnswerTwo.Visible = false;
            // 
            // lblFormulaOneName
            // 
            this.lblFormulaOneName.AutoSize = true;
            this.lblFormulaOneName.Location = new System.Drawing.Point(439, 183);
            this.lblFormulaOneName.Name = "lblFormulaOneName";
            this.lblFormulaOneName.Size = new System.Drawing.Size(35, 13);
            this.lblFormulaOneName.TabIndex = 19;
            this.lblFormulaOneName.Text = "label6";
            // 
            // lblFormulaTwoName
            // 
            this.lblFormulaTwoName.AutoSize = true;
            this.lblFormulaTwoName.Location = new System.Drawing.Point(439, 205);
            this.lblFormulaTwoName.Name = "lblFormulaTwoName";
            this.lblFormulaTwoName.Size = new System.Drawing.Size(35, 13);
            this.lblFormulaTwoName.TabIndex = 20;
            this.lblFormulaTwoName.Text = "label7";
            // 
            // lblFormulaOne
            // 
            this.lblFormulaOne.AutoSize = true;
            this.lblFormulaOne.Location = new System.Drawing.Point(499, 183);
            this.lblFormulaOne.Name = "lblFormulaOne";
            this.lblFormulaOne.Size = new System.Drawing.Size(35, 13);
            this.lblFormulaOne.TabIndex = 21;
            this.lblFormulaOne.Text = "label6";
            // 
            // lblFormulaTwo
            // 
            this.lblFormulaTwo.AutoSize = true;
            this.lblFormulaTwo.Location = new System.Drawing.Point(499, 205);
            this.lblFormulaTwo.Name = "lblFormulaTwo";
            this.lblFormulaTwo.Size = new System.Drawing.Size(35, 13);
            this.lblFormulaTwo.TabIndex = 22;
            this.lblFormulaTwo.Text = "label6";
            // 
            // frmGeoCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 432);
            this.Controls.Add(this.lblFormulaTwo);
            this.Controls.Add(this.lblFormulaOne);
            this.Controls.Add(this.lblFormulaTwoName);
            this.Controls.Add(this.lblFormulaOneName);
            this.Controls.Add(this.lblAnswerTwo);
            this.Controls.Add(this.lblAnswerOne);
            this.Controls.Add(this.txtAnswerTwo);
            this.Controls.Add(this.txtAnswerOne);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMeasurement5);
            this.Controls.Add(this.txtMeasurement4);
            this.Controls.Add(this.txtMeasurement3);
            this.Controls.Add(this.txtMeasurement2);
            this.Controls.Add(this.txtMeasurement1);
            this.Controls.Add(this.lblMeasurement5);
            this.Controls.Add(this.lblMeasurement4);
            this.Controls.Add(this.lblMeasurement3);
            this.Controls.Add(this.lblMeasurement2);
            this.Controls.Add(this.lblMeasurement1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGeoCalc";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCircle;
        private System.Windows.Forms.RadioButton radTrapezoid;
        private System.Windows.Forms.RadioButton radTriangle;
        private System.Windows.Forms.RadioButton radRhombus;
        private System.Windows.Forms.RadioButton radParallelogram;
        private System.Windows.Forms.RadioButton radSquare;
        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.RadioButton radPerimeter;
        private System.Windows.Forms.RadioButton radAreaPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMeasurement1;
        private System.Windows.Forms.Label lblMeasurement2;
        private System.Windows.Forms.Label lblMeasurement3;
        private System.Windows.Forms.Label lblMeasurement4;
        private System.Windows.Forms.Label lblMeasurement5;
        private System.Windows.Forms.TextBox txtMeasurement1;
        private System.Windows.Forms.TextBox txtMeasurement2;
        private System.Windows.Forms.TextBox txtMeasurement3;
        private System.Windows.Forms.TextBox txtMeasurement4;
        private System.Windows.Forms.TextBox txtMeasurement5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAnswerOne;
        private System.Windows.Forms.TextBox txtAnswerTwo;
        private System.Windows.Forms.Label lblAnswerOne;
        private System.Windows.Forms.Label lblAnswerTwo;
        private System.Windows.Forms.Label lblFormulaOneName;
        private System.Windows.Forms.Label lblFormulaTwoName;
        private System.Windows.Forms.Label lblFormulaOne;
        private System.Windows.Forms.Label lblFormulaTwo;
    }
}

