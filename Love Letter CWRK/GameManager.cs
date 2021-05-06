using System;
using System.Collections.Generic;
using System.Text;

namespace Love_Letter_CWRK
{
    class GameManager
    {

        static Card[] StartingDeck = {
            new Cards.Guard(), new Cards.Guard(), new Cards.Guard(), new Cards.Guard(), new Cards.Guard(),
            new Cards.Priest(), new Cards.Priest(),
            new Cards.Baron(), new Cards.Baron(),
            new Cards.Handmaid(), new Cards.Handmaid(),
            new Cards.Prince(), new Cards.Prince(),
            new Cards.King(),
            new Cards.Countess(),
            new Cards.Princess()
        };
    }
}
