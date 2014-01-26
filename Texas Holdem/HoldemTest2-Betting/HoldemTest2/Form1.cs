using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Holdem;
namespace HoldemTest2
{
    public partial class Form1 : Form
    {
        int numberOFPlayers;
        Table pokerTable = new Table();
        public Form1()
        {
            InitializeComponent();
        }
        private void Print()
        {
            listBoxPlayers.Items.Clear();
            rtbPot.Clear();
            foreach (Player p in pokerTable.getPlayers())
            {
                String print;
                print = p.Name + ", " + p.ChipStack+" ";
                for (int i=0;i<p.getHand().Count();i++)
                {
                    print += p.getHand()[i].ToString();
                }
                listBoxPlayers.Items.Add(print);
            }
            listBoxPlayers.SelectedIndex = pokerTable.getCurrentIndex();
            //listBoxPlayers.SelectedIndex = pokerTable.getDealerPosition();
            String display="Amount in pot: " + Environment.NewLine +
                pokerTable.getPot().Amount.ToString() + Environment.NewLine;
            for(int i=0;i<pokerTable.getSidePots().Count;i++)
            {
                display += "Side Pot " + (i + 1) + ": " +Environment.NewLine+ pokerTable.getSidePots()[i].Amount.ToString();
                foreach (Player player in pokerTable.getSidePots()[i].getPlayersInPot())
                {
                    display += player.Name + " ";
                }
                display += Environment.NewLine;
            }
            rtbPot.Text = display;
            
        }
        private void button10_Click(object sender, EventArgs e)
        {

            pokerTable.getPlayers().Clear();
            numberOFPlayers = Convert.ToInt32(nudAmount.Value);
            PlayerList players = new PlayerList();
            Random rand = new Random();
            for (int i = 0; i < numberOFPlayers; i++)
            {
                players.Add(new Player("Player " + (i + 1), 10000));
            }
            players[0].ChipStack = 10000;
            players[1].ChipStack = 9000;
            players[2].ChipStack = 9500;
            players[3].ChipStack = 9500;
            pokerTable = new Table(players);
            Print();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pokerTable.PayBlinds();
            nudBetRaise.Minimum = pokerTable.getPot().MinimumRaise;
            Print();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pokerTable.startNextRound();
            Print();
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            pokerTable.beginNextTurn();
            Print();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pokerTable.DealHoleCards();
            Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pokerTable[pokerTable.getCurrentIndex()].Call(pokerTable.getPot());
            Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pokerTable[pokerTable.getCurrentIndex()].Bet(Convert.ToInt32(nudBetRaise.Value), pokerTable.getPot());
            nudBetRaise.Minimum = pokerTable.getPot().MinimumRaise;
            Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pokerTable[pokerTable.getCurrentIndex()].Raise(Convert.ToInt32(nudBetRaise.Value), pokerTable.getPot());
            nudBetRaise.Minimum = pokerTable.getPot().MinimumRaise;
            Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pokerTable[pokerTable.getCurrentIndex()].AllIn(pokerTable.getPot());
            Print();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pokerTable[pokerTable.getCurrentIndex()].Fold(pokerTable.getPot());
            Print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pokerTable.DealFlop();
            Print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pokerTable.DealTurn();
            Print();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pokerTable.DealRiver();
            Print();
        }

        private void btnShowdown_Click(object sender, EventArgs e)
        {
            pokerTable.ShowDown();
            Print();
        }
        
    }
}
