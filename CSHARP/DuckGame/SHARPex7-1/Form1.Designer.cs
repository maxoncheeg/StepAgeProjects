namespace SHARPex7_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxChanging = new System.Windows.Forms.PictureBox();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.imageListGame = new System.Windows.Forms.ImageList(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChanging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChanging
            // 
            this.pictureBoxChanging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxChanging.Location = new System.Drawing.Point(368, 54);
            this.pictureBoxChanging.Name = "pictureBoxChanging";
            this.pictureBoxChanging.Size = new System.Drawing.Size(160, 240);
            this.pictureBoxChanging.TabIndex = 1;
            this.pictureBoxChanging.TabStop = false;
            // 
            // buttonMatch
            // 
            this.buttonMatch.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonMatch.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.buttonMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatch.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatch.ForeColor = System.Drawing.Color.Peru;
            this.buttonMatch.Location = new System.Drawing.Point(158, 300);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(225, 77);
            this.buttonMatch.TabIndex = 2;
            this.buttonMatch.Text = "They match!";
            this.buttonMatch.UseVisualStyleBackColor = false;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 54);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(160, 240);
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            // 
            // imageListGame
            // 
            this.imageListGame.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGame.ImageStream")));
            this.imageListGame.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGame.Images.SetKeyName(0, "im1.png");
            this.imageListGame.Images.SetKeyName(1, "im2.png");
            this.imageListGame.Images.SetKeyName(2, "im3.png");
            this.imageListGame.Images.SetKeyName(3, "im4.png");
            this.imageListGame.Images.SetKeyName(4, "im5.png");
            this.imageListGame.Images.SetKeyName(5, "im6.png");
            this.imageListGame.Images.SetKeyName(6, "im7.png");
            this.imageListGame.Images.SetKeyName(7, "im8.png");
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(391, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Changing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(178, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level:";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.SandyBrown;
            this.labelLevel.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelLevel.Location = new System.Drawing.Point(278, 58);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(24, 24);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SandyBrown;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(178, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.SandyBrown;
            this.labelScore.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelScore.Location = new System.Drawing.Point(278, 82);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(24, 24);
            this.labelScore.TabIndex = 9;
            this.labelScore.Text = "0";
            // 
            // labelInformation
            // 
            this.labelInformation.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelInformation.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.ForeColor = System.Drawing.Color.Peru;
            this.labelInformation.Location = new System.Drawing.Point(178, 121);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(184, 173);
            this.labelInformation.TabIndex = 10;
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SandyBrown;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(78, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "You should get        points!";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.SandyBrown;
            this.labelWin.Font = new System.Drawing.Font("OCR A Extended", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelWin.Location = new System.Drawing.Point(271, 5);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(24, 24);
            this.labelWin.TabIndex = 12;
            this.labelWin.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(539, 384);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.pictureBoxChanging);
            this.Controls.Add(this.labelScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Duck Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChanging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxChanging;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ImageList imageListGame;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelWin;
    }
}

