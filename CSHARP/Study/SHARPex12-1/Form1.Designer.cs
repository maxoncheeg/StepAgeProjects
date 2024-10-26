namespace SHARPex12_1
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
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.textBoxEvenChapter = new System.Windows.Forms.TextBox();
            this.textBoxOddChapter = new System.Windows.Forms.TextBox();
            this.textBoxEvenDiscription = new System.Windows.Forms.TextBox();
            this.textBoxOddDiscription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChapter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxChapters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.buttonChapter = new System.Windows.Forms.Button();
            this.buttonDescription = new System.Windows.Forms.Button();
            this.labelSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.LargeChange = 2;
            this.hScrollBar.Location = new System.Drawing.Point(635, 558);
            this.hScrollBar.Maximum = 1;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(591, 27);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // textBoxEvenChapter
            // 
            this.textBoxEvenChapter.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxEvenChapter.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxEvenChapter.Location = new System.Drawing.Point(635, 74);
            this.textBoxEvenChapter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEvenChapter.Name = "textBoxEvenChapter";
            this.textBoxEvenChapter.ReadOnly = true;
            this.textBoxEvenChapter.Size = new System.Drawing.Size(286, 26);
            this.textBoxEvenChapter.TabIndex = 1;
            // 
            // textBoxOddChapter
            // 
            this.textBoxOddChapter.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxOddChapter.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxOddChapter.Location = new System.Drawing.Point(937, 74);
            this.textBoxOddChapter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOddChapter.Name = "textBoxOddChapter";
            this.textBoxOddChapter.ReadOnly = true;
            this.textBoxOddChapter.Size = new System.Drawing.Size(286, 26);
            this.textBoxOddChapter.TabIndex = 2;
            // 
            // textBoxEvenDiscription
            // 
            this.textBoxEvenDiscription.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxEvenDiscription.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxEvenDiscription.Location = new System.Drawing.Point(635, 110);
            this.textBoxEvenDiscription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEvenDiscription.Multiline = true;
            this.textBoxEvenDiscription.Name = "textBoxEvenDiscription";
            this.textBoxEvenDiscription.ReadOnly = true;
            this.textBoxEvenDiscription.Size = new System.Drawing.Size(286, 423);
            this.textBoxEvenDiscription.TabIndex = 3;
            // 
            // textBoxOddDiscription
            // 
            this.textBoxOddDiscription.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxOddDiscription.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxOddDiscription.Location = new System.Drawing.Point(937, 110);
            this.textBoxOddDiscription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOddDiscription.Multiline = true;
            this.textBoxOddDiscription.Name = "textBoxOddDiscription";
            this.textBoxOddDiscription.ReadOnly = true;
            this.textBoxOddDiscription.Size = new System.Drawing.Size(286, 423);
            this.textBoxOddDiscription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(615, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 587);
            this.label1.TabIndex = 5;
            this.label1.Text = "\r\nКнига по C++";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxChapter
            // 
            this.textBoxChapter.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxChapter.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxChapter.Location = new System.Drawing.Point(312, 17);
            this.textBoxChapter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxChapter.MaxLength = 25;
            this.textBoxChapter.Name = "textBoxChapter";
            this.textBoxChapter.Size = new System.Drawing.Size(286, 26);
            this.textBoxChapter.TabIndex = 6;
            this.textBoxChapter.TextChanged += new System.EventHandler(this.textBoxChapter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название главы:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxDescription.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBoxDescription.Location = new System.Drawing.Point(312, 170);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.MaxLength = 340;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(286, 434);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // comboBoxChapters
            // 
            this.comboBoxChapters.BackColor = System.Drawing.Color.SandyBrown;
            this.comboBoxChapters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxChapters.ForeColor = System.Drawing.Color.SaddleBrown;
            this.comboBoxChapters.FormattingEnabled = true;
            this.comboBoxChapters.Location = new System.Drawing.Point(22, 170);
            this.comboBoxChapters.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChapters.Name = "comboBoxChapters";
            this.comboBoxChapters.Size = new System.Drawing.Size(286, 27);
            this.comboBoxChapters.TabIndex = 10;
            this.comboBoxChapters.SelectedIndexChanged += new System.EventHandler(this.comboBoxChapters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 48);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFirst
            // 
            this.labelFirst.Location = new System.Drawing.Point(649, 502);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(259, 20);
            this.labelFirst.TabIndex = 13;
            this.labelFirst.Text = "0";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonChapter
            // 
            this.buttonChapter.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonChapter.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonChapter.FlatAppearance.BorderSize = 2;
            this.buttonChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChapter.Location = new System.Drawing.Point(18, 53);
            this.buttonChapter.Name = "buttonChapter";
            this.buttonChapter.Size = new System.Drawing.Size(580, 47);
            this.buttonChapter.TabIndex = 15;
            this.buttonChapter.Text = "Добавить главу";
            this.buttonChapter.UseVisualStyleBackColor = false;
            this.buttonChapter.Click += new System.EventHandler(this.buttonChapter_Click);
            // 
            // buttonDescription
            // 
            this.buttonDescription.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonDescription.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonDescription.FlatAppearance.BorderSize = 2;
            this.buttonDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescription.Location = new System.Drawing.Point(18, 548);
            this.buttonDescription.Name = "buttonDescription";
            this.buttonDescription.Size = new System.Drawing.Size(286, 56);
            this.buttonDescription.TabIndex = 16;
            this.buttonDescription.Text = "Изменить описание";
            this.buttonDescription.UseVisualStyleBackColor = false;
            this.buttonDescription.Click += new System.EventHandler(this.buttonDescription_Click);
            // 
            // labelSecond
            // 
            this.labelSecond.Location = new System.Drawing.Point(951, 502);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(259, 20);
            this.labelSecond.TabIndex = 17;
            this.labelSecond.Text = "0";
            this.labelSecond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1258, 621);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.buttonDescription);
            this.Controls.Add(this.buttonChapter);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.comboBoxChapters);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxChapter);
            this.Controls.Add(this.textBoxOddDiscription);
            this.Controls.Add(this.textBoxEvenDiscription);
            this.Controls.Add(this.textBoxOddChapter);
            this.Controls.Add(this.textBoxEvenChapter);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Учи уроки по C++ с Максончиком";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.TextBox textBoxEvenChapter;
        private System.Windows.Forms.TextBox textBoxOddChapter;
        private System.Windows.Forms.TextBox textBoxEvenDiscription;
        private System.Windows.Forms.TextBox textBoxOddDiscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxChapters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Button buttonChapter;
        private System.Windows.Forms.Button buttonDescription;
        private System.Windows.Forms.Label labelSecond;
    }
}

