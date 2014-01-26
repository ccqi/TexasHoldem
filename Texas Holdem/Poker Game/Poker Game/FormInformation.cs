using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Holdem;
namespace Poker_Game
{
    /// <summary>
    /// displays information about the AI to the user
    /// </summary>
    public partial class FormInformation : Form
    {
        int counter;
        PlayerList AI;
        public FormInformation(PlayerList AI)
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
            this.AI=AI;
            counter = 0;
        }
        private void FormInformation_Load(object sender, EventArgs e)
        {
            timerStart.Start();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (counter >= AI.Count - 1)
            {
                this.Close();
                return;
            }
            counter++;
            AIPlayer currentAI=(AIPlayer)AI[counter];
            lblName.Text = currentAI.Name;
            lblInformation.Text = currentAI.Information;
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Stop();
            counter++;
            AIPlayer currentAI = (AIPlayer)AI[counter];
            btnNext.Show();
            lblName.Location = new Point(12, 24);
            lblName.Text = currentAI.Name;
            lblInformation.Text = currentAI.Information;
        }

        
    }
}
