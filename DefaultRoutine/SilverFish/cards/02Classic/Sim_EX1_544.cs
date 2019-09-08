using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_544 : SimTemplate //flare
    {

        //    alle diener verlieren verstohlenheit/. zerstört alle feindlichen geheimnisse/. zieht eine karte.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinions)
            {
                m.stealth = false;
            }
            foreach (Minion m in p.enemyMinions)
            {
                m.stealth = false;
            }
            if (ownplay)
            {
                p.enemySecretCount = 0;
                p.enemySecretList.Clear();
            }
            else
            {
                p.ownSecretsIDList.Clear();
            }
            p.drawACard(CardName.unknown, ownplay);
        }

    }

}