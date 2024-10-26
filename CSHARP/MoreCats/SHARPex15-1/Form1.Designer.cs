
namespace SHARPex15_1
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
            this.listBoxCats = new System.Windows.Forms.ListBox();
            this.pictureBoxForCats = new System.Windows.Forms.PictureBox();
            this.labelCatName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCats)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCats
            // 
            this.listBoxCats.BackColor = System.Drawing.Color.Plum;
            this.listBoxCats.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.listBoxCats.FormattingEnabled = true;
            this.listBoxCats.ItemHeight = 24;
            this.listBoxCats.Location = new System.Drawing.Point(10, 9);
            this.listBoxCats.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxCats.Name = "listBoxCats";
            this.listBoxCats.Size = new System.Drawing.Size(342, 484);
            this.listBoxCats.TabIndex = 0;
            this.listBoxCats.SelectedIndexChanged += new System.EventHandler(this.listBoxCats_SelectedIndexChanged);
            // 
            // pictureBoxForCats
            // 
            this.pictureBoxForCats.Location = new System.Drawing.Point(370, 11);
            this.pictureBoxForCats.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxForCats.Name = "pictureBoxForCats";
            this.pictureBoxForCats.Size = new System.Drawing.Size(421, 422);
            this.pictureBoxForCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxForCats.TabIndex = 1;
            this.pictureBoxForCats.TabStop = false;
            // 
            // labelCatName
            // 
            this.labelCatName.BackColor = System.Drawing.Color.Plum;
            this.labelCatName.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelCatName.Location = new System.Drawing.Point(370, 439);
            this.labelCatName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(421, 54);
            this.labelCatName.TabIndex = 2;
            this.labelCatName.Text = "Some Cat";
            this.labelCatName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 542);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Pink;
            this.tabPage1.Controls.Add(this.pictureBoxForCats);
            this.tabPage1.Controls.Add(this.labelCatName);
            this.tabPage1.Controls.Add(this.listBoxCats);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(807, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cats";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Pink;
            this.tabPage2.Controls.Add(this.buttonAdd);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxCatName);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(807, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AddCat";
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.BackColor = System.Drawing.Color.Plum;
            this.textBoxCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCatName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBoxCatName.Location = new System.Drawing.Point(225, 190);
            this.textBoxCatName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(356, 32);
            this.textBoxCatName.TabIndex = 0;
            this.textBoxCatName.TextChanged += new System.EventHandler(this.textBoxCatName_TextChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(225, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cat name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Plum;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAdd.Location = new System.Drawing.Point(225, 240);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(356, 76);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(840, 568);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Cats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForCats)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCats;
        private System.Windows.Forms.PictureBox pictureBoxForCats;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCatName;
    }
}

