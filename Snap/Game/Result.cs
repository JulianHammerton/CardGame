using System;
using System.Collections.Generic;
using System.Text;

namespace Snap.Classes
{
    public class Result
    {
        int Player1Tally = 0;
        int Player2Tally = 0;

        public String Output()
        {
            if (Player1Tally > Player2Tally)
                return "Player 1 wins";
            else if ((Player2Tally > Player1Tally))
                return "Player 2 wins";
            else
                return "It was a drawer";
        }
    }
}
