using System.Collections.Generic;
using HREngine.Bots;

namespace SilverFish.cards._02Classic
{
    class Sim_EX1_006 : SimTemplate //* Alarm-o-Bot
	{
        //At the start of your turn, swap this minion with a random one in your hand.

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (turnStartOfOwner && triggerEffectMinion.own == turnStartOfOwner)
            {
                List<Handmanager.Handcard> temp2 = new List<Handmanager.Handcard>();
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.CardType.MOB) temp2.Add(hc);
                }
                temp2.Sort((a, b) => -a.card.Attack.CompareTo(b.card.Attack));//damage the stronges
                foreach (Handmanager.Handcard mins in temp2)
                {
                    CardDB.Card c = CardDB.Instance.getCardDataFromID(mins.card.cardIDenum);
                    p.minionTransform(triggerEffectMinion, c);
                    triggerEffectMinion.playedThisTurn = false;
                    triggerEffectMinion.Ready = true;
                    p.removeCard(mins);
                    p.drawACard(CardDB.CardName.alarmobot, true, true);
                    break;
                }
                return;
            }

            if (!turnStartOfOwner && triggerEffectMinion.own == turnStartOfOwner)
            {
                p.minionGetBuffed(triggerEffectMinion, 4, 4);
                triggerEffectMinion.HealthPoints = triggerEffectMinion.maxHp;
            }
        }
	}
}