namespace BrickBreaker
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.brickWallPic = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.highScores = new System.Windows.Forms.Label();
            this.twoplayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLabel.Location = new System.Drawing.Point(304, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(496, 91);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MAIN MENU";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playLabel
            // 
            this.playLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.playLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playLabel.Location = new System.Drawing.Point(433, 163);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(244, 87);
            this.playLabel.TabIndex = 1;
            this.playLabel.Text = "PLAY";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playLabel.Click += new System.EventHandler(this.playButton_Click);
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.highscoreLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscoreLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.highscoreLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highscoreLabel.Location = new System.Drawing.Point(1308, 97);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(1196, 1331);
            this.highscoreLabel.TabIndex = 2;
            this.highscoreLabel.Text = "High Score For Testing Purposes";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.highscoreLabel.Visible = false;
            // 
            // exitLabel
            // 
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.exitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitLabel.Location = new System.Drawing.Point(433, 479);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(284, 109);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brickWallPic
            // 
            this.brickWallPic.Location = new System.Drawing.Point(16, 0);
            this.brickWallPic.Name = "brickWallPic";
            this.brickWallPic.Size = new System.Drawing.Size(23, 637);
            this.brickWallPic.TabIndex = 4;
            this.brickWallPic.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel.Location = new System.Drawing.Point(844, 104);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(211, 389);
            this.scoreLabel.TabIndex = 5;
            // 
            // highScores
            // 
            this.highScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScores.ForeColor = System.Drawing.SystemColors.Control;
            this.highScores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highScores.Location = new System.Drawing.Point(308, 392);
            this.highScores.Name = "highScores";
            this.highScores.Size = new System.Drawing.Size(512, 87);
            this.highScores.TabIndex = 6;
            this.highScores.Text = "HIGH SCORES";
            this.highScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.highScores.Click += new System.EventHandler(this.highScores_Click);
            // 
            // twoplayer
            // 
            this.twoplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twoplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoplayer.ForeColor = System.Drawing.SystemColors.Control;
            this.twoplayer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.twoplayer.Location = new System.Drawing.Point(411, 277);
            this.twoplayer.Name = "twoplayer";
            this.twoplayer.Size = new System.Drawing.Size(310, 87);
            this.twoplayer.TabIndex = 7;
            this.twoplayer.Text = "2PLAYER";
            this.twoplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twoplayer.Click += new System.EventHandler(this.twoplayer_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.twoplayer);
            this.Controls.Add(this.highScores);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.brickWallPic);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1067, 640);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.PictureBox brickWallPic;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label highScores;
        private System.Windows.Forms.Label twoplayer;
    }
}
