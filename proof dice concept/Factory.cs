﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    enum DiceTypes { TypeA = 0, TypeB = 1, TypeC = 2, TypeD = 3, TypeE = 4}
    class Factory
    {
        static public BasicDiceSide CreateDiceSide(int val, DiceTypes dieType)
        {
            BasicDiceSide retVal;
            switch (dieType)
            {
                case DiceTypes.TypeA:
                    retVal = new TypeADiceSide(val);
                    break;
                case DiceTypes.TypeB:
                    retVal = new TypeBDiceSide(val);
                    break;
                case DiceTypes.TypeC:
                    retVal = new TypeCDiceSide(val);
                    break;
                case DiceTypes.TypeD:
                    retVal = new TypeDDiceSide(val);
                    break;
                case DiceTypes.TypeE:
                    retVal = new TypeEDiceSide(val);
                    break;
                default:
                    retVal = null;
                    break;
            }
            return retVal;
        }
    }
}
