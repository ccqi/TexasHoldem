namespace Poker_Game
{
    partial class FormTitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTitleScreen));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbTitleImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(121, 393);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(89, 25);
            this.btnCredits.TabIndex = 10;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(121, 362);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(89, 25);
            this.btnHowToPlay.TabIndex = 9;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(58, 330);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(224, 25);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Let\'s Play Some Poker! (Start Game)";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbTitleImage
            // 
            this.pbTitleImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTitleImage.BackgroundImage")));
            this.pbTitleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTitleImage.Location = new System.Drawing.Point(3, 3);
            this.pbTitleImage.Name = "pbTitleImage";
            this.pbTitleImage.Size = new System.Drawing.Size(201, 206);
            this.pbTitleImage.TabIndex = 7;
            this.pbTitleImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pbTitleImage);
            this.panel1.Location = new System.Drawing.Point(65, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 212);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 70);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(17, 465);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 25);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(248, 465);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 25);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInAs.Location = new System.Drawing.Point(15, 497);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(0, 13);
            this.lblLoggedInAs.TabIndex = 16;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(121, 465);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(89, 25);
            this.btnScore.TabIndex = 17;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusic.BackgroundImage")));
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Location = new System.Drawing.Point(259, 385);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(40, 40);
            this.btnMusic.TabIndex = 26;
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // FormTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(335, 520);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel1);
            this.Name = "FormTitleScreen";
            this.Text = "Texas Hold\'em Poker";
            this.Load += new System.EventHandler(this.FormTitleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbTitleImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnMusic;
    }
}

