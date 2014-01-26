using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker_Game
{
    public partial class FormGameOptions : Form
    {
        public FormTitleScreen FormTitleScreen;
        string playerName;
        int BuyInAmount = 5000, playerAmount = 1, difficulty = 1;
        UserAccount user;
        public FormGameOptions()
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormGameOptions_Load(object sender, EventArgs e)
        {
            user = new UserAccount(FormTitleScreen.user);
            txtYourName.Text = user.getName();
            if (user.getName() != "Player") //players logged in have a specified name they that shouldn't be able to change
                txtYourName.Enabled = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            playerName = txtYourName.Text;
            BuyInAmount = (int)nudBuyIn.Value;
            if (rbEasy.Checked)
                difficulty = 0;
            else if (rbMedium.Checked)
                difficulty = 1;
            else
                difficulty = 2;
            if (playerName == null || playerAmount < 2)
            {
                MessageBox.Show("Please choose game options before beginning.");
                return;
            }
            this.Hide();
            FormPoker FormPoker = new FormPoker(playerName, BuyInAmount, playerAmount, difficulty, user);
            
            FormPoker.ShowDialog();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.FlatAppearance.BorderColor = Color.Red;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn4.FlatAppearance.BorderColor = Color.Black;
            playerAmount = 2;
            rbHard.Show();
        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatAppearance.BorderColor = Color.Red;
            btn4.FlatAppearance.BorderColor = Color.Black;
            playerAmount = 3;
            rbHard.Hide();
            if (rbHard.Checked)
                rbMedium.Checked = true;
        }

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn4.FlatAppearance.BorderColor = Color.Red;
            playerAmount = 4;
            rbHard.Hide();
            if (rbHard.Checked)
                rbMedium.Checked = true;
        }
        private void FormGameOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormTitleScreen.LoadSound();
            FormTitleScreen.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
