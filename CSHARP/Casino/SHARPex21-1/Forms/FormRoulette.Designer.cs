
namespace SHARPex21_1.Forms
{
    partial class FormRoulette
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoulette));
            this.imageListRoulette = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.labelEnemyNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.labelEnemyMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPlayerMoney = new System.Windows.Forms.Label();
            this.radioButton5000 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1000 = new System.Windows.Forms.RadioButton();
            this.radioButton200 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.timerChecker = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoulette = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoulette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListRoulette
            // 
            this.imageListRoulette.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRoulette.ImageStream")));
            this.imageListRoulette.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRoulette.Images.SetKeyName(0, "1.png");
            this.imageListRoulette.Images.SetKeyName(1, "2.png");
            this.imageListRoulette.Images.SetKeyName(2, "3.png");
            this.imageListRoulette.Images.SetKeyName(3, "4.png");
            this.imageListRoulette.Images.SetKeyName(4, "5.png");
            this.imageListRoulette.Images.SetKeyName(5, "6.png");
            this.imageListRoulette.Images.SetKeyName(6, "7.png");
            this.imageListRoulette.Images.SetKeyName(7, "8.png");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label10.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.PeachPuff;
            this.label10.Location = new System.Drawing.Point(433, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Roulette";
            // 
            // labelEnemyNumber
            // 
            this.labelEnemyNumber.AutoSize = true;
            this.labelEnemyNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.labelEnemyNumber.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyNumber.ForeColor = System.Drawing.Color.PeachPuff;
            this.labelEnemyNumber.Location = new System.Drawing.Point(913, 501);
            this.labelEnemyNumber.Name = "labelEnemyNumber";
            this.labelEnemyNumber.Size = new System.Drawing.Size(25, 31);
            this.labelEnemyNumber.TabIndex = 32;
            this.labelEnemyNumber.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label8.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(683, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "His number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label7.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(18, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "Number:";
            // 
            // numericUpDownPlayerNumber
            // 
            this.numericUpDownPlayerNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.numericUpDownPlayerNumber.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold);
            this.numericUpDownPlayerNumber.ForeColor = System.Drawing.Color.PeachPuff;
            this.numericUpDownPlayerNumber.Location = new System.Drawing.Point(161, 409);
            this.numericUpDownPlayerNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownPlayerNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlayerNumber.Name = "numericUpDownPlayerNumber";
            this.numericUpDownPlayerNumber.Size = new System.Drawing.Size(156, 46);
            this.numericUpDownPlayerNumber.TabIndex = 29;
            this.numericUpDownPlayerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPlayerNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlayerNumber.ValueChanged += new System.EventHandler(this.numericUpDownPlayerNumber_ValueChanged);
            // 
            // buttonSpin
            // 
            this.buttonSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.buttonSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpin.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSpin.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonSpin.Location = new System.Drawing.Point(19, 461);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(298, 71);
            this.buttonSpin.TabIndex = 28;
            this.buttonSpin.Text = "Spin";
            this.buttonSpin.UseVisualStyleBackColor = false;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // labelEnemyMoney
            // 
            this.labelEnemyMoney.AutoSize = true;
            this.labelEnemyMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.labelEnemyMoney.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyMoney.ForeColor = System.Drawing.Color.PeachPuff;
            this.labelEnemyMoney.Location = new System.Drawing.Point(863, 441);
            this.labelEnemyMoney.Name = "labelEnemyMoney";
            this.labelEnemyMoney.Size = new System.Drawing.Size(117, 31);
            this.labelEnemyMoney.TabIndex = 26;
            this.labelEnemyMoney.Text = "20000$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label5.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(683, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "His money:";
            // 
            // labelPlayerMoney
            // 
            this.labelPlayerMoney.AutoSize = true;
            this.labelPlayerMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.labelPlayerMoney.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerMoney.ForeColor = System.Drawing.Color.PeachPuff;
            this.labelPlayerMoney.Location = new System.Drawing.Point(200, 282);
            this.labelPlayerMoney.Name = "labelPlayerMoney";
            this.labelPlayerMoney.Size = new System.Drawing.Size(117, 31);
            this.labelPlayerMoney.TabIndex = 24;
            this.labelPlayerMoney.Text = "20000$";
            // 
            // radioButton5000
            // 
            this.radioButton5000.AutoSize = true;
            this.radioButton5000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.radioButton5000.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5000.ForeColor = System.Drawing.Color.PeachPuff;
            this.radioButton5000.Location = new System.Drawing.Point(200, 37);
            this.radioButton5000.Name = "radioButton5000";
            this.radioButton5000.Size = new System.Drawing.Size(98, 29);
            this.radioButton5000.TabIndex = 2;
            this.radioButton5000.Text = "5000$";
            this.radioButton5000.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.radioButton5000);
            this.groupBox1.Controls.Add(this.radioButton1000);
            this.groupBox1.Controls.Add(this.radioButton200);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Location = new System.Drawing.Point(17, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 87);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bet";
            // 
            // radioButton1000
            // 
            this.radioButton1000.AutoSize = true;
            this.radioButton1000.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.radioButton1000.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1000.ForeColor = System.Drawing.Color.PeachPuff;
            this.radioButton1000.Location = new System.Drawing.Point(96, 37);
            this.radioButton1000.Name = "radioButton1000";
            this.radioButton1000.Size = new System.Drawing.Size(93, 29);
            this.radioButton1000.TabIndex = 1;
            this.radioButton1000.Text = "1000$";
            this.radioButton1000.UseVisualStyleBackColor = false;
            // 
            // radioButton200
            // 
            this.radioButton200.AutoSize = true;
            this.radioButton200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.radioButton200.Checked = true;
            this.radioButton200.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton200.ForeColor = System.Drawing.Color.PeachPuff;
            this.radioButton200.Location = new System.Drawing.Point(6, 37);
            this.radioButton200.Name = "radioButton200";
            this.radioButton200.Size = new System.Drawing.Size(84, 29);
            this.radioButton200.TabIndex = 0;
            this.radioButton200.TabStop = true;
            this.radioButton200.Text = "200$";
            this.radioButton200.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(18, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Your money:";
            // 
            // timerChecker
            // 
            this.timerChecker.Interval = 10;
            this.timerChecker.Tick += new System.EventHandler(this.timerChecker_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(820, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Your Enemy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(33)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Player(YOU)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SHARPex21_1.Properties.Resources.checker;
            this.pictureBox4.Location = new System.Drawing.Point(426, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxRoulette
            // 
            this.pictureBoxRoulette.Image = global::SHARPex21_1.Properties.Resources._1;
            this.pictureBoxRoulette.Location = new System.Drawing.Point(342, 212);
            this.pictureBoxRoulette.Name = "pictureBoxRoulette";
            this.pictureBoxRoulette.Size = new System.Drawing.Size(313, 320);
            this.pictureBoxRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoulette.TabIndex = 19;
            this.pictureBoxRoulette.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SHARPex21_1.Properties.Resources.player;
            this.pictureBox1.Location = new System.Drawing.Point(18, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SHARPex21_1.Properties.Resources.enemy;
            this.pictureBox2.Location = new System.Drawing.Point(677, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 325);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartNewGameToolStripMenuItem,
            this.showStatisticToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.действияToolStripMenuItem.Text = "Actions";
            // 
            // StartNewGameToolStripMenuItem
            // 
            this.StartNewGameToolStripMenuItem.Name = "StartNewGameToolStripMenuItem";
            this.StartNewGameToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.StartNewGameToolStripMenuItem.Text = "Start new game";
            this.StartNewGameToolStripMenuItem.Click += new System.EventHandler(this.StartNewGameToolStripMenuItem_Click);
            // 
            // showStatisticToolStripMenuItem
            // 
            this.showStatisticToolStripMenuItem.Name = "showStatisticToolStripMenuItem";
            this.showStatisticToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showStatisticToolStripMenuItem.Text = "Show Statistic";
            this.showStatisticToolStripMenuItem.Click += new System.EventHandler(this.showStatisticToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fToolStripMenuItem.Text = "Rules";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // FormRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SHARPex21_1.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(1004, 558);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelEnemyNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownPlayerNumber);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.labelEnemyMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPlayerMoney);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRoulette);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRoulette";
            this.Text = "Casino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRoulette_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayerNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoulette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListRoulette;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEnemyNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownPlayerNumber;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Label labelEnemyMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPlayerMoney;
        private System.Windows.Forms.RadioButton radioButton5000;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1000;
        private System.Windows.Forms.RadioButton radioButton200;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerChecker;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRoulette;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}