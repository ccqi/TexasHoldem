using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace Holdem
{
    /// <summary>
    /// this class includes the chipStack of the individual players and actions they can make
    /// in poker, a very important class
    /// </summary>
    public class Player : INotifyPropertyChanged
    {
        protected Hand myHand = new Hand();
        protected string name;
        protected int chipStack;
        protected int amountInPot;
        protected bool folded;
        protected int amountContributed;
        protected int initialStack;
        protected string message;
        protected string simplifiedMessage;
        public bool isbusted;
        //various propeties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ChipStack
        {
            get { return chipStack; }
            set
            {
                if (value < 0)
                    value = 0;
                chipStack = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("ChipStack"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
        public int AmountContributed
        {
            get { return amountContributed; }
            set { amountContributed = value; }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
        public string SimplifiedMessage
        {
            get
            {
                return simplifiedMessage;
            }
            set
            {
                simplifiedMessage = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("SimplifiedMessage"));
            }
        }
        public int InitialStack
        {
            get { return initialStack; }
            set
            {
                if (value < 0)
                    value = 0;
                initialStack = value;
            }
        }
        public int AmountInPot
        {
            get { return amountInPot; }
            set
            {
                if (value < 0)
                    value = 0;
                amountInPot = value;
            }
        }
        public int getAmountToCall(Pot mainPot)
        {
            return mainPot.getMaximumAmountPutIn() - amountInPot;
        }
        //contruct player name and chipstack
        public Player()
        {
            this.name = "You";
            ChipStack = 10000;
            amountInPot = 0;
            initialStack = ChipStack;
            folded = false;
            message = "No decision has been made";
            simplifiedMessage = "";
            isbusted = false;
        }
        public Player(int buyInAmount)
        {
            ChipStack = buyInAmount;
            initialStack = ChipStack;
            amountInPot = 0;
            folded = false;
            message = "No decision has been made";
            simplifiedMessage = "";
            isbusted = false;
        }
        public Player(string name, int buyInAmount)
        {
            if (name == "")
                name = "You";
            this.name = name;
            ChipStack = buyInAmount;
            initialStack = ChipStack;
            amountInPot = 0;
            folded = false;
            message = "No decision has been made";
            simplifiedMessage = "";
            isbusted = false;
        }
        public Hand getHand()
        {
            return myHand;
        }
        //add hands to hand
        public void AddToHand(Hand hand)
        {
            myHand += hand;
        }
        public void AddToHand(Card card)
        {
            myHand.Add(card);
        }
        //pay the small and big blinds
        public void PaySmallBlind(int amount, Pot mainPot)
        {
            if (ChipStack <= amount)
            {
                AllIn(mainPot);
                return;
            }
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.AddPlayer(this);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.MinimumRaise = amount;
            Message = this.Name + " pays the small blind";
            SimplifiedMessage = "SMALL BLIND " + amount;
        }
        //some functions have index as they are needed to reset the agressor index to continue the round
        public void PaySmallBlind(int amount, Pot mainPot,int index)
        {
            if (ChipStack <= amount)
            {
                AllIn(mainPot,index);
                return;
            }
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.AddPlayer(this);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.MinimumRaise = amount;
            Message = this.Name + " pays the small blind";
            SimplifiedMessage = "SMALL BLIND " + amount;
        }
        public void PayBigBlind(int amount, Pot mainPot)
        {
            if (ChipStack <= amount)
            {
                AllIn(mainPot);
                return;
            }
            Message = "Pay blind of " + amount.ToString("c0");
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.AddPlayer(this);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.MinimumRaise = amount;
            Message = this.Name + " pays the big blind";
            SimplifiedMessage = "BIG BLIND " + amount;
        }
        public void PayBigBlind(int amount, Pot mainPot, int index)
        {
            if (ChipStack <= amount)
            {
                AllIn(mainPot,index);
                return;
            }
            Message = "Pay blind of " + amount.ToString("c0");
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.AddPlayer(this);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.MinimumRaise = amount;
            Message = this.Name + " pays the big blind";
            SimplifiedMessage = "BIG BLIND " + amount;
            mainPot.AgressorIndex = index;
        }
        //leave the round
        public void Fold(Pot mainPot)
        {

            folded = true;
            mainPot.getPlayersInPot().Remove(this);
            Message = "Fold";
            SimplifiedMessage = "FOLDED";

        }
        public bool IsFolded()
        {
            return folded;
        }
        //don't bet
        public void Check(Pot mainPot)
        {
            Message = "Check";
            SimplifiedMessage = "CHECK";
        }
        //bet enough to stay in the round
        public void Call(Pot mainPot)
        {
            
            int amount = mainPot.getMaximumAmountPutIn() - amountInPot;
            if (ChipStack <= amount)
            {
                AllIn(mainPot);
                return;
            }
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.AddPlayer(this);
            Message = "Call " + amount.ToString("c0");
            SimplifiedMessage = "CALL " + amount;
        }
        //call and bet additional amount of money
        public void Raise(int raise, Pot mainPot)
        {
            int amount = mainPot.getMaximumAmountPutIn() + raise - amountInPot;
            if (ChipStack <= amount)
            {
                AllIn(mainPot);
                return;
            }
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.AddPlayer(this);
            mainPot.MinimumRaise = raise;
            Message = "Call " + (amount - raise).ToString("c0") + " and raise " + raise.ToString("c0");
            SimplifiedMessage = "RAISE " + (amount - raise);
        }
        public void Raise(int raise, Pot mainPot, int index)
        {
            int amount = mainPot.getMaximumAmountPutIn() + raise - amountInPot;
            if (ChipStack <= amount)
            {
                AllIn(mainPot,index);
                return;
            }
            ChipStack -= amount;
            amountInPot += amount;
            mainPot.Add(amount);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.AddPlayer(this);
            mainPot.MinimumRaise = raise;
            Message = "Call " + (amount - raise).ToString("c0") + " and raise " + raise.ToString("c0");
            SimplifiedMessage = "RAISE " + (amount - raise);
            mainPot.AgressorIndex = index;
        }
        //bet a certain amount of money
        public void Bet(int bet, Pot mainPot)
        {
            if (ChipStack <= bet)
            {
                AllIn(mainPot);
                return;
            }
            ChipStack -= bet;
            amountInPot += bet;
            mainPot.Add(bet);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.MinimumRaise = bet;
            Message = "Bet " + bet.ToString("c0");
            SimplifiedMessage = "BET " + bet;
        }
        public void Bet(int bet, Pot mainPot, int index)
        {
            if (ChipStack <= bet)
            {
                AllIn(mainPot,index);
                return;
            }
            ChipStack -= bet;
            amountInPot += bet;
            mainPot.Add(bet);
            mainPot.setMaximumAmount(amountInPot);
            mainPot.MinimumRaise = bet;
            Message = "Bet " + bet.ToString("c0");
            SimplifiedMessage = "BET " + bet;
            mainPot.AgressorIndex = index;
        }
        //all in, bet remaining chipstack
        public void AllIn(Pot mainPot)
        {
            AmountContributed = ChipStack;
            if (mainPot.MinimumAllInAmount == 0)
            {
                mainPot.AmountInPotBeforeAllIn = mainPot.Amount;
                mainPot.MinimumAllInAmount = ChipStack;
            }
            else if (chipStack < mainPot.MinimumAllInAmount)
            {
                mainPot.MinimumAllInAmount = ChipStack;
            }
            if (ChipStack > mainPot.MinimumRaise)
                mainPot.MinimumRaise = ChipStack;
            mainPot.AddPlayer(this);
            mainPot.Add(ChipStack);
            amountInPot += ChipStack;
            ChipStack = 0;
            if (amountInPot > mainPot.getMaximumAmountPutIn())
                mainPot.setMaximumAmount(amountInPot);
            Message = "I'm All-In";
            SimplifiedMessage = "ALL IN";
        }
        public void AllIn(Pot mainPot,int index)
        {
            AmountContributed = ChipStack;
            if (mainPot.MinimumAllInAmount == 0)
            {
                mainPot.AmountInPotBeforeAllIn = mainPot.Amount;
                mainPot.MinimumAllInAmount = ChipStack;
            }
            else if (chipStack < mainPot.MinimumAllInAmount)
            {
                mainPot.MinimumAllInAmount = ChipStack;
            }
            if (ChipStack > mainPot.MinimumRaise)
                mainPot.MinimumRaise = ChipStack;
            mainPot.AddPlayer(this);
            mainPot.Add(ChipStack);
            amountInPot += ChipStack;
            ChipStack = 0;
            if(amountInPot>mainPot.getMaximumAmountPutIn())
                mainPot.setMaximumAmount(amountInPot);
            Message = "I'm All-In";
            SimplifiedMessage = "ALL IN";
            mainPot.AgressorIndex = index;
        }
        //reset the individual players
        public void Reset()
        {
            this.amountInPot = 0;
            this.folded = false;
            InitialStack = ChipStack;
            this.myHand.Clear();
            this.Message = "";
            this.SimplifiedMessage = "";
        }
        //collect the winnings if the player wins
        public void CollectMoney(Pot mainPot)
        {
            this.ChipStack += mainPot.Amount;
            this.Message = this.Name + " wins the pot!";
        }
        //set isBusted to true if the player busted out
        public void Leave()
        {
            if (this.ChipStack != 0)
                throw new InvalidOperationException();
            this.Message = this.Name + " busted out!";
            isbusted = true;
        }
        
    }
}
