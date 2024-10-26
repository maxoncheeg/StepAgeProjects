
namespace LongDistanceService.View
{
    partial class FormMakeOrder
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
            this.textBoxOrderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCargoWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOrderName
            // 
            this.textBoxOrderName.Location = new System.Drawing.Point(131, 9);
            this.textBoxOrderName.Name = "textBoxOrderName";
            this.textBoxOrderName.Size = new System.Drawing.Size(431, 26);
            this.textBoxOrderName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo weight";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownCargoWeight
            // 
            this.numericUpDownCargoWeight.Location = new System.Drawing.Point(131, 48);
            this.numericUpDownCargoWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCargoWeight.Name = "numericUpDownCargoWeight";
            this.numericUpDownCargoWeight.Size = new System.Drawing.Size(373, 26);
            this.numericUpDownCargoWeight.TabIndex = 3;
            this.numericUpDownCargoWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCargoWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(510, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "tons";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(131, 85);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(431, 119);
            this.textBoxDescription.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(550, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supported cities";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightCyan;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "From";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFrom.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(109, 254);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(161, 24);
            this.comboBoxFrom.TabIndex = 9;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTo.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(401, 253);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(161, 24);
            this.comboBoxTo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCyan;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(304, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "To";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeOrder.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeOrder.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonMakeOrder.Location = new System.Drawing.Point(12, 285);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(550, 47);
            this.buttonMakeOrder.TabIndex = 12;
            this.buttonMakeOrder.Text = "Make the order";
            this.buttonMakeOrder.UseVisualStyleBackColor = false;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // FormMakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(574, 341);
            this.Controls.Add(this.buttonMakeOrder);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCargoWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrderName);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMakeOrder";
            this.Text = "Make Order";
            this.Load += new System.EventHandler(this.FormMakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCargoWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMakeOrder;
    }
}