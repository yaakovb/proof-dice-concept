using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class GameLogic
    {
        private Dictionary<DiceTypes, DiceTypes> refAnthema;
        private static GameLogic instance;
        public static GameLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameLogic();
                }
                return instance;
            }
        }


        public GameLogic()
        {
            refAnthema = new Dictionary<DiceTypes, DiceTypes>();
            refAnthema[DiceTypes.TypeA] = DiceTypes.TypeC;
            refAnthema[DiceTypes.TypeB] = DiceTypes.TypeD;
            refAnthema[DiceTypes.TypeC] = DiceTypes.TypeE;
            refAnthema[DiceTypes.TypeD] = DiceTypes.TypeA;
            refAnthema[DiceTypes.TypeE] = DiceTypes.TypeB;
        }

        public bool IsDiceAnthemaToOtherDice(DiceTypes dice, DiceTypes otherDice)
        {
            return refAnthema[dice] == otherDice;
        }

        public int[] GetSpin(int diceType)
        {
            int[] result = new int[2] { 0, 0 };
            Dice d = new Dice();
            d.Init((DiceTypes)diceType);
            BasicDiceSide roll = d.DiceRoll;
            result[0] = (int)roll.M_type;
            result[1] = roll.M_val;
            return result;
        }

        
    }
}
