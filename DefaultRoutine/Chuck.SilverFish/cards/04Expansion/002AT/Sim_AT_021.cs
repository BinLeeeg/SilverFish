using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._002AT
{
    /// <summary>
    /// С����ʿ(Tiny Knight of Evil)
    /// Tiny Knight of Evil
    /// </summary>
    class Sim_AT_021 : SimTemplate
	{
        /// <summary>
        /// Whenever you discard a card, gain +1/+1.
        /// ÿ��������һ����ʱ������+1/+1��
        /// </summary>
        /// <param name="p"></param>
        /// <param name="hc"></param>
        /// <param name="own"></param>
        /// <param name="num"></param>
        /// <param name="checkBonus"></param>
        /// <returns></returns>
        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (own == null) return false;
            if (checkBonus) return false;

            p.minionGetBuffed(own, num, num);
            return false;
        }
    }
}