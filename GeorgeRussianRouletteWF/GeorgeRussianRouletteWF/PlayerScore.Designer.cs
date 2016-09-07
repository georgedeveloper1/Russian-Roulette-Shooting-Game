namespace GeorgeRussianRouletteWF
{
    partial class PlayerScore
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
            this.dgPlayerScore = new System.Windows.Forms.DataGridView();
            this.btnBackToGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlayerScore
            // 
            this.dgPlayerScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayerScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Win,
            this.Loss});
            this.dgPlayerScore.Location = new System.Drawing.Point(36, 32);
            this.dgPlayerScore.Name = "dgPlayerScore";
            this.dgPlayerScore.Size = new System.Drawing.Size(343, 489);
            this.dgPlayerScore.TabIndex = 0;
            // 
            // btnBackToGame
            // 
            this.btnBackToGame.Location = new System.Drawing.Point(57, 545);
            this.btnBackToGame.Name = "btnBackToGame";
            this.btnBackToGame.Size = new System.Drawing.Size(155, 45);
            this.btnBackToGame.TabIndex = 1;
            this.btnBackToGame.Text = "BACK TO GAME";
            this.btnBackToGame.UseVisualStyleBackColor = true;
            this.btnBackToGame.Click += new System.EventHandler(this.btnBackToGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 545);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.Name = "PlayerName";
            // 
            // Win
            // 
            this.Win.HeaderText = "Win";
            this.Win.Name = "Win";
            // 
            // Loss
            // 
            this.Loss.HeaderText = "Loss";
            this.Loss.Name = "Loss";
            // 
            // PlayerScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 602);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToGame);
            this.Controls.Add(this.dgPlayerScore);
            this.Name = "PlayerScore";
            this.Text = "Player Score";
            this.Load += new System.EventHandler(this.PlayerScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlayerScore;
        private System.Windows.Forms.Button btnBackToGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loss;
    }
}