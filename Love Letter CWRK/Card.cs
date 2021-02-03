using System;
using System.Collections.Generic;
using System.Text;

namespace Love_Letter_CWRK
{
    /*
     * This is a purely virtual class describing & inherited by all cards in the game
    */
    class Card
    {
        public Card()
        {}

        /*
         * Run when a player plays this card
         * TODO: Needs to take in arguments of the target player and the owner of this card
        */
        public virtual void Play()
        {}

        /*
         * The number value associated with this type of card
        */
        public const uint m_Value = 0;

        /*
         * This cards name
        */
        public const string m_Name = "";

        /*
         * Plaintext describing the effect of the card when the play function is run
        */ 
        public const string m_EffectText = "";
    }
}
