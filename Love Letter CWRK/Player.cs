using System;
using System.Collections.Generic;
using System.Text;

namespace Love_Letter_CWRK
{
    /*
     * Class describing an individual player within the game
    */ 
    class Player
    {
        /*
         * Default constructor
        */ 
        public Player()
        { }

        /*
         * Empties the players hand and discard pile ready for a new round
        */ 
        public void Cleanup()
        { }

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
    }
}
