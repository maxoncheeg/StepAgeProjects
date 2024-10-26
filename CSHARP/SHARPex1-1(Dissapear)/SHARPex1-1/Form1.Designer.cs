namespace SHARPex1_1
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
            this.Label = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(653, 292);
            this.Label.TabIndex = 4;
            this.Label.Text = "*Disappear*";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Up.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Up.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Up.Location = new System.Drawing.Point(273, 304);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(137, 64);
            this.Up.TabIndex = 7;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = false;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Down.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Down.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Down.Location = new System.Drawing.Point(273, 374);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(137, 64);
            this.Down.TabIndex = 8;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = false;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Left.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Left.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Left.Location = new System.Drawing.Point(130, 374);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(137, 64);
            this.Left.TabIndex = 9;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Right.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Right.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Right.Location = new System.Drawing.Point(416, 374);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(137, 64);
            this.Right.TabIndex = 10;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Тетрис на минималках";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
    }
}

