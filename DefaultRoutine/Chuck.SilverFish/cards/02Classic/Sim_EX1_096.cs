using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_096 : SimTemplate //* loothoarder
	{

//    todesröcheln:/ zieht eine karte.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardName.unknown, m.own);
        }

	}
}