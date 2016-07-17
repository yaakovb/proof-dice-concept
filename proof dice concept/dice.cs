using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class Dice
    {
        Random rng = new Random();
        private BasicDiceSide[] diceRoll;
        public BasicDiceSide DiceRoll
        {
            get
            {
                return diceRoll[rng.Next(0, 5)];
            }
        }

        public Dice()
        {
            diceRoll = new BasicDiceSide[6];
        }

        public BasicDiceSide GetDiceRoll(int index)
        {
            return diceRoll[index];
        }

        public
    }
}
