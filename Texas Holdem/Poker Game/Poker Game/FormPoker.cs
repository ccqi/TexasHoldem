using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;
using Holdem;
namespace Poker_Game
{
    public partial class FormPoker : Form
    {
        UserAccount user;
        string playerName;
        int BuyInAmount, playerAmount, difficulty;
        Table pokerTable;
        PlayerList playerList;
        Bitmap bitmap;
        Graphics g;
        List<Label> labelListMoney;
        List<Label> labelListName;
        List<Label> labelListAction;
        List<Panel> panelList;
        List<Rectangle> holeCardPosition = new List<Rectangle>();
        List<Rectangle> flopPositions = new List<Rectangle>(3);
        Rectangle turnPosition, riverPosition;
        FormGetMoney getMoney = new FormGetMoney();
        //counters
        int timerCount = 0;
        int showdownCount = 0;
        int bustedIndex = 0;
        //scaling factors
        float width_ratio, height_ratio;
        int cardWidth, cardHeight;
        int screenWidth, screenHeight;
        //flag for playing music
        public static bool musicFlag=true;
        //the all important constructors
        public FormPoker()
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
            timerCount = 0;
            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;
            width_ratio = (screenWidth / this.Width);
            height_ratio = (screenHeight / this.Height);
            
            SizeF scale = new SizeF(width_ratio, height_ratio);
            pbMain.Scale(scale);
            this.Size = pbMain.Size;
            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
            }
            cardWidth = Convert.ToInt32(71f * width_ratio);
            cardHeight = Convert.ToInt32(96f * height_ratio);
            user = new UserAccount();
            Random rand = new Random();
            Player me = new Player(playerName, BuyInAmount);
            playerList = new PlayerList();
            playerList.Add(me);
            lblName.Text = me.Name;
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
                playerList.Add(new AIPlayer(BuyInAmount, difficulty, AI[i - 1]));
                //labelListName[i].Text = playerList[i].Name;
            }
            FormInformation Information = new FormInformation(playerList);
            Information.StartPosition = FormStartPosition.CenterScreen;
            Information.ShowDialog();
            Information.Dispose();
            pokerTable = new Table(playerList);
            SoundPlayer sound = new SoundPlayer();
        }
        public FormPoker(string playerName, int BuyInAmount, int playerAmount, int difficulty, UserAccount user)
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
            this.playerName = playerName;
            if (playerName == null)
                throw new ArgumentOutOfRangeException();
            if (playerAmount < 2)
                throw new ArgumentOutOfRangeException();
            this.difficulty = difficulty;
            if (difficulty > 2)
                throw new ArgumentOutOfRangeException();
            this.BuyInAmount = BuyInAmount;
            this.playerAmount = playerAmount;
            timerCount = 0;
            //code to resize screen
            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;
            width_ratio = (screenWidth / 1366f);
            height_ratio = (screenHeight / 768f);
            SizeF scale = new SizeF(width_ratio, height_ratio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
            }

            cardWidth = Convert.ToInt32(71f * width_ratio);
            cardHeight = Convert.ToInt32(96f * height_ratio);
            this.user = new UserAccount(user);
            //add 3 archetytes randomly to list
            Random rand = new Random();
            Player me = new Player(playerName, BuyInAmount);
            playerList = new PlayerList();
            playerList.Add(me);
            lblName.Text = me.Name;
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
                playerList.Add(new AIPlayer(BuyInAmount, difficulty, AI[i - 1]));
                //labelListName[i].Text = playerList[i].Name;
            }
            FormInformation Information = new FormInformation(playerList);
            Information.StartPosition = FormStartPosition.CenterScreen;
            Information.ShowDialog();
            Information.Dispose();
            pokerTable = new Table(playerList);
        }
        //setting up game interface
        private void initalize()
        {
            //make pbMain the parent of many controls to support transparency
            panelPlayer.Parent = pbMain;
            panel2.Parent = pbMain;
            panel3.Parent = pbMain;
            panel4.Parent = pbMain;
            pbDealer.Parent = pbMain;
            btnCheck.Parent = pbMain;
            btnAllIn.Parent = pbMain;
            btnFold.Parent = pbMain;
            btnRaise.Parent = pbMain;
            lblBanner.Parent = pbMain;
            btnMusic.Parent = pbMain;
            bitmap = new Bitmap(pbMain.Width, pbMain.Height);
            panelBubble.Parent = pbMain;
            lblPot.Parent = pbMain;
            panelBubble.BringToFront();
            g = Graphics.FromImage(bitmap);
            if (playerAmount == 2)
                panel2.Location = panel3.Location;
            if (playerAmount == 3)
                panel3.Show();
            else if (playerAmount == 4)
            {
                panel3.Show();
                panel4.Show();
            }

            labelListMoney = new List<Label>();
            labelListName = new List<Label>();
            labelListAction = new List<Label>();
            panelList = new List<Panel>();
            labelListMoney.Add(lblMoney); labelListMoney.Add(lblM2); labelListMoney.Add(lblM3); labelListMoney.Add(lblM4);
            labelListName.Add(lblName); labelListName.Add(lblP2); labelListName.Add(lblP3); labelListName.Add(lblP4);
            labelListAction.Add(lblAction); labelListAction.Add(lblA2); labelListAction.Add(lblA3); labelListAction.Add(lblA4);
            panelList.Add(panelPlayer); panelList.Add(panel2); panelList.Add(panel3); panelList.Add(panel4);
            //resize font
            foreach (Panel panel in panelList)
            {
                foreach (Control control in panel.Controls)
                {
                    control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
                }
            }
            foreach (Control control in panelBubble.Controls)
            {
                control.Font = new Font(control.Font.Name, control.Font.SizeInPoints * height_ratio * width_ratio, control.Font.Style);
            }
            for (int i = 1; i < playerAmount; i++)
            {
                labelListName[i].Text = playerList[i].Name;
            }
            //bind ChipStack to labelListMoney
            Binding b;
            for (int i = 0; i < playerAmount; i++)
            {
                b = new Binding("Text", pokerTable[i], "ChipStack", true);
                b.FormatString = "c0";
                labelListMoney[i].DataBindings.Add(b);
                b = new Binding("Text", pokerTable[i], "SimplifiedMessage");
                b.FormatString = "c0";
                labelListAction[i].DataBindings.Add(b);
            }
            HideButtons();
            if (musicFlag)
                btnMusic.BackgroundImage = Image.FromFile("Sound.png");
            else
                btnMusic.BackgroundImage = Image.FromFile("NoSound.png");

        }
        //shuffle the 3 different AI playing styles
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
        //positions of hole/community cards
        private void setDrawingPositions()
        {
            int holeHeight = Convert.ToInt32((60f / 768f) * screenHeight);
            for (int i = 0; i < pokerTable.getPlayers().Count; i++)
            {
                holeCardPosition.Add(new Rectangle(panelList[i].Location.X + Convert.ToInt32((18f / 1366f) * screenWidth), panelList[i].Location.Y - holeHeight, cardWidth, cardHeight));
                holeCardPosition.Add(new Rectangle(panelList[i].Location.X + Convert.ToInt32((87f / 1366f) * screenWidth), panelList[i].Location.Y - holeHeight, cardWidth, cardHeight));
            }
            int communityHeight = Convert.ToInt32((322f*height_ratio));
            flopPositions.Add(new Rectangle(Convert.ToInt32(480f *width_ratio), communityHeight, cardWidth, cardHeight));
            flopPositions.Add(new Rectangle(Convert.ToInt32(569f *width_ratio), communityHeight, cardWidth, cardHeight));
            flopPositions.Add(new Rectangle(Convert.ToInt32(658f *width_ratio), communityHeight, cardWidth, cardHeight));
            turnPosition = new Rectangle(Convert.ToInt32(749f *width_ratio), communityHeight, cardWidth, cardHeight);
            riverPosition = new Rectangle(Convert.ToInt32(837f *width_ratio), communityHeight, cardWidth, cardHeight);

        }
        //drawing function that draws all playing cards to screen
        private void DrawToScreen()
        {
            g.Clear(Color.Transparent);
                for (int i = 0; i < pokerTable.getPlayers().Count * 2; i++)
                {
                    if (pokerTable[i / 2].isbusted)
                        continue;
                    g.DrawImage(pokerTable[i / 2].getHand()[i % 2].getImage(), holeCardPosition[i]);
                }
            pbDealer.Location = new Point(panelList[pokerTable.getDealerPosition()].Location.X - Convert.ToInt32(60*width_ratio), panelList[pokerTable.getDealerPosition()].Location.Y - Convert.ToInt32(15*height_ratio));

            if (pokerTable[0].getHand().Count() > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    g.DrawImage(pokerTable.getCommunityCards()[i].getImage(), flopPositions[i]);
                }

                if (pokerTable[0].getHand().Count() > 5)
                {
                    g.DrawImage(pokerTable.getCommunityCards()[3].getImage(), turnPosition);
                    if (pokerTable[0].getHand().Count() > 6)
                        g.DrawImage(pokerTable.getCommunityCards()[4].getImage(), riverPosition);
                }

            }
            pbMain.Image = bitmap;
        }
        //copied code to reduce flickr in code
        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
        //initialize components and start match when the form loads
        private void FormPoker_Load(object sender, EventArgs e)
        {
            initalize();
            setDrawingPositions();
            matchStart();
        }
        

        public void matchStart()
        {
            if (PlayerWon() != 0)
            {
                TimerWait3Seconds.Stop();
                lblBanner.Hide();
                //Checks if the player has won at start of new round
                if (PlayerWon() == 1)
                {
                    if (user.getUserName() != "default" && user.getPassword() != "default")
                    {
                        user.AddWin();
                        user.WriteToFile();
                    }
                    panelBubble.Hide();
                    FormEndGame FormEndGame = new FormEndGame(true);
                    FormEndGame.StartPosition = FormStartPosition.CenterScreen;
                    FormEndGame.FormPoker = this;
                    FormEndGame.Text = "You won!";
                    FormEndGame.ShowDialog();
                }
                else if (PlayerWon() == -1)
                {
                    if (user.getUserName() != "default" && user.getPassword() != "default")
                    {
                        user.AddLose();
                        user.WriteToFile();
                    }
                    panelBubble.Hide();
                    FormEndGame FormEndGame = new FormEndGame(false);
                    FormEndGame.StartPosition = FormStartPosition.CenterScreen;
                    FormEndGame.FormPoker = this;
                    FormEndGame.Text = "You lost!";
                    FormEndGame.ShowDialog();
                }
                return;
            }
            HideControls();
            for (int i = 0; i < pokerTable.getPlayers().Count; i++)
            {
                if (pokerTable[i].IsFolded())
                {
                    panelList[i].BackgroundImage = Image.FromFile("panelNormal.png");
                }
            }
            //resetting variables to start new match
            timerCount = 0;
            showdownCount = 0;
            lblBanner.Show();
            if (pokerTable.RoundCount == 10)
                lblBanner.Text = "The minimum blinds have" + Environment.NewLine + "been raised";
            else
                lblBanner.Text = "New Round";
            pokerTable.startNextMatch();
            pokerTable.DealHoleCards();
            DrawToScreen();
            updateMove();
            lblBubble.Text = pokerTable[pokerTable.getCurrentIndex()].Name + " is the dealer";
            TimerNextMove.Start();
        }
        //check if a player busted out
        private bool PlayerBustedOut()
        {
            foreach (Player player in pokerTable)
            {
                if (player.isbusted)
                    continue;
                if (player.ChipStack == 0)
                {
                    return true;
                }
            }
            return false;
        }
        //display who busted out 
        private void timerBusted_Tick(object sender, EventArgs e) //displays the players that have busted out
        {
            lblBanner.Hide();
            if (bustedIndex >= pokerTable.getPlayers().Count)
            {
                timerBusted.Stop();
                pokerTable.setCurrentIndex(pokerTable.getDealerPosition());
                bustedIndex = 0;
                matchStart();
                return;
            }
            //increment busted index
            while (pokerTable[bustedIndex].ChipStack != 0 || pokerTable[bustedIndex].isbusted)
            {
                bustedIndex++;
                if (bustedIndex >= pokerTable.getPlayers().Count)
                {
                    timerBusted.Stop();
                    pokerTable.setCurrentIndex(pokerTable.getDealerPosition());
                    bustedIndex = 0;
                    matchStart();
                    return;
                }
            }
            pokerTable.setCurrentIndex(bustedIndex);
            pokerTable[bustedIndex].Leave();
            updateMove();
            bustedIndex++;

        }
        //hide various controls if the player busted out
        private void HideControls()
        {
            for (int i = 0; i < pokerTable.getPlayers().Count; i++)
            {
                if (pokerTable[i].isbusted)
                {
                    if (i == 0)
                        continue;
                    else
                        panelList[i].Hide();
                }
            }
        }
        //check if you won, tie or lost
        private int PlayerWon()
        {
            if (!pokerTable[0].isbusted)
            {
                for (int i = 1; i < pokerTable.getPlayers().Count; i++)
                {
                    if (!pokerTable[i].isbusted)
                        return 0;
                }
                return 1;
            }
            return -1;
        }        
        //move the speech bubble and draw current move to screen
        private void updateMove()
        {
            //changes panelbubble position and text
            panelBubble.Show();
            panelBubble.Location = new Point(panelList[pokerTable.getCurrentIndex()].Location.X + Convert.ToInt32(176 * width_ratio), panelList[pokerTable.getCurrentIndex()].Location.Y - Convert.ToInt32(80 * width_ratio));
            lblBubble.Text = pokerTable[pokerTable.getCurrentIndex()].Message;
            lblPot.Text = "No-Limit Texas Holdem"
                + Environment.NewLine + "Difficulty: " + (DIFFICULTY)difficulty
                + Environment.NewLine + "Blinds: $" + pokerTable.SmallBlind.ToString() + "/" + pokerTable.BigBlind.ToString()
                + Environment.NewLine + "Amount in pot: " + pokerTable.getPot().Amount.ToString("c0");
        }

        //change button backImage when house enters/leave the buttons
        private void btnAllIn_MouseEnter(object sender, EventArgs e)
        {
            btnAllIn.BackgroundImage = Image.FromFile("hover.png");
        }
        private void btnAllIn_MouseLeave(object sender, EventArgs e)
        {
            btnAllIn.BackgroundImage = Image.FromFile("normal.png");
        }
        private void btnFold_MouseEnter(object sender, EventArgs e)
        {
            btnFold.BackgroundImage = Image.FromFile("hover.png");
        }
        private void btnFold_MouseLeave(object sender, EventArgs e)
        {
            btnFold.BackgroundImage = Image.FromFile("normal.png");
        }
        private void btnCheck_MouseEnter(object sender, EventArgs e)
        {
            btnCheck.BackgroundImage = Image.FromFile("hover.png");
        }
        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.BackgroundImage = Image.FromFile("normal.png");
        }
        private void btnRaise_MouseEnter(object sender, EventArgs e)
        {
            btnRaise.BackgroundImage = Image.FromFile("hover.png");
        }
        private void btnRaise_MouseLeave(object sender, EventArgs e)
        {
            btnRaise.BackgroundImage = Image.FromFile("normal.png");
        }

        //fold button
        private void btnFold_Click(object sender, EventArgs e)
        {
            pokerTable[0].Fold(pokerTable.getPot());
            updateMove();
            HideButtons();
            panelPlayer.BackgroundImage = Image.FromFile("inactivebutton.png");
            TimerNextMove.Start();
        }
        //check/call button
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (pokerTable[pokerTable.getCurrentIndex()].getAmountToCall(pokerTable.getPot()) != 0)
                pokerTable[0].Call(pokerTable.getPot());
            else
                pokerTable[0].Check(pokerTable.getPot());
            updateMove();
            HideButtons();
            TimerNextMove.Start();
        }
        //bet/raise button
        private void btnRaise_Click(object sender, EventArgs e)
        {
            if (pokerTable[pokerTable.getCurrentIndex()].getAmountToCall(pokerTable.getPot()) == 0)
            {
                getMoney.Text = "Bet";
                getMoney.lblRaiseAmount.Text = "Bet Amount: ";
            }
            else
            {
                getMoney.Text = "Raise";
                getMoney.lblRaiseAmount.Text = "Raise Amount: ";
            }
            getMoney.setMoney(pokerTable.getPot().MinimumRaise, (pokerTable[0].ChipStack - pokerTable[0].getAmountToCall(pokerTable.getPot())));
            if (getMoney.ShowDialog() != DialogResult.OK)
                return;
            if (pokerTable[pokerTable.getCurrentIndex()].getAmountToCall(pokerTable.getPot()) != 0)
            {
                pokerTable[0].Raise(Convert.ToInt32(getMoney.nudBetRaise.Value), pokerTable.getPot(), pokerTable.decrementIndex(pokerTable.getCurrentIndex()));

            }
            else
                pokerTable[0].Bet(Convert.ToInt32(getMoney.nudBetRaise.Value), pokerTable.getPot(), pokerTable.decrementIndex(pokerTable.getCurrentIndex()));
            updateMove();
            HideButtons();
            TimerNextMove.Start();
        }
        //allin button
        private void btnAllIn_Click(object sender, EventArgs e)
        {
            pokerTable[0].AllIn(pokerTable.getPot(), pokerTable.decrementIndex(pokerTable.getCurrentIndex()));
            updateMove();
            HideButtons();
            TimerNextMove.Start();
        }
        //hide the buttons
        public void HideButtons()
        {
            btnRaise.Hide();
            btnCheck.Hide();
            btnFold.Hide();
            btnAllIn.Hide();
        }
        //most important method in the game, controls the turns of the players
        private void TimerNextMove_Tick(object sender, EventArgs e)
        {
            timerCount++;
            //condition if everyone folds
            if (pokerTable.PlayerWon())
            {
                panelBubble.Hide();
                pokerTable.setCurrentIndex(pokerTable.incrementIndexShowdown(pokerTable.getCurrentIndex()));
                pokerTable[pokerTable.getCurrentIndex()].CollectMoney(pokerTable.getPot());
                lblBanner.Text = pokerTable[pokerTable.getCurrentIndex()].Message;
                lblBanner.Show();
                TimerNextMove.Stop();
                TimerWait3Seconds.Start();
                return;
            }
            //condition to increment player's turn
            if (pokerTable.beginNextTurn())
            {
                pokerTable.setCurrentIndex(pokerTable.incrementIndex(pokerTable.getCurrentIndex()));
                lblBanner.Hide();
                //condition to pay small/big blind
                if (timerCount == 1)
                    pokerTable.PaySmallBlind();
                else if (timerCount == 2)
                    pokerTable.PayBigBlind();
                //condition that the current player is not AI, show labels to player
                else if (pokerTable.getCurrentIndex() == 0)
                {
                    initalizeButtons();
                    TimerNextMove.Stop();
                    return;
                }
                //condition for AI
                else
                {
                    AIPlayer currentPlayer = (AIPlayer)pokerTable[pokerTable.getCurrentIndex()];
                    if (difficulty == (int)DIFFICULTY.HARD)
                    {
                        Hand holeCards=new Hand();
                        holeCards.Add(pokerTable[0].getHand()[0]);
                        holeCards.Add(pokerTable[0].getHand()[1]);
                        currentPlayer.CalculateHandValueHard(holeCards, new Deck(pokerTable.getDeck()));
                    }
                    currentPlayer.MakeADecision(pokerTable.getPot(), pokerTable.decrementIndex(pokerTable.getCurrentIndex()));
                    pokerTable[pokerTable.getCurrentIndex()] = currentPlayer;
                    //grey out form if the AI folds
                    if (currentPlayer.IsFolded())
                        panelList[pokerTable.getCurrentIndex()].BackgroundImage = Image.FromFile("inactivebutton.png");
                }
                updateMove();
                if (timerCount > 2 && pokerTable.getCurrentIndex() != 0 && difficulty == 1)
                {
                    timerCalculate.Start();
                }
            }
            else
            {
                //deal community cards
                pokerTable.TurnCount = 0;
                lblBanner.Show();
                panelBubble.Hide();
                if (pokerTable[0].getHand().Count() == 2)
                {
                    pokerTable.DealFlop();
                    lblBanner.Text = "Dealing the Flop";
                    toolTipHint.SetToolTip(panelPlayer, HandCombination.getBestHand(new Hand(pokerTable[0].getHand())).ToString());
                }
                else if (pokerTable[0].getHand().Count() == 5)
                {
                    pokerTable.DealTurn();
                    lblBanner.Text = "Dealing the Turn";
                    toolTipHint.SetToolTip(panelPlayer, HandCombination.getBestHand(new Hand(pokerTable[0].getHand())).ToString());
                }
                else if (pokerTable[0].getHand().Count() == 6)
                {
                    pokerTable.DealRiver();
                    lblBanner.Text = "Dealing the River";
                    toolTipHint.SetToolTip(panelPlayer, HandCombination.getBestHand(new Hand(pokerTable[0].getHand())).ToString());
                }
                else if (pokerTable[0].getHand().Count() == 7)
                {
                    //start timer for showdown
                    lblBanner.Text = "Showdown";
                    TimerNextMove.Stop();
                    TimerShowdown.Start();
                    return;
                }
                //reset agressor the dealer
                int dealerPosition = pokerTable.getDealerPosition();
                pokerTable.setCurrentIndex(pokerTable.getDealerPosition());
                pokerTable.getPot().AgressorIndex = pokerTable.getDealerPosition();
                DrawToScreen();
            }


        }
        //calculate hand value for AI, if necessary, which takes a long time
        private void timerCalculate_Tick(object sender, EventArgs e)
        {
            AIPlayer nextPlayer = (AIPlayer)(pokerTable[pokerTable.getCurrentIndex()]);
            int playersCompeting = 0;
            for (int i = 0; i < pokerTable.getPlayers().Count; i++)
            {
                if (pokerTable[i].isbusted || pokerTable[i].IsFolded())
                    continue;
                playersCompeting++;
            }
            nextPlayer.CalculateHandValue(playersCompeting);

            timerCalculate.Stop();
        }
        //decides what buttons options are available to the user
        private void initalizeButtons()
        {
            btnAllIn.Show();
            btnFold.Show();
            if (pokerTable.getPlayers()[0].getAmountToCall(pokerTable.getPot()) <= pokerTable.getPlayers()[0].ChipStack)
            {
                btnCheck.Show();
                
            }
            if (pokerTable.getPot().MinimumRaise <= pokerTable.getPlayers()[0].ChipStack)
            {
                btnRaise.Show();
            }
            panelBubble.Hide();
            int amountToCall;
            if ((amountToCall = pokerTable[pokerTable.getCurrentIndex()].getAmountToCall(pokerTable.getPot())) != 0)
            {
                btnCheck.Text = "Call " + amountToCall.ToString("c0");
                btnRaise.Text = "Raise";
            }
            else
            {
                btnCheck.Text = "Check";
                btnRaise.Text = "Bet";
            }
        }
        //timer to start next round
        private void TimerWait3Seconds_Tick(object sender, EventArgs e)
        {

            if (PlayerBustedOut())
            {
                TimerWait3Seconds.Stop();
                timerBusted.Start();
                return;
            }
            matchStart();
            TimerWait3Seconds.Stop();
        }
        //timer to take care of showdown situations
        private void TimerShowdown_Tick(object sender, EventArgs e)
        {
            showdownCount++;
            if (showdownCount > pokerTable.getPot().getPlayersInPot().Count)
            {
                //unhighlights hands and evaluates hands to determine winner(s)
                for (int i = 0; i < pokerTable[pokerTable.getCurrentIndex()].getHand().Count(); i++)
                    pokerTable[pokerTable.getCurrentIndex()].getHand()[i].UnHighlight();
                DrawToScreen();
                pokerTable.ShowDown();
                lblBanner.Text = pokerTable.winnermessage;
                TimerShowdown.Stop();
                TimerWait3Seconds.Start();
            }
            else
            {
                //displays hands to the user
                for (int i = 0; i < pokerTable[pokerTable.getCurrentIndex()].getHand().Count(); i++)
                    pokerTable[pokerTable.getCurrentIndex()].getHand()[i].UnHighlight();
                int currentIndex = pokerTable.incrementIndexShowdown(pokerTable.getCurrentIndex());
                pokerTable.setCurrentIndex(currentIndex);
                pokerTable[currentIndex].getHand()[0].FaceUp = true;
                pokerTable[currentIndex].getHand()[1].FaceUp = true;
                Hand bestHand = HandCombination.getBestHand(new Hand(pokerTable[currentIndex].getHand()));
                for (int i = 0; i < pokerTable[currentIndex].getHand().Count(); i++)
                {
                    for (int j = 0; j < bestHand.Count(); j++)
                    {
                        if (bestHand.getCard(j) == pokerTable[currentIndex].getHand().getCard(i) && bestHand.getCard(j).getSuit() == pokerTable[currentIndex].getHand().getCard(i).getSuit())
                        {
                            pokerTable[currentIndex].getHand().getCard(i).Highlight();
                        }
                    }
                }
                lblBanner.Text = pokerTable[currentIndex].Name + " has: " + Environment.NewLine +
                    bestHand.ToString();
                DrawToScreen();
            }
        }
        //user drawn event handler for toolTip
        private void toolTipHint_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        //play/stop music accordingly
        private void btnMusic_Click(object sender, EventArgs e)
        {
            SoundPlayer sound=new SoundPlayer();
            if (musicFlag)
                musicFlag = false;
            else
                musicFlag = true;
            if (musicFlag)
            {
                btnMusic.BackgroundImage = Image.FromFile("Sound.png");
                    
                sound = new SoundPlayer("BackgroundMusic.wav");
                sound.PlayLooping();
            }
            else
            {
                btnMusic.BackgroundImage = Image.FromFile("NoSound.png");
                sound.Stop();
                sound.Dispose();
            }
        }
        //close the program
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
