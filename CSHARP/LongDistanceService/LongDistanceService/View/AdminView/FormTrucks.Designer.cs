
namespace LongDistanceService.View.AdminView
{
    partial class FormTrucks
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
            this.listBoxTrucks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonLoadCapacity = new System.Windows.Forms.RadioButton();
            this.radioButtonBrand = new System.Windows.Forms.RadioButton();
            this.radioButtonLicensePlate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdateTruckList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTrucks
            // 
            this.listBoxTrucks.BackColor = System.Drawing.Color.PaleGreen;
            this.listBoxTrucks.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.listBoxTrucks.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBoxTrucks.FormattingEnabled = true;
            this.listBoxTrucks.ItemHeight = 20;
            this.listBoxTrucks.Location = new System.Drawing.Point(12, 38);
            this.listBoxTrucks.Name = "listBoxTrucks";
            this.listBoxTrucks.Size = new System.Drawing.Size(289, 264);
            this.listBoxTrucks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(323, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filters:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.radioButtonDesc);
            this.groupBox1.Controls.Add(this.radioButtonAsc);
            this.groupBox1.Location = new System.Drawing.Point(327, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.radioButtonDesc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonDesc.Location = new System.Drawing.Point(43, 49);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(117, 24);
            this.radioButtonDesc.TabIndex = 1;
            this.radioButtonDesc.Text = "Descending";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Checked = true;
            this.radioButtonAsc.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.radioButtonAsc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAsc.Location = new System.Drawing.Point(43, 19);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(108, 24);
            this.radioButtonAsc.TabIndex = 0;
            this.radioButtonAsc.TabStop = true;
            this.radioButtonAsc.Text = "Ascending";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox2.Controls.Add(this.radioButtonLoadCapacity);
            this.groupBox2.Controls.Add(this.radioButtonBrand);
            this.groupBox2.Controls.Add(this.radioButtonLicensePlate);
            this.groupBox2.Location = new System.Drawing.Point(327, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonLoadCapacity
            // 
            this.radioButtonLoadCapacity.AutoSize = true;
            this.radioButtonLoadCapacity.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.radioButtonLoadCapacity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonLoadCapacity.Location = new System.Drawing.Point(23, 79);
            this.radioButtonLoadCapacity.Name = "radioButtonLoadCapacity";
            this.radioButtonLoadCapacity.Size = new System.Drawing.Size(171, 24);
            this.radioButtonLoadCapacity.TabIndex = 2;
            this.radioButtonLoadCapacity.Text = "By load capacity";
            this.radioButtonLoadCapacity.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrand
            // 
            this.radioButtonBrand.AutoSize = true;
            this.radioButtonBrand.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.radioButtonBrand.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonBrand.Location = new System.Drawing.Point(23, 49);
            this.radioButtonBrand.Name = "radioButtonBrand";
            this.radioButtonBrand.Size = new System.Drawing.Size(153, 24);
            this.radioButtonBrand.TabIndex = 1;
            this.radioButtonBrand.Text = "By truck brand";
            this.radioButtonBrand.UseVisualStyleBackColor = true;
            // 
            // radioButtonLicensePlate
            // 
            this.radioButtonLicensePlate.AutoSize = true;
            this.radioButtonLicensePlate.Checked = true;
            this.radioButtonLicensePlate.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.radioButtonLicensePlate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonLicensePlate.Location = new System.Drawing.Point(23, 19);
            this.radioButtonLicensePlate.Name = "radioButtonLicensePlate";
            this.radioButtonLicensePlate.Size = new System.Drawing.Size(171, 24);
            this.radioButtonLicensePlate.TabIndex = 0;
            this.radioButtonLicensePlate.TabStop = true;
            this.radioButtonLicensePlate.Text = "By license plate";
            this.radioButtonLicensePlate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trucks";
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Cascadia Code", 13F);
            this.buttonFind.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonFind.Location = new System.Drawing.Point(327, 263);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(200, 39);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(307, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 264);
            this.label3.TabIndex = 12;
            // 
            // buttonUpdateTruckList
            // 
            this.buttonUpdateTruckList.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonUpdateTruckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateTruckList.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.buttonUpdateTruckList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateTruckList.Location = new System.Drawing.Point(77, 11);
            this.buttonUpdateTruckList.Name = "buttonUpdateTruckList";
            this.buttonUpdateTruckList.Size = new System.Drawing.Size(224, 23);
            this.buttonUpdateTruckList.TabIndex = 13;
            this.buttonUpdateTruckList.Text = "Update Truck List";
            this.buttonUpdateTruckList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUpdateTruckList.UseVisualStyleBackColor = false;
            this.buttonUpdateTruckList.Click += new System.EventHandler(this.buttonUpdateTruckList_Click);
            // 
            // FormTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(539, 306);
            this.Controls.Add(this.buttonUpdateTruckList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTrucks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTrucks";
            this.Text = "FormTrucks";
            this.Load += new System.EventHandler(this.FormTrucks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTrucks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonLoadCapacity;
        private System.Windows.Forms.RadioButton radioButtonBrand;
        private System.Windows.Forms.RadioButton radioButtonLicensePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdateTruckList;
    }
}