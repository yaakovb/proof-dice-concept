using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class Dice
    {
        private Random rng = new Random();
        private BasicDiceSide[] m_diceRoll;
        public BasicDiceSide DiceRoll
        {
            get
            {
                return m_diceRoll[rng.Next(0, 5)];
            }
        }

        public Dice()
        {
            m_diceRoll = new BasicDiceSide[6];
        }

        public void Init(DiceTypes diceType)
        {
            DiceTypes mainType = diceType;
            DiceTypes weaknessProtection = diceType;
            DiceTypes anethemaProtection = diceType;

            switch (diceType)
            {
                case DiceTypes.TypeA:
                    weaknessProtection = DiceTypes.TypeD;
                    anethemaProtection = DiceTypes.TypeE;
                    break;
                case DiceTypes.TypeB:
                    weaknessProtection = DiceTypes.TypeE;
                    anethemaProtection = DiceTypes.TypeA;
                    break;
                case DiceTypes.TypeC:
                    weaknessProtection = DiceTypes.TypeA;
                    anethemaProtection = DiceTypes.TypeD;
                    break;
                case DiceTypes.TypeD:
                    weaknessProtection = DiceTypes.TypeB;
                    anethemaProtection = DiceTypes.TypeE;
                    break;
                case DiceTypes.TypeE:
                    weaknessProtection = DiceTypes.TypeC;
                    anethemaProtection = DiceTypes.TypeA;
                    break;
                default:
                    break;                    
            }

            m_diceRoll[0] = Factory.CreateDiceSide(1, mainType);
            m_diceRoll[1] = Factory.CreateDiceSide(2, mainType);
            m_diceRoll[2] = Factory.CreateDiceSide(3, mainType);
            m_diceRoll[3] = Factory.CreateDiceSide(4, mainType);
            m_diceRoll[4] = Factory.CreateDiceSide(1, weaknessProtection);
            m_diceRoll[5] = Factory.CreateDiceSide(2, anethemaProtection);
        }

        public BasicDiceSide GetDiceRoll(int index)
        {
            return m_diceRoll[index];
        }
    }
}
