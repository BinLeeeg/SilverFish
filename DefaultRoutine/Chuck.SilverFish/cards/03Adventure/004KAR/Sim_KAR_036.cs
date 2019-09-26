using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._004KAR
{
    /// <summary>
    /// Arcane Anomaly
    /// ��������
    /// </summary>
	class Sim_KAR_036 : SimTemplate
	{
        /// <summary>
        /// Whenever you cast a spell, give this minion +1 Health.
        /// ÿ����ʩ��һ������������ӱ��� +1����ֵ��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="hc"></param>
        /// <param name="wasOwnCard"></param>
        /// <param name="triggerEffectMinion"></param>
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardType.SPELL)
            {
				p.minionGetBuffed(triggerEffectMinion, 0, 1);
            }
        }
	}
}