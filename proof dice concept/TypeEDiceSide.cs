using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class TypeEDiceSide : BasicDiceSide
    {
        public int interactWithTypeADice(int otherDiceVal)
        {
            return 1;
        }

        public abstract int interactWithTypeBDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public abstract int interactWithTypeCDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public abstract int interactWithTypeDDice(int otherDiceVal)
        {
            return -1;
        }

        public abstract int interactWithTypeEDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }
    }
}
