namespace BrickBreaker
{
    partial class BrickBreakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrickBreakerForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picGameTitle = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.BrickImageList = new System.Windows.Forms.ImageList(this.components);
            this.lblAllScores = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.btnQuit);
            this.pnlMenu.Controls.Add(this.btnRules);
            this.pnlMenu.Controls.Add(this.btnScores);
            this.pnlMenu.Controls.Add(this.btnStartGame);
            this.pnlMenu.Location = new System.Drawing.Point(209, 231);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(495, 273);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Aquamarine;
            this.btnQuit.Font = new System.Drawing.Font("Forte", 13.8F);
            this.btnQuit.Location = new System.Drawing.Point(79, 178);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(310, 34);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRules.Font = new System.Drawing.Font("Forte", 13.8F);
            this.btnRules.Location = new System.Drawing.Point(79, 138);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(310, 34);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.BtnRules_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.Aquamarine;
            this.btnScores.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.Location = new System.Drawing.Point(79, 98);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(310, 34);
            this.btnScores.TabIndex = 1;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.BtnScores_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Aquamarine;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartGame.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(79, 58);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(310, 34);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHome.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 449);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 34);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // picGameTitle
            // 
            this.picGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.picGameTitle.BackgroundImage = global::BrickBreaker.Properties.Resources.Slide1Cropepepepepdpddp;
            this.picGameTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picGameTitle.Location = new System.Drawing.Point(251, 48);
            this.picGameTitle.Name = "picGameTitle";
            this.picGameTitle.Size = new System.Drawing.Size(373, 167);
            this.picGameTitle.TabIndex = 1;
            this.picGameTitle.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGameOver.Location = new System.Drawing.Point(-5, 9);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 135);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Visible = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBall.Location = new System.Drawing.Point(807, 409);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(28, 28);
            this.picBall.TabIndex = 3;
            this.picBall.TabStop = false;
            this.picBall.Visible = false;
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picPaddle.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle.Image")));
            this.picPaddle.Location = new System.Drawing.Point(778, 409);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(76, 10);
            this.picPaddle.TabIndex = 4;
            this.picPaddle.TabStop = false;
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLevel1.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.Location = new System.Drawing.Point(736, 37);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(138, 34);
            this.btnLevel1.TabIndex = 4;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.BtnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLevel2.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.Location = new System.Drawing.Point(736, 92);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(138, 34);
            this.btnLevel2.TabIndex = 5;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.BtnLevel2_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLevel3.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel3.Location = new System.Drawing.Point(736, 149);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(138, 34);
            this.btnLevel3.TabIndex = 6;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = false;
            this.btnLevel3.Click += new System.EventHandler(this.BtnLevel3_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblScore.Location = new System.Drawing.Point(12, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(58, 23);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPlayAgain.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 396);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(143, 34);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(770, 251);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(117, 135);
            this.lblCountdown.TabIndex = 9;
            this.lblCountdown.Text = "1";
            this.lblCountdown.Visible = false;
            // 
            // BrickImageList
            // 
            this.BrickImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BrickImageList.ImageStream")));
            this.BrickImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.BrickImageList.Images.SetKeyName(0, "blue_block.png");
            this.BrickImageList.Images.SetKeyName(1, "brown_block.png");
            this.BrickImageList.Images.SetKeyName(2, "green_block.png");
            this.BrickImageList.Images.SetKeyName(3, "pink_block.png");
            this.BrickImageList.Images.SetKeyName(4, "red_block.png");
            this.BrickImageList.Images.SetKeyName(5, "skyblue_block.png");
            this.BrickImageList.Images.SetKeyName(6, "violet_block.png");
            this.BrickImageList.Images.SetKeyName(7, "yellow_block.png");
            this.BrickImageList.Images.SetKeyName(8, "stone_block.png");
            // 
            // lblAllScores
            // 
            this.lblAllScores.AutoSize = true;
            this.lblAllScores.BackColor = System.Drawing.Color.Transparent;
            this.lblAllScores.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllScores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAllScores.Location = new System.Drawing.Point(34, 289);
            this.lblAllScores.Name = "lblAllScores";
            this.lblAllScores.Size = new System.Drawing.Size(118, 34);
            this.lblAllScores.TabIndex = 10;
            this.lblAllScores.Text = "AllScore";
            this.lblAllScores.Visible = false;
            // 
            // BrickBreakerForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 506);
            this.Controls.Add(this.lblAllScores);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.picGameTitle);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.Name = "BrickBreakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brick Breaker";
            this.Load += new System.EventHandler(this.BrickBreakerForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrickBreakerForm_MouseMove);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGameTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox picGameTitle;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.ImageList BrickImageList;
        private System.Windows.Forms.Label lblAllScores;
    }
}

