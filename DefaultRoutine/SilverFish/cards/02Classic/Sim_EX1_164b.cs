using HREngine.Bots;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_164b : SimTemplate //nourish
	{

//    zieht 3 karten.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.CardName.unknown, ownplay);
            p.drawACard(CardDB.CardName.unknown, ownplay);
            p.drawACard(CardDB.CardName.unknown, ownplay);
		}

	}
}