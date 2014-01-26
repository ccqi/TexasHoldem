using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holdem
{
    /// <summary>
    /// a class for a list of cards that forms a player's hand
    /// hands have a handValue which is determined using the static class HandCombinations
    /// only hands with a handValue can be compared.
    /// += operator can be used to append a hand to this hand
    /// </summary>
    public class Hand
    {
        private List<Card> myHand;
        private List<int> handValue;
        public Hand()
        {
            myHand = new List<Card>();
            handValue = new List<int>();
        }
        public Hand(Hand otherHand)
        {
            myHand = new List<Card>(otherHand.myHand);
            handValue = new List<int>();
        }
        public Card this[int index]
        {
            get
            {
                return myHand[index];
            }
            set
            {
                myHand[index] = value;
            }
        }
        public void Clear()
        {
            myHand.Clear();
            handValue.Clear();
        }
        public void Add(Card card)
        {
            myHand.Add(card);
        }
        public void Remove(int index)
        {
            myHand.RemoveAt(index);
        }
        public void Remove(Card card)
        {
            myHand.Remove(card);
        }
        public List<int> getValue()
        {
            return this.handValue;
        }
        public void setValue(int value)
        {
            handValue.Add(value);
        }
        public int Count()
        {
            return myHand.Count;
        }
        public Card getCard(int index)
        {
            if (index >= myHand.Count)
                throw new ArgumentOutOfRangeException();
            return myHand[index];
        }
        List<Card> QuickSortRank(List<Card> myCards)
        {
            Card pivot;
            Random ran = new Random();
            
            if (myCards.Count() <= 1)
                return myCards;
            pivot = myCards[ran.Next(myCards.Count())];
            myCards.Remove(pivot);

            var less = new List<Card>();
            var greater = new List<Card>();
            // Assign values to less or greater list
	        foreach (Card i in myCards)
            {
                if (i > pivot)
                {
                    greater.Add(i);
                }
                else if (i <= pivot)
                {
                    less.Add(i);
                }
            }
	        // Recurse for less and greaterlists
            var list = new List<Card>();
            list.AddRange(QuickSortRank(greater));
            list.Add(pivot);
            list.AddRange(QuickSortRank(less));
            return list;
        }
        List<Card> QuickSortSuit(List<Card> myCards)
        {
            Card pivot;
            Random ran = new Random();

            if (myCards.Count() <= 1)
                return myCards;
            pivot = myCards[ran.Next(myCards.Count())];
            myCards.Remove(pivot);

            var less = new List<Card>();
            var greater = new List<Card>();
            // Assign values to less or greater list
            for (int i = 0; i < myCards.Count(); i++)
            {
                if (myCards[i].getSuit() > pivot.getSuit())
                {
                    greater.Add(myCards[i]);
                }
                else if (myCards[i].getSuit() <= pivot.getSuit())
                {
                    less.Add(myCards[i]);
                }
            }
            // Recurse for less and greaterlists
            var list = new List<Card>();
            list.AddRange(QuickSortSuit(less));
            list.Add(pivot);
            list.AddRange(QuickSortSuit(greater));
            return list;
        }
        public void sortByRank()
        {
            myHand = QuickSortRank(myHand);
        }
        public void sortBySuit()
        {
            myHand = QuickSortSuit(myHand);
        }
        public override string ToString()
        {
            if (this.handValue.Count() == 0)
                return "No Poker Hand is Found";
            switch (this.handValue[0])
            {
                case 1:
                    return Card.rankToString(handValue[1]) + " High";
                case 2:
                    return "Pair of " + Card.rankToString(handValue[1]) + "s";
                case 3:
                    return "Two Pair: "+Card.rankToString(handValue[1]) + "s over " + Card.rankToString(handValue[2])+"s";
                case 4:
                    return "Three " + Card.rankToString(handValue[1]) + "s";
                case 5:
                    return Card.rankToString(handValue[1]) + " High Straight";
                case 6:
                    return Card.rankToString(handValue[1]) + " High Flush";
                case 7:
                    return Card.rankToString(handValue[1]) + "s Full of " + Card.rankToString(handValue[2]) + "s";
                case 8:
                    return "Quad " + Card.rankToString(handValue[1]) + "s";
                case 9:
                    return Card.rankToString(handValue[1]) + " High Straight Flush";
                default:
                    return "Royal Flush";
            }
        }
        //check is the hands are equal, NOT their value
        public bool isEqual(Hand a)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] != myHand[i] || a[i].getSuit() != myHand[i].getSuit())
                    return false;
            }
            return true;
        }
        //operator overloads for hand comparison, check if the hand values are equal
        public static bool operator ==(Hand a, Hand b)
        {
            if (a.getValue().Count == 0 || b.getValue().Count == 0)
                throw new NullReferenceException();
            for (int i = 0; i < a.getValue().Count(); i++)
            {
                if (a.getValue()[i] != b.getValue()[i])
                {
                    return false;
                }
            }
            return true;
        }
        
        public static bool operator !=(Hand a, Hand b)
        {
            if (a.getValue().Count == 0 || b.getValue().Count == 0)
                throw new NullReferenceException();
            for (int i = 0; i < a.getValue().Count(); i++)
            {
                if (a.getValue()[i] != b.getValue()[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator <(Hand a, Hand b)
        {
            if (a.getValue().Count == 0 || b.getValue().Count == 0)
                throw new NullReferenceException();
            for (int i = 0; i < a.getValue().Count(); i++)
            {
                if (a.getValue()[i] < b.getValue()[i])
                {
                    return true;
                }
                if (a.getValue()[i] > b.getValue()[i])
                {
                    return false;
                }
            }
            return false;
        }
        public static bool operator >(Hand a, Hand b)
        {
            if (a.getValue().Count == 0 || b.getValue().Count == 0)
                throw new NullReferenceException();
            for (int i = 0; i < a.getValue().Count(); i++)
            {
                if (a.getValue()[i] > b.getValue()[i])
                {
                    return true;
                }
                if (a.getValue()[i] < b.getValue()[i])
                {
                    return false;
                }

            }
            return false;
        }
        public static bool operator <=(Hand a, Hand b)
        {
            if (a.getValue().Count == 0 || b.getValue().Count == 0)
                throw new NullReferenceException();
            for (int i = 0; i < a.getValue().Count(); i++)
            {
                if (a.getValue()[i] < b.getValue()[i])
                {
                    return true;
                }
                if (a.getValue()[i] > b.getValue()[i])
                {
                    return false;
                }

            }
            return true;
        }
        public static bool operator >=(Hand a, Hand b)
        {
            if (a.getValue().Count == 0 || b.getValue().Count == 0)
                throw new NullReferenceException();
            for (int i = 0; i < a.getValue().Count(); i++)
            {
                if (a.getValue()[i] > b.getValue()[i])
                {
                    return true;
                }
                if (a.getValue()[i] < b.getValue()[i])
                {
                    return false;
                }

            }
            return true;
        }
        public static Hand operator +(Hand a, Hand b)
        {
            for (int i = 0; i < b.Count(); i++)
            {
                a.Add(b[i]);
            }
            return a;
        }
    }
}
