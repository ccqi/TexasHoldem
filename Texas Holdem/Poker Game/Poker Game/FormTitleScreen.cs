using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Poker_Game
{
    public partial class FormTitleScreen : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer();
        public UserAccount user = new UserAccount();
        public FormTitleScreen()
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
            this.StartPosition = FormStartPosition.CenterScreen;
            soundPlayer = new SoundPlayer("BackgroundMusic.wav");
            soundPlayer.PlayLooping();
            btnScore.Hide();
        }
        private void FormTitleScreen_Load(object sender, EventArgs e)
        {
            LoadSound();
        }
        public void LoadSound()
        {
            if (FormPoker.musicFlag)
                btnMusic.BackgroundImage = Image.FromFile("Sound.png");
            else
                btnMusic.BackgroundImage = Image.FromFile("NoSound.png");
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormGameOptions FormGameOptions = new FormGameOptions();
            FormGameOptions.FormTitleScreen = this;
            this.Hide();
            FormGameOptions.ShowDialog(); //once formpoker closese, formgameoptions will close and menu form will popup
            this.Show(); //menu pops up to allow users to view their score, consult the user manual, or start a new game
            if (user.getUserName() != "default" && user.getPassword() != "default")
            {
                user.reLoadFromFile(); //reloads the user account so that the updated score would show.
            }
        }
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("User Manual.pdf"); //loads a pdf file
        }
        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Jaden Chen and Charles Qi or Charles Qi and Jaden Chen"+"\rSpecial mention: Lady Gaga for Poker Face");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister FormRegister = new FormRegister();
            FormRegister.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Login")
            {
                FormLogin FormLogin = new FormLogin();
                FormLogin.FormTitleScreen = this;
                FormLogin.ShowDialog();
                if (user.getUserName() != "default" && user.getPassword() != "default")
                {
                    btnLogin.Text = "Logout"; //user can only logout once they are logged in,
                    lblLoggedInAs.Text = "Logged in As : " + user.getUserName();
                    btnScore.Show();
                }
                else
                    lblLoggedInAs.Text = "";
            }
            else //when user logs out, they have the option to log into another account
            {
                btnLogin.Text = "Login";
                user = new UserAccount();
                btnScore.Hide();
                lblLoggedInAs.Text = "";
            }
        }
        private void btnScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wins : " + user.getWins() + "\rLoses : " + user.getLoses());
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            
            bool playSound = FormPoker.musicFlag;
            if (playSound)
            {
                FormPoker.musicFlag = false;
                playSound = false;
            }
            else
            {
                FormPoker.musicFlag = true;
                playSound = true;
            }
            if (playSound)
            {
                btnMusic.BackgroundImage = Image.FromFile("Sound.png");
                soundPlayer = new SoundPlayer("BackgroundMusic.wav");
                soundPlayer.PlayLooping();
            }
            else
            {
                btnMusic.BackgroundImage = Image.FromFile("NoSound.png");
                soundPlayer.Stop();
                soundPlayer.Dispose();
            }
                
        }

        
    }
}
