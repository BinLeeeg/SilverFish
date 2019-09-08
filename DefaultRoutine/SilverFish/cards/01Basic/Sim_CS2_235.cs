using HREngine.Bots;

namespace SilverFish.cards._01Basic
{
	class Sim_CS2_235 : SimTemplate //* northshirecleric
	{
        //Whenever a minion is healed, draw a card.

        public override void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, int minionsGotHealed)
        {
            for (int i = 0; i < minionsGotHealed; i++)
            {
                p.drawACard(CardDB.CardName.unknown, triggerEffectMinion.own);
            }
        }
	}
}