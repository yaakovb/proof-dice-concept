using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    abstract class BasicDiceSide
    {
        private int m_val;
        public int M_val { get { return m_val; } }
        public abstract DiceTypes M_type
        {
            get;
        }
        public BasicDiceSide(int val)
        {
            m_val = val;
        }

        public abstract int InteractWithOtherDice(BasicDiceSide otherDiceSide);
        public abstract int InteractWithTypeADice(int otherDiceVal);
        public abstract int InteractWithTypeBDice(int otherDiceVal);
        public abstract int InteractWithTypeCDice(int otherDiceVal);
        public abstract int InteractWithTypeDDice(int otherDiceVal);
        public abstract int InteractWithTypeEDice(int otherDiceVal);
    }
}
