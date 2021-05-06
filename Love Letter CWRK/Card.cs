﻿using System;
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
        { }

        /*
         * Run when a player plays this card
         * Takes in both the target player & the owner of this card by reference for resolving the effects
        */
        public virtual void Play(ref Player targetPlayer, ref Player owner)
        { }

        public virtual bool Playable(Card[] playerHand)
        {
            return true;
        }

        public uint GetValue()
        {
            return m_Value;
        }

        /*
         * The number value associated with this type of card
        */
        public const uint m_Value = 0;

        public string GetName()
        {
            return m_Name;
        }

        /*
         * This cards name
        */
        public const string m_Name = "";

        public string GetEffectText()
        {
            return m_EffectText;
        }

        /*
         * Plaintext describing the effect of the card when the play function is run
        */
        public const string m_EffectText = "";
    }

    namespace Cards
    {
        class Guard : Card
        {
            public override void Play(ref Player targetPlayer, ref Player owner) 
            {
                Console.WriteLine("Enter the name of the target card.");

                string cardName;

                // Do not continue until an existing card name is given
                while (true)
                {
                    cardName = Console.ReadLine();

                    if (cardName.ToLower() != "guard" && GameManager.IsCard(cardName))
                        break;
                }

                // Get the hand of the target player
                Card[] targetPlayerHand = targetPlayer.GetHand();

                // If the given card is contained within the target players hand, they are out
                for (int i = 0; i < 2; i++)
                    if (targetPlayerHand[i].GetName() == cardName.ToLower())
                    {
                        targetPlayer.SetOut(true);
                        break;
                    }
            }

            new public const uint m_Value = 1;

            new public const string m_Name = "Guard";

            new public const string m_EffectText = 
                "Name a non guard card and choose another player. If that player has that card he or she is out of the round.";
        }

        class Priest : Card
        {
            new public const uint m_Value = 2;

            new public const string m_Name = "Priest";

            new public const string m_EffectText =
                "Look at another players hand.";
        }

        class Baron : Card
        {
            new public const uint m_Value = 3;

            new public const string m_Name = "Baron";

            new public const string m_EffectText =
                "You and another player secretly compare hands. The player with the lower value is out of the round.";
        }

        class Handmaid : Card
        {
            new public const uint m_Value = 4;

            new public const string m_Name = "Handmaid";

            new public const string m_EffectText =
                "Until your next turn, ignore all effects from other player's cards.";
        }

        class Prince : Card
        {
            new public const uint m_Value = 5;

            new public const string m_Name = "Prince";

            new public const string m_EffectText =
                "Choose any player (including yourself) to discard his or her hand and draw a new card.";
        }

        class King : Card
        {
            new public const uint m_Value = 6;

            new public const string m_Name = "King";

            new public const string m_EffectText =
                "Trade hands with another player of your choice.";
        }

        class Countess : Card
        {
            new public const uint m_Value = 7;

            new public const string m_Name = "Countess";

            new public const string m_EffectText =
                "If you have this card and the King or Prince in your hand, you must discard this card.";
        }

        class Princess : Card
        {
            new public const uint m_Value = 8;

            new public const string m_Name = "Princess";

            new public const string m_EffectText =
                "If you discard this card, you are out of the round.";
        }
    }
}
