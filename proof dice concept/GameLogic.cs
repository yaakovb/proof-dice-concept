using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class GameLogic
    {
        public int[] GetSpin(int diceType)
        {
            int[] result = new int[2] { 0, 0 };
            Dice d = new Dice();
            d.Init((DiceTypes)diceType);
            BasicDiceSide roll = d.DiceRoll;
            result[0] = 

            return result;
        }
    }
}
