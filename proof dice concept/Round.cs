using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proof_dice_concept
{
    class Round
    {
        private Dice[] playerDice;
        private Dice[] enemyDice;

        public Round()
        {
            playerDice = new Dice[2] { null, null };
            enemyDice = new Dice[2] { null, null };
        }

        private void SetDice(Dice[] targetPlayerDiceArray, int idx, DiceTypes diceType)
        {
            Dice d = new Dice();
            d.Init(diceType);
            targetPlayerDiceArray[idx] = d;
        }

        public void SetDice(bool isPlayerDice, int idx, int diceTypeVal)
        {
            DiceTypes diceType = (DiceTypes)diceTypeVal;
            if (isPlayerDice)
                SetDice(playerDice, idx, diceType);
            else
                SetDice(enemyDice, idx, diceType);
        }

        private BasicDiceSide playerSpin1;
        public BasicDiceSide PlayerSpin1
        {
            get { return playerSpin1; }
        }

        private BasicDiceSide playerSpin2;
        public BasicDiceSide PlayerSpin2
        {
            get { return playerSpin2; }
        }

        private BasicDiceSide enemySpin1;
        public BasicDiceSide EnemySpin1
        {
            get { return enemySpin1; }
        }

        private BasicDiceSide enemySpin2;
        public BasicDiceSide EnemySpin2
        {
            get { return enemySpin2; }
        }

        public bool IsStraightForcedOutCome()
        {
            bool val1 = GameLogic.Instance.IsDiceAnthemaToOtherDice(PlayerSpin1.M_type, EnemySpin1.M_type);
            bool val2 = GameLogic.Instance.IsDiceAnthemaToOtherDice(PlayerSpin2.M_type, EnemySpin2.M_type);
            return val1 || val2;
        }

        public bool IsCrossedForcedOutCome()
        {
            bool val1 = GameLogic.Instance.IsDiceAnthemaToOtherDice(PlayerSpin1.M_type, EnemySpin2.M_type);
            bool val2 = GameLogic.Instance.IsDiceAnthemaToOtherDice(PlayerSpin2.M_type, EnemySpin1.M_type);
            return val1 || val2;
        }

        public void Spin()
        {
            playerSpin1 = playerDice[0].DiceRoll;
            playerSpin2 = playerDice[1].DiceRoll;
            enemySpin1 = enemyDice[0].DiceRoll;
            enemySpin2 = enemyDice[1].DiceRoll;
        }
    }
}
