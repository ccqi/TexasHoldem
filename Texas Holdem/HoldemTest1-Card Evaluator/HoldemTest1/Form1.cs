using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Holdem;
namespace HoldemTest1
{
    public partial class Form1 : Form
    {
        Hand myHand1 = new Hand();
        Hand myHand2 = new Hand();
        Hand handhighlights, handhighlights2;
        Deck deck = new Deck();
        Card myCard;
        int i = 0;
        int j = 0;
        Bitmap b1;
        Bitmap b2;
        public Form1()
        {
            InitializeComponent();
            b2=new Bitmap(pictureBox1.Width, pictureBox1.Height);
            b1 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Deck deck = new Deck(true);
                //deck.Shuffle();
                //Card dealCard = deck.Deal();
                //Bitmap bitmap = new Bitmap(dealCard.getImage());
                //pictureBox1.Image = bitmap;
                ////MessageBox.Show(dealCard.ToString());
                myCard = new Card((RANK)cbRank.SelectedItem, (SUIT)cbSuit.SelectedItem,true);
                if (myCard.getRank() == 1)
                    return;
                myHand1.Add(myCard);
                Bitmap bitmap = new Bitmap(myCard.getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5+i*75, 5, 71, 96);
                i++;
                pictureBox1.Image = b2;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void btnAddHand2_Click(object sender, EventArgs e)
        {
            try
            {
                myCard = new Card((RANK)cbRank.SelectedItem, (SUIT)cbSuit.SelectedItem, true);
                if (myCard.getRank() == 1)
                    return;
                myHand2.Add(myCard);
                Bitmap bitmap = new Bitmap(myCard.getImage());
                Graphics g = Graphics.FromImage(b1);
                g.DrawImage(bitmap, 5 + j * 75, 5, 71, 96);
                j++;
                pictureBox2.Image = b1;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbRank.DataSource = Enum.GetValues(typeof(RANK));
            this.cbSuit.DataSource = Enum.GetValues(typeof(SUIT));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            myHand1.sortByRank();
            int i = 0;
            for (int j = 0; j < myHand1.Count(); j++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(j).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + i * 75, 5, 71, 96);
                i++;
                pictureBox1.Image = b2;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                myHand1.Remove(myHand1.Count() - 1);
                i = 0;
                b2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(b2);
                g.Clear(pictureBox1.BackColor);
                pictureBox1.Image = b2;
                for (int j = 0; j < myHand1.Count(); j++)
                {
                    Card currentCard = myHand1.getCard(j);
                    currentCard.UnHighlight();
                    Bitmap bitmap = new Bitmap(currentCard.getImage());
                    Graphics g1 = Graphics.FromImage(b2);
                    g1.DrawImage(bitmap, 5 + i * 75, 5, 71, 96);
                    i++;
                }
                pictureBox1.Image = b2;
            }
            catch
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (HandCombination.isRoyalFlush(new Hand(myHand1)))
            {
                MessageBox.Show("This is Royal Flush.");
            }
            else
            {
                MessageBox.Show("Not Royal Flush.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (HandCombination.isStraightFlush(new Hand(myHand1)))
            {
                MessageBox.Show("This is Straight Flush.");
            }
            else
            {
                MessageBox.Show("Not Straight Flush.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (HandCombination.isFourOfAKind(new Hand(myHand1)))
            {
                MessageBox.Show("This is 4Kind.");
            }
            else
            {
                MessageBox.Show("Not 4Kind.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (HandCombination.isFullHouse(new Hand(myHand1)))
            {
                MessageBox.Show("This is Full House.");
            }
            else
            {
                MessageBox.Show("Not Full House.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (HandCombination.isFlush(new Hand(myHand1)))
            {
                MessageBox.Show("This is Flush.");
            }
            else
            {
                MessageBox.Show("Not Flush.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (HandCombination.isStraight(new Hand(myHand1)))
            {
                MessageBox.Show("This is Straight.");
            }
            else
            {
                MessageBox.Show("Not Straight.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (HandCombination.isThreeOfAKind(new Hand(myHand1)))
            {
                MessageBox.Show("This is 3Kind.");
            }
            else
            {
                MessageBox.Show("Not 3Kind.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (HandCombination.isTwoPair(new Hand(myHand1)))
            {
                MessageBox.Show("This is 2Pair.");
            }
            else
            {
                MessageBox.Show("Not 2Pair.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (HandCombination.isOnePair(new Hand(myHand1)))
            {
                MessageBox.Show("This is 1Pair.");
            }
            else
            {
                MessageBox.Show("Not 1Pair.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (HandCombination.isHighCard(new Hand(myHand1)))
            {
                MessageBox.Show("This is High Card.");
            }
            else
            {
                MessageBox.Show("Not High Card.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getRoyalFlush(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
                pictureBox1.Image = b2;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getStraightFlush(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getFourOfAKind(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getFullHouse(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getFlush(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getStraight(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getThreeOfAKind(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getTwoPair(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
            //MainList.Items.Add(handhighlights.ToString());
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getOnePair(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Hand handhighlights = new Hand();
            handhighlights = HandCombination.getHighCard(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            myHand1.Clear();
            deck = new Deck();
            deck.Shuffle();
            for (int i = 0; i < 7; i++)
            {
                myHand1.Add(deck.Deal());
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
        }

        private void btnEvalute_Click(object sender, EventArgs e)
        {
            handhighlights = new Hand();
            handhighlights = HandCombination.getBestHand(new Hand(myHand1));
            for (int i = 0; i < myHand1.Count(); i++)
            {
                for (int j = 0; j < handhighlights.Count(); j++)
                {
                    if (handhighlights.getCard(j) == myHand1.getCard(i) && handhighlights.getCard(j).getSuit() == myHand1.getCard(i).getSuit())
                    {
                        myHand1.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand1.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand1.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b2);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox1.Image = b2;
            MainList.Items.Add(handhighlights.ToString());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            myHand2.Clear();
            deck = new Deck();
            deck.Shuffle();
            for (int i = 0; i < 7; i++)
            {
                myHand2.Add(deck.Deal());
            }
            int x = 0;
            for (int i = 0; i < myHand2.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand2.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b1);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox2.Image = b1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                myHand2.Remove(myHand2.Count() - 1);
                j = 0;
                b1 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics g = Graphics.FromImage(b1);
                g.Clear(pictureBox2.BackColor);
                pictureBox2.Image = b1;
                for (int i = 0; i < myHand2.Count(); i++)
                {
                    Card currentCard = myHand2.getCard(j);
                    currentCard.UnHighlight();
                    Bitmap bitmap = new Bitmap(currentCard.getImage());
                    Graphics g1 = Graphics.FromImage(b1);
                    g1.DrawImage(bitmap, 5 + j * 75, 5, 71, 96);
                    j++;
                }
                pictureBox2.Image = b1;
            }
            catch
            {
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            handhighlights2 = new Hand();
            handhighlights2 = HandCombination.getBestHand(new Hand(myHand2));
            for (int i = 0; i < myHand2.Count(); i++)
            {
                for (int j = 0; j < handhighlights2.Count(); j++)
                {
                    if (handhighlights2.getCard(j) == myHand2.getCard(i) && handhighlights2.getCard(j).getSuit() == myHand2.getCard(i).getSuit())
                    {
                        myHand2.getCard(i).Highlight();
                    }
                }
            }
            int x = 0;
            for (int i = 0; i < myHand2.Count(); i++)
            {
                Bitmap bitmap = new Bitmap(myHand2.getCard(i).getImage());
                Graphics g = Graphics.FromImage(b1);
                g.DrawImage(bitmap, 5 + x * 75, 5, 71, 96);
                x++;
            }
            pictureBox2.Image = b1;
            MainList.Items.Add(handhighlights2.ToString());
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (handhighlights > handhighlights2)
            {
                MainList.Items.Add("1 is greater");
            }
            else if (handhighlights < handhighlights2)
            {
                MainList.Items.Add("1 is less");
            }
            else if(handhighlights==handhighlights2)
            {
                MainList.Items.Add("equal");
            }
        }
    }
}
