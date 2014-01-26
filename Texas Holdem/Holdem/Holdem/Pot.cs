using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holdem
{
    /// <summary>
    /// This class controls amount currently in pot,
    /// minimum bet of players, when the betting round ends,
    /// players contesting the pot and when the betting round is over,
    /// and who wins the pot, mostly composed of variables and propeties, not 
    /// many methods
    /// </summary>
    public class Pot
    {
        //many of the variables are not needed, however attempts to remove them
        //have cause problem and may screw up the program, therefore these
        //variables are not removed
        private PlayerList playersInPot = new PlayerList();
        private int amountInPot;
        private int minimumRaise;
        private int maximumAmountPutIn;
        //not needed-----------------
        private int minimumAllInAmount;
        private int playersAllInCount;
        private int amountInPotBeforeAllIn;
        //----------------------------------
        private int agressorIndex;
        private int smallBlind, bigBlind;
        public int SmallBlind
        {
            get { return smallBlind; }
            set { smallBlind = value; }
        }
        public int BigBlind
        {
            get { return bigBlind; }
            set { bigBlind = value; }
        }
        //various propeties
        public int MinimumRaise
        {
            get { return minimumRaise; }
            set
            {
                minimumRaise = value;
            }
        }
        public int Amount
        {
            get { return amountInPot; }
            set
            {
                if (value < 0)
                    value = 0;
                amountInPot = value;
            }
        }
        public int MinimumAllInAmount
        {
            get { return minimumAllInAmount; }
            set
            {
                if (value < 0)
                    value = 0;
                minimumAllInAmount = value;
            }
        }
        public int PlayersAllIn
        {
            get { return playersAllInCount; }
            set
            {
                if (value < 0)
                    value = 0;
                playersAllInCount = value;
            }
        }
        public int AmountInPotBeforeAllIn
        {
            get { return amountInPotBeforeAllIn; }
            set
            {
                if (value < 0)
                    value = 0;
                amountInPotBeforeAllIn = value;
            }
        }
        public int AgressorIndex
        {
            get { return agressorIndex; }
            set { agressorIndex = value; }
        }
        //construct pot
        public Pot()
        {
            amountInPot = 0;
            minimumRaise = 0;
            maximumAmountPutIn = 0;
            minimumAllInAmount = 0;
            playersAllInCount = 0;
            amountInPotBeforeAllIn = 0;
            agressorIndex = -1;
        }
        public Pot(int amount, PlayerList playersInPot)
        {
            this.Amount = amount;
            this.playersInPot = playersInPot;
            minimumAllInAmount = 0;
            playersAllInCount = 0;
            amountInPotBeforeAllIn = 0;
            agressorIndex = -1;
        }
        //getter
        public PlayerList getPlayersInPot()
        {
            return playersInPot;
        }
        //add player to pot
        public void AddPlayer(Player player)
        {
            if(!playersInPot.Contains(player))
                playersInPot.Add(player);
        }
        //add money to pot
        public void Add(int amount)
        {
            if (amount < 0)
                return;
            amountInPot += amount;
        }
        //get maximum amount in pot
        public int getMaximumAmountPutIn()
        {
            return maximumAmountPutIn;
        }
        //set maximum amount in pot
        public void setMaximumAmount(int amount)
        {
            maximumAmountPutIn = amount;
        }
        
    }
}
