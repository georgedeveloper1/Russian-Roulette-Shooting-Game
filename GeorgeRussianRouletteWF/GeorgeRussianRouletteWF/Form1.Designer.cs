namespace GeorgeRussianRouletteWF
{
    partial class Form1
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
            this.lblDeadOrLuckyMessage = new System.Windows.Forms.Label();
            this.pbGunImage = new System.Windows.Forms.PictureBox();
            this.pbYourPicture = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnFireGun = new System.Windows.Forms.Button();
            this.btnSpinChamber = new System.Windows.Forms.Button();
            this.btnBulletLoad = new System.Windows.Forms.Button();
            this.spinChamberTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPointHead = new System.Windows.Forms.RadioButton();
            this.rbPointAway = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pbarTriggerCount = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckScore = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtScoresBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGunImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYourPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeadOrLuckyMessage
            // 
            this.lblDeadOrLuckyMessage.AutoSize = true;
            this.lblDeadOrLuckyMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblDeadOrLuckyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadOrLuckyMessage.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDeadOrLuckyMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDeadOrLuckyMessage.Location = new System.Drawing.Point(185, 494);
            this.lblDeadOrLuckyMessage.Name = "lblDeadOrLuckyMessage";
            this.lblDeadOrLuckyMessage.Size = new System.Drawing.Size(378, 55);
            this.lblDeadOrLuckyMessage.TabIndex = 7;
            this.lblDeadOrLuckyMessage.Text = "!!! Good Luck !!!";
            this.lblDeadOrLuckyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGunImage
            // 
            this.pbGunImage.BackColor = System.Drawing.Color.Transparent;
            this.pbGunImage.Location = new System.Drawing.Point(807, 12);
            this.pbGunImage.Name = "pbGunImage";
            this.pbGunImage.Size = new System.Drawing.Size(696, 479);
            this.pbGunImage.TabIndex = 5;
            this.pbGunImage.TabStop = false;
            // 
            // pbYourPicture
            // 
            this.pbYourPicture.BackColor = System.Drawing.Color.Transparent;
            this.pbYourPicture.Location = new System.Drawing.Point(12, 12);
            this.pbYourPicture.Name = "pbYourPicture";
            this.pbYourPicture.Size = new System.Drawing.Size(764, 479);
            this.pbYourPicture.TabIndex = 4;
            this.pbYourPicture.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(1005, 797);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(155, 45);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnFireGun
            // 
            this.btnFireGun.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.btnFireGun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFireGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireGun.Location = new System.Drawing.Point(1245, 634);
            this.btnFireGun.Name = "btnFireGun";
            this.btnFireGun.Size = new System.Drawing.Size(258, 115);
            this.btnFireGun.TabIndex = 2;
            this.btnFireGun.Text = "Fire";
            this.btnFireGun.UseVisualStyleBackColor = true;
            this.btnFireGun.Click += new System.EventHandler(this.btnFireGun_Click);
            // 
            // btnSpinChamber
            // 
            this.btnSpinChamber.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.btnSpinChamber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpinChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChamber.Location = new System.Drawing.Point(1005, 711);
            this.btnSpinChamber.Name = "btnSpinChamber";
            this.btnSpinChamber.Size = new System.Drawing.Size(206, 38);
            this.btnSpinChamber.TabIndex = 1;
            this.btnSpinChamber.Text = "Spin Chamber";
            this.btnSpinChamber.UseVisualStyleBackColor = true;
            this.btnSpinChamber.Click += new System.EventHandler(this.btnSpinChamber_Click);
            // 
            // btnBulletLoad
            // 
            this.btnBulletLoad.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.btnBulletLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBulletLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulletLoad.Location = new System.Drawing.Point(1005, 634);
            this.btnBulletLoad.Name = "btnBulletLoad";
            this.btnBulletLoad.Size = new System.Drawing.Size(206, 38);
            this.btnBulletLoad.TabIndex = 0;
            this.btnBulletLoad.Text = "Load Bullet";
            this.btnBulletLoad.UseVisualStyleBackColor = true;
            this.btnBulletLoad.Click += new System.EventHandler(this.btnBulletLoad_Click);
            // 
            // spinChamberTimer
            // 
            this.spinChamberTimer.Interval = 10;
            this.spinChamberTimer.Tick += new System.EventHandler(this.spinChamberTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.groupBox1.Controls.Add(this.rbPointHead);
            this.groupBox1.Controls.Add(this.rbPointAway);
            this.groupBox1.Location = new System.Drawing.Point(1005, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // rbPointHead
            // 
            this.rbPointHead.AutoSize = true;
            this.rbPointHead.BackColor = System.Drawing.Color.Transparent;
            this.rbPointHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPointHead.Location = new System.Drawing.Point(302, 28);
            this.rbPointHead.Name = "rbPointHead";
            this.rbPointHead.Size = new System.Drawing.Size(142, 20);
            this.rbPointHead.TabIndex = 1;
            this.rbPointHead.TabStop = true;
            this.rbPointHead.Text = "POINT AT HEAD";
            this.rbPointHead.UseVisualStyleBackColor = false;
            this.rbPointHead.CheckedChanged += new System.EventHandler(this.rbPointHead_CheckedChanged);
            // 
            // rbPointAway
            // 
            this.rbPointAway.AutoSize = true;
            this.rbPointAway.BackColor = System.Drawing.Color.Transparent;
            this.rbPointAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPointAway.Location = new System.Drawing.Point(45, 28);
            this.rbPointAway.Name = "rbPointAway";
            this.rbPointAway.Size = new System.Drawing.Size(120, 20);
            this.rbPointAway.TabIndex = 0;
            this.rbPointAway.TabStop = true;
            this.rbPointAway.Text = "POINT AWAY";
            this.rbPointAway.UseVisualStyleBackColor = false;
            this.rbPointAway.CheckedChanged += new System.EventHandler(this.rbPointAway_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(1002, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Step 1:";
            // 
            // pbarTriggerCount
            // 
            this.pbarTriggerCount.BackColor = System.Drawing.Color.Tan;
            this.pbarTriggerCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.pbarTriggerCount.Location = new System.Drawing.Point(85, 582);
            this.pbarTriggerCount.Maximum = 6;
            this.pbarTriggerCount.Name = "pbarTriggerCount";
            this.pbarTriggerCount.Size = new System.Drawing.Size(762, 10);
            this.pbarTriggerCount.Step = 6;
            this.pbarTriggerCount.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(79, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trigger Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(203, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(457, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(329, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(582, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(711, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(766, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "6";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1327, 797);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckScore
            // 
            this.btnCheckScore.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.howToBg;
            this.btnCheckScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckScore.Location = new System.Drawing.Point(1166, 797);
            this.btnCheckScore.Name = "btnCheckScore";
            this.btnCheckScore.Size = new System.Drawing.Size(155, 45);
            this.btnCheckScore.TabIndex = 19;
            this.btnCheckScore.Text = "Check Score";
            this.btnCheckScore.UseVisualStyleBackColor = true;
            this.btnCheckScore.Click += new System.EventHandler(this.btnCheckScore_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(1002, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Step 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(1242, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Step 4:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(1002, 687);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Step 3:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(1217, 767);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Step: 5";
            // 
            // txtScoresBox
            // 
            this.txtScoresBox.BackColor = System.Drawing.Color.Tan;
            this.txtScoresBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoresBox.Location = new System.Drawing.Point(85, 682);
            this.txtScoresBox.Multiline = true;
            this.txtScoresBox.Name = "txtScoresBox";
            this.txtScoresBox.Size = new System.Drawing.Size(762, 103);
            this.txtScoresBox.TabIndex = 25;
            this.txtScoresBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(426, 655);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Messages";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeorgeRussianRouletteWF.Properties.Resources.gameBg;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtScoresBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCheckScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbarTriggerCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDeadOrLuckyMessage);
            this.Controls.Add(this.pbGunImage);
            this.Controls.Add(this.pbYourPicture);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnFireGun);
            this.Controls.Add(this.btnSpinChamber);
            this.Controls.Add(this.btnBulletLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGunImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYourPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBulletLoad;
        private System.Windows.Forms.Button btnSpinChamber;
        private System.Windows.Forms.Button btnFireGun;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox pbYourPicture;
        private System.Windows.Forms.PictureBox pbGunImage;
        private System.Windows.Forms.Label lblDeadOrLuckyMessage;
        private System.Windows.Forms.Timer spinChamberTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPointHead;
        private System.Windows.Forms.RadioButton rbPointAway;
        private System.Windows.Forms.ProgressBar pbarTriggerCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtScoresBox;
        private System.Windows.Forms.Label label13;
    }
}

