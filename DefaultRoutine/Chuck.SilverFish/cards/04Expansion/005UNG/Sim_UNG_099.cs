using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._005UNG
{
    /// <summary>
    /// Charged Devilsaur
    /// �񱼵�ħ����
    /// </summary>
    class Sim_UNG_099 : SimTemplate
	{
        /// <summary>
        /// Charge Battlecry: Can't attack heroes this turn.
        /// ��棬ս���ڱ��غ����޷�����Ӣ�ۡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            own.cantAttackHeroes = true;
		}

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                triggerEffectMinion.cantAttackHeroes = false;
            }
        }
    }
}