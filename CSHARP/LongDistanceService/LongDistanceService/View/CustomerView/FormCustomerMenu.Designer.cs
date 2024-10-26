
namespace LongDistanceService.View.CustomerView
{
    partial class FormCustomerMenu
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
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(85)))), ((int)(((byte)(54)))));
            this.buttonMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeOrder.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.buttonMakeOrder.Location = new System.Drawing.Point(66, 58);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(348, 108);
            this.buttonMakeOrder.TabIndex = 12;
            this.buttonMakeOrder.Text = "Make an order";
            this.buttonMakeOrder.UseVisualStyleBackColor = false;
            this.buttonMakeOrder.Click += new System.EventHandler(this.buttonMakeOrder_Click);
            // 
            // FormCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(489, 242);
            this.Controls.Add(this.buttonMakeOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCustomerMenu";
            this.Text = "FormCustomerMenu";
            this.Load += new System.EventHandler(this.FormCustomerMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMakeOrder;
    }
}