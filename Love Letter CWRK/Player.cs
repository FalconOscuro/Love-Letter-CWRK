using System;

namespace Love_Letter_CWRK
{
    /*
     * Class describing an individual player within the game
    */
    internal class Player
    {
        /*
         * Constructor to set variables to their default values
        */
        public Player()
        {
            m_Hand = new Card[2];
            m_Tokens = 0;
            m_Out = false;
            m_Targetable = true;
        }

        /*
         * Empties the players hand and discard pile ready for a new round
        */
        public void Cleanup()
        { }

        /*
         * Adds a card to the players hand
        */
        public bool AddCard(Card card)
        {
            if (m_Hand[1] == new Card())
                return false;

            m_Hand[1] = card;

            return true;
        }

        public void DiscardCard(int i)
        {
            int numDiscards = m_Discards.Length;
            Array.Resize(ref m_Discards, numDiscards + 1);

            m_Discards[numDiscards] = m_Hand[i];

            // Ensure that position zero in a players hand is always populated
            if (i == 0)
                m_Hand[0] = m_Hand[1];

            m_Hand[1] = new Card();
        }

        /*
         * Getter function for a player's hand
        */
        public ref Card[] GetHand()
        {
            return ref m_Hand;
        }

        public bool IsOut()
        {
            return m_Out;
        }

        public void SetOut(bool state)
        {
            m_Out = state;
        }

        public bool IsTargetable()
        {
            return !m_Out && m_Targetable;
        }

        public void SetTargetable(bool state)
        {
            m_Targetable = state;
        }

        /// Private attributes
        /*
         * An array of the cards currently in this players hand
         * Always initialized to a length of 2 as that is the maximum hand size
        */
        private Card[] m_Hand;

        /*
         * An array of all of the cards this player has played this round
        */
        private Card[] m_Discards;

        /*
         * The current number of tokens that this player has
        */
        private int m_Tokens;

        private bool m_Out;

        private bool m_Targetable;
    }
}