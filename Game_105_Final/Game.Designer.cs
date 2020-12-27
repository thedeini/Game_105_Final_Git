
namespace Game_105_Final
{
    partial class Game
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
            this.skor = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.nameTxt = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timerText = new System.Windows.Forms.Label();
            this.survivalTimer = new System.Windows.Forms.Timer(this.components);
            this.engel1 = new System.Windows.Forms.PictureBox();
            this.engel2 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameOverText = new System.Windows.Forms.Label();
            this.highScoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).BeginInit();
            this.SuspendLayout();
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor.Location = new System.Drawing.Point(352, 9);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(62, 31);
            this.skor.TabIndex = 0;
            this.skor.Text = "000";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nameTxt.Location = new System.Drawing.Point(714, 103);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(112, 15);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.Text = "Very Long Name";
            this.nameTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ground
            // 
            this.ground.Image = global::Game_105_Final.Properties.Resources.blackbox;
            this.ground.Location = new System.Drawing.Point(-1, 442);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(827, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 6;
            this.ground.TabStop = false;
            // 
            // avatarBox
            // 
            this.avatarBox.Image = global::Game_105_Final.Properties.Resources.default_avatar;
            this.avatarBox.Location = new System.Drawing.Point(709, 9);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(101, 91);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 4;
            this.avatarBox.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Game_105_Final.Properties.Resources.ucgen2;
            this.player.Location = new System.Drawing.Point(100, 366);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 75);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timerText.Location = new System.Drawing.Point(12, 20);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(150, 19);
            this.timerText.TabIndex = 7;
            this.timerText.Text = "You Survived For: ";
            // 
            // survivalTimer
            // 
            this.survivalTimer.Enabled = true;
            this.survivalTimer.Interval = 1000;
            this.survivalTimer.Tick += new System.EventHandler(this.survivalTimer_Tick);
            // 
            // engel1
            // 
            this.engel1.Image = global::Game_105_Final.Properties.Resources.blackbox;
            this.engel1.Location = new System.Drawing.Point(645, 366);
            this.engel1.Name = "engel1";
            this.engel1.Size = new System.Drawing.Size(22, 114);
            this.engel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel1.TabIndex = 8;
            this.engel1.TabStop = false;
            this.engel1.Tag = "engel";
            // 
            // engel2
            // 
            this.engel2.Image = global::Game_105_Final.Properties.Resources.blackbox;
            this.engel2.Location = new System.Drawing.Point(843, 375);
            this.engel2.Name = "engel2";
            this.engel2.Size = new System.Drawing.Size(22, 105);
            this.engel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engel2.TabIndex = 2;
            this.engel2.TabStop = false;
            this.engel2.Tag = "engel";
            // 
            // restartButton
            // 
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.Enabled = false;
            this.restartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restartButton.Location = new System.Drawing.Point(271, 212);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(230, 44);
            this.restartButton.TabIndex = 9;
            this.restartButton.TabStop = false;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Enabled = false;
            this.exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.Location = new System.Drawing.Point(271, 262);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(230, 44);
            this.exitButton.TabIndex = 10;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverText.Location = new System.Drawing.Point(217, 149);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(150, 19);
            this.gameOverText.TabIndex = 11;
            this.gameOverText.Text = "You Survived For: ";
            this.gameOverText.Visible = false;
            // 
            // highScoreText
            // 
            this.highScoreText.AutoSize = true;
            this.highScoreText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highScoreText.Location = new System.Drawing.Point(295, 179);
            this.highScoreText.Name = "highScoreText";
            this.highScoreText.Size = new System.Drawing.Size(99, 19);
            this.highScoreText.TabIndex = 12;
            this.highScoreText.Text = "Your Score:";
            this.highScoreText.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(822, 492);
            this.Controls.Add(this.highScoreText);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.engel2);
            this.Controls.Add(this.engel1);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.player);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Timer survivalTimer;
        private System.Windows.Forms.PictureBox engel1;
        private System.Windows.Forms.PictureBox engel2;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Label highScoreText;
    }
}