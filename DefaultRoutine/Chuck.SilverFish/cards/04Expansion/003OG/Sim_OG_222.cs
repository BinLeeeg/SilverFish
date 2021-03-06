using System.Collections.Generic;
using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._003OG
{
    class Sim_OG_222 : SimTemplate //* Rallying Blade
    {
        //Battlecry: Give +1/+1 to your minions with Divine Shield.

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardIdEnum.OG_222);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.DivineShield) p.minionGetBuffed(m, 1, 1);
            }
        }
    }
}