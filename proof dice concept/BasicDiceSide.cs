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
        public int M_val{ get; }
        public string M_type
        {
            get
            {
                return this.GetType().ToString();
            }
        }

        public int interactWithOtherDice(BasicDiceSide otherDiceSide)
        {
            return -1 * otherDiceSide.interactWithTypeADice(M_val);
        }

        public abstract int interactWithTypeADice(int otherDiceVal);
        public abstract int interactWithTypeBDice(int otherDiceVal);
        public abstract int interactWithTypeCDice(int otherDiceVal);
        public abstract int interactWithTypeDDice(int otherDiceVal);
        public abstract int interactWithTypeEDice(int otherDiceVal);
    }
}
