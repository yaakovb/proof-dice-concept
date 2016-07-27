using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class Statiscs
    {
        static public int[] GetDiceTypeCompersionStatisics(DiceTypes firstType, DiceTypes secondType)
        {
            int[] retVal = new int[3]{0, 0, 0};

            Dice firstDice = new Dice();
            firstDice.Init(firstType);
            Dice secondDice = new Dice();
            secondDice.Init(secondType);

            for (int i = 0; i < 6; i++ )
            {
                BasicDiceSide sideFromFirstDice = firstDice.GetDiceRoll(i);
                for (int j = 0; j < 6; j++)
                {
                    BasicDiceSide sideFromSecondDice = secondDice.GetDiceRoll(j);
                    int fightResult = sideFromFirstDice.InteractWithOtherDice(sideFromSecondDice);
                    retVal[fightResult + 1]++;
                }
            }
            return retVal;
        }

        static public void CreateStatiscsIntoFile()
        {
            string outputFormat = "SHANI IS THE HOTTEST !! EVER!!!!!!!!!!! Type A vs {0} stats:\nlosses - {1}   draws - {2}   wins- {3}\n\n";
            int[] retVal = GetDiceTypeCompersionStatisics(DiceTypes.TypeA, DiceTypes.TypeA);
            File.AppendAllText("tmp.txt", string.Format(outputFormat, "Type A", retVal[0], retVal[1], retVal[2]));
            retVal = GetDiceTypeCompersionStatisics(DiceTypes.TypeA, DiceTypes.TypeB);
            File.AppendAllText("tmp.txt", string.Format(outputFormat, "Type B", retVal[0], retVal[1], retVal[2]));
            retVal = GetDiceTypeCompersionStatisics(DiceTypes.TypeA, DiceTypes.TypeC);
            File.AppendAllText("tmp.txt", string.Format(outputFormat, "Type C", retVal[0], retVal[1], retVal[2]));
            retVal = GetDiceTypeCompersionStatisics(DiceTypes.TypeA, DiceTypes.TypeD);
            File.AppendAllText("tmp.txt", string.Format(outputFormat, "Type D", retVal[0], retVal[1], retVal[2]));
            retVal = GetDiceTypeCompersionStatisics(DiceTypes.TypeA, DiceTypes.TypeE);
            File.AppendAllText("tmp.txt", string.Format(outputFormat, "Type E", retVal[0], retVal[1], retVal[2]));

        }
    }
}
