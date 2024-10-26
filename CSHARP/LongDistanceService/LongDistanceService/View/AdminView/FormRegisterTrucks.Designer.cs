
namespace LongDistanceService.View.AdminView
{
    partial class FormRegisterTrucks
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
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonChangePhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.numericUpDownLoadCapacity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoadCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(148, 95);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonChangePhoto
            // 
            this.buttonChangePhoto.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePhoto.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.buttonChangePhoto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonChangePhoto.Location = new System.Drawing.Point(148, 301);
            this.buttonChangePhoto.Name = "buttonChangePhoto";
            this.buttonChangePhoto.Size = new System.Drawing.Size(200, 27);
            this.buttonChangePhoto.TabIndex = 1;
            this.buttonChangePhoto.Text = "Change photo";
            this.buttonChangePhoto.UseVisualStyleBackColor = false;
            this.buttonChangePhoto.Click += new System.EventHandler(this.buttonChangePhoto_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "License plate";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Load Capacity";
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLicensePlate.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLicensePlate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxLicensePlate.Location = new System.Drawing.Point(148, 9);
            this.textBoxLicensePlate.MaxLength = 6;
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(200, 22);
            this.textBoxLicensePlate.TabIndex = 6;
            this.textBoxLicensePlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownLoadCapacity
            // 
            this.numericUpDownLoadCapacity.BackColor = System.Drawing.Color.PaleGreen;
            this.numericUpDownLoadCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownLoadCapacity.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownLoadCapacity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.numericUpDownLoadCapacity.Location = new System.Drawing.Point(148, 67);
            this.numericUpDownLoadCapacity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownLoadCapacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLoadCapacity.Name = "numericUpDownLoadCapacity";
            this.numericUpDownLoadCapacity.Size = new System.Drawing.Size(156, 22);
            this.numericUpDownLoadCapacity.TabIndex = 7;
            this.numericUpDownLoadCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownLoadCapacity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 233);
            this.label4.TabIndex = 8;
            this.label4.Text = "Photo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.BackColor = System.Drawing.Color.PaleGreen;
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "MAN",
            "KAMAZ",
            "SCANIA",
            "VOLVO",
            "IVECO"});
            this.comboBoxBrand.Location = new System.Drawing.Point(149, 38);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(199, 21);
            this.comboBoxBrand.TabIndex = 9;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Cascadia Code", 13F);
            this.buttonRegister.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegister.Location = new System.Drawing.Point(12, 335);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(336, 36);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(310, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "tons";
            // 
            // FormRegisterTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(359, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownLoadCapacity);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangePhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegisterTrucks";
            this.Text = "Register New Truck";
            this.Load += new System.EventHandler(this.FormRegisterTrucks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoadCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonChangePhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.NumericUpDown numericUpDownLoadCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label5;
    }
}