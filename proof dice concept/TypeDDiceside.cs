using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class TypeDDiceside : BasicDiceSide
    {
        public int interactWithTypeADice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public int interactWithTypeBDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public int interactWithTypeCDice(int otherDiceVal)
        {
            return -1;
        }

        public int interactWithTypeDDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public int interactWithTypeEDice(int otherDiceVal)
        {
            return 1;
        }
    }
}
