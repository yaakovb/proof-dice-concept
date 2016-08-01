using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class TypeBDiceSide : BasicDiceSide
    {
        public TypeBDiceSide(int val) : base(val) { }

        public override DiceTypes M_type
        {
            get { return DiceTypes.TypeB; }
        }

        public override int InteractWithOtherDice(BasicDiceSide otherDiceSide)
        {
            return -1 * otherDiceSide.InteractWithTypeBDice(M_val);
        }

        public override int InteractWithTypeADice(int otherDiceVal)
        {
            return -1;
        }

        public override int InteractWithTypeBDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public override int InteractWithTypeCDice(int otherDiceVal)
        {
            return 1;
        }

        public override int InteractWithTypeDDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

        public override int InteractWithTypeEDice(int otherDiceVal)
        {
            return M_val.CompareTo(otherDiceVal);
        }

    }
}
