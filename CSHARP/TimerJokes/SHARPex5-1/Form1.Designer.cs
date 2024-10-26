namespace SHARPex5_1
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.timerPicture = new System.Windows.Forms.Timer(this.components);
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.timerButton = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(171)))), ((int)(((byte)(211)))));
            this.buttonSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSwitch.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitch.Location = new System.Drawing.Point(360, 333);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(117, 66);
            this.buttonSwitch.TabIndex = 1;
            this.buttonSwitch.Text = "Start/Stop";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // timerPicture
            // 
            this.timerPicture.Interval = 1;
            this.timerPicture.Tick += new System.EventHandler(this.timerPicture_Tick);
            // 
            // timerColor
            // 
            this.timerColor.Interval = 1;
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // timerButton
            // 
            this.timerButton.Interval = 1;
            this.timerButton.Tick += new System.EventHandler(this.timerButton_Tick);
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.Image = global::SHARPex5_1.Properties.Resources.goose;
            this.pictureBoxOut.Location = new System.Drawing.Point(259, 12);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(323, 299);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOut.TabIndex = 0;
            this.pictureBoxOut.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.pictureBoxOut);
            this.Name = "form1";
            this.Text = "form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Timer timerPicture;
        private System.Windows.Forms.Timer timerColor;
        private System.Windows.Forms.Timer timerButton;
    }
}

