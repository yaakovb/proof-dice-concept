using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class TypeDDiceSide : BasicDiceSide
    {
        public TypeDDiceSide(int val) : base(val) { }

        public override DiceTypes M_type
        {
            get { return DiceTypes.TypeD; }
        }

        public override int InteractWithOtherDice(BasicDiceSide otherDiceSide)
        {
            return -1 * otherDiceSide.InteractWithTypeDDice(M_val);
        }

        public override int InteractWithTypeADice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public override int InteractWithTypeBDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public override int InteractWithTypeCDice(int otherDiceVal)
        {
            return -1;
        }

        public override int InteractWithTypeDDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public override int InteractWithTypeEDice(int otherDiceVal)
        {
            return 1;
        }
    }
}
