using Chuck.SilverFish;
using SilverFish.Helpers;

namespace SilverFish._cards._04Expansion._011DAL
{
    /// <summary>
    /// EVIL Miscreant
    /// �ֵ����
    /// </summary>
    public class Sim_DAL_415 : SimTemplate
    {
        /// <summary>
        /// Combo: Add two random Lackeys to your hand.
        /// ��������������Ÿ���������������ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.cardsPlayedThisTurn >= 1)
            {
                var count = 2;
                for (var i = 1; i <= count; i++)
                {
                    var cardIdEnum = LackeyHelper.Instance.GetRandomLackey();
                    p.drawACard(cardIdEnum, own.own, true);
                }
            }
        }
    }
}