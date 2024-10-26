namespace SHARPex2_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonTrapezoid = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.numericUpDownFirst = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThird = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThird)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOutput
            // 
            this.labelOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.labelOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOutput.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelOutput.Location = new System.Drawing.Point(12, 13);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(477, 152);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "Gandalf The Gray";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonRectangle.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRectangle.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRectangle.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonRectangle.Location = new System.Drawing.Point(12, 179);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(145, 111);
            this.buttonRectangle.TabIndex = 1;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircle.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonCircle.Location = new System.Drawing.Point(163, 179);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(145, 111);
            this.buttonCircle.TabIndex = 2;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSquare.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonSquare.Location = new System.Drawing.Point(12, 296);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(145, 111);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonTrapezoid
            // 
            this.buttonTrapezoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonTrapezoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrapezoid.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrapezoid.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonTrapezoid.Location = new System.Drawing.Point(163, 296);
            this.buttonTrapezoid.Name = "buttonTrapezoid";
            this.buttonTrapezoid.Size = new System.Drawing.Size(145, 111);
            this.buttonTrapezoid.TabIndex = 4;
            this.buttonTrapezoid.Text = "Trapezoid";
            this.buttonTrapezoid.UseVisualStyleBackColor = false;
            this.buttonTrapezoid.Click += new System.EventHandler(this.buttonTrapezoid_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Goldenrod;
            this.buttonCalculate.Location = new System.Drawing.Point(314, 354);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(175, 53);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelFirst.Location = new System.Drawing.Point(314, 183);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(68, 33);
            this.labelFirst.TabIndex = 6;
            this.labelFirst.Text = "label1";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelSecond.Location = new System.Drawing.Point(315, 243);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(68, 33);
            this.labelSecond.TabIndex = 7;
            this.labelSecond.Text = "label2";
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThird.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelThird.Location = new System.Drawing.Point(314, 296);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(68, 33);
            this.labelThird.TabIndex = 8;
            this.labelThird.Text = "label3";
            // 
            // numericUpDownFirst
            // 
            this.numericUpDownFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.numericUpDownFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownFirst.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFirst.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDownFirst.Location = new System.Drawing.Point(390, 183);
            this.numericUpDownFirst.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFirst.Name = "numericUpDownFirst";
            this.numericUpDownFirst.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownFirst.TabIndex = 9;
            this.numericUpDownFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.numericUpDownSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSecond.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSecond.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDownSecond.Location = new System.Drawing.Point(390, 243);
            this.numericUpDownSecond.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownSecond.TabIndex = 10;
            this.numericUpDownSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownThird
            // 
            this.numericUpDownThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.numericUpDownThird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownThird.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownThird.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDownThird.Location = new System.Drawing.Point(390, 296);
            this.numericUpDownThird.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownThird.Name = "numericUpDownThird";
            this.numericUpDownThird.Size = new System.Drawing.Size(99, 27);
            this.numericUpDownThird.TabIndex = 11;
            this.numericUpDownThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(503, 417);
            this.Controls.Add(this.numericUpDownThird);
            this.Controls.Add(this.numericUpDownSecond);
            this.Controls.Add(this.numericUpDownFirst);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonTrapezoid);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.labelOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "The Lord of The Rectangles";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonTrapezoid;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelThird;
        private System.Windows.Forms.NumericUpDown numericUpDownFirst;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownThird;
    }
}

