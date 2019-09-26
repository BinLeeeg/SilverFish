using Chuck.SilverFish;

namespace SilverFish.cards._04Expansion._006ICC
{
    /// <summary>
    /// Voidform
    /// �����̬
    /// </summary>
    class Sim_ICC_830p: SimTemplate
    {
        /// <summary>
        /// Hero Power Deal 2 damage.
        /// Ӣ�ۼ��� ���2���˺���
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
        }

        /// <summary>
        /// After you play a card, refresh this.
        /// ����ʹ��һ���ƺ󣬸�ԭ���Ӣ�ۼ��ܡ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="hc"></param>
        /// <param name="ownplay"></param>
        /// <param name="triggerhc"></param>
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        {
            if (ownplay)
            {
                p.ownAbilityReady = true;
            }
            else
            {
                p.enemyAbilityReady = true;
            }
        }
    }
}