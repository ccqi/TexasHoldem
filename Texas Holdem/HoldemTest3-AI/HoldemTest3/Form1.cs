using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Holdem;

namespace HoldemTest3
{
    public partial class Form1 : Form
    {
        Table pokerTable;
        PlayerList playerList;
        int playerAmount;
        Random rand;
        String text;
        double handValue;
        Graphics g;
        Bitmap b;
        public Form1()
        {
            InitializeComponent();
            playerList = new PlayerList();
            playerAmount = 0;
            rand = new Random();
            text = "";
            b = new Bitmap(pbCards.Width, pbCards.Height);
            g = Graphics.FromImage(b);
        }
        List<int> shuffle(List<int> shuffle)
        {
            var rand = new Random();
            for (int i = shuffle.Count - 1; i > 0; i--)
            {
                int n = rand.Next(i + 1);
                int temp = shuffle[i];
                shuffle[i] = shuffle[n];
                shuffle[n] = temp;
            }
            return shuffle;
        }
        private void btnPlayers_Click(object sender, EventArgs e)
        {
            playerList.Clear();
            lbMain.Items.Clear();
            playerAmount = Convert.ToInt32(nudPlayers.Value);
            Player user = new Player("Player", 50000);
            playerList.Add(user);
            List<int> AI = new List<int>(playerAmount);
            for (int i = 0; i < 3; i++)
            {
                AI.Add(i);
            }
            for (int i = 0; i < 4 - playerAmount; i++)
            {
                AI.Remove(rand.Next(AI.Count));
            }
            AI = shuffle(AI);
            for (int i = 1; i < playerAmount; i++)
            {
                playerList.Add(new AIPlayer(50000, 1, AI[i - 1]));
            }
            pokerTable = new Table(playerList);
            foreach (Player player in pokerTable)
            {
                lbMain.Items.Add(player.Name);
            }
            lbMain.SelectedIndex = rand.Next(lbMain.Items.Count - 1) + 1;
        }
        private void btnHole_Click(object sender, EventArgs e)
        {
            g.Clear(pbCards.BackColor);
            pokerTable.startNextMatch();
            pokerTable.getPlayers().ResetPlayers();
            
            int index = lbMain.SelectedIndex;
            pokerTable.DealHoleCards();
            for (int i = 0; i < pokerTable[index].getHand().Count(); i++)
            {
                Card c = pokerTable[index].getHand()[i];
                c.FaceUp = true;
                g.DrawImage(c.getImage(), 20+i*75, 10, 71, 96);
            }
            pbCards.Image = b;
        }
        private void btnFlop_Click(object sender, EventArgs e)
        {
            g.Clear(pbCards.BackColor);
            int index = lbMain.SelectedIndex;
            if (pokerTable[index].getHand().Count() > 2)
                return;
            pokerTable.DealFlop();
            for (int i = 0; i < pokerTable[index].getHand().Count(); i++)
            {
                Card c = pokerTable[index].getHand()[i];
                c.FaceUp = true;
                g.DrawImage(c.getImage(), 20 + i * 75, 10, 71, 96);
            }
            pbCards.Image = b;
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            g.Clear(pbCards.BackColor);
            int index = lbMain.SelectedIndex;
            if (pokerTable[index].getHand().Count() > 5)
                return;
            pokerTable.DealTurn();
            for (int i = 0; i < pokerTable[index].getHand().Count(); i++)
            {
                Card c = pokerTable[index].getHand()[i];
                c.FaceUp = true;
                g.DrawImage(c.getImage(), 20 + i * 75, 10, 71, 96);
            }
            pbCards.Image = b;
        }

        private void btnRiver_Click(object sender, EventArgs e)
        {
            g.Clear(pbCards.BackColor);
            int index = lbMain.SelectedIndex;
            if (pokerTable[index].getHand().Count() > 6)
                return;
            pokerTable.DealRiver();
            for (int i = 0; i < pokerTable[index].getHand().Count(); i++)
            {
                Card c = pokerTable[index].getHand()[i];
                c.FaceUp = true;
                g.DrawImage(c.getImage(), 20 + i * 75, 10, 71, 96);
            }
            pbCards.Image = b;
        }

        private void btnHandValue_Click(object sender, EventArgs e)
        {
            int index = lbMain.SelectedIndex;
            AIPlayer currentPlayer = (AIPlayer)pokerTable[index];
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Hand hand = new Hand();
            hand.Add(new Card(RANK.TWO, SUIT.SPADES));
            hand.Add(new Card(RANK.FOUR, SUIT.DIAMONDS));
            currentPlayer.CalculateHandValue(playerAmount);
            timer.Stop();
            pokerTable[index] = currentPlayer;
            rtbOutput.Text = currentPlayer.HandValue.ToString() + Environment.NewLine + timer.Elapsed.TotalMilliseconds;

            lbMain.Items.Clear();
            foreach (Player player in pokerTable)
            {
                lbMain.Items.Add(player.Name);
            }
            lbMain.SelectedIndex = index;
        }

        private void btnPotOdds_Click(object sender, EventArgs e)
        {
            int index = lbMain.SelectedIndex;
            AIPlayer currentPlayer = (AIPlayer)pokerTable[index];
            //currentPlayer.MediumThinkingTesting(pokerTable.getPot(), Convert.ToInt32(txtCall.Text), Convert.ToInt32(txtTotal.Text), pokerTable.getCurrentIndex(), handValue);
            rtbOutput.Text += Environment.NewLine
                + currentPlayer.PotOdds.ToString() + Environment.NewLine
                + currentPlayer.RateOfReturn.ToString() + Environment.NewLine
                + currentPlayer.SimplifiedMessage;
        }
        

        
    }
}
