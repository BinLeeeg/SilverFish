using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._001NAX.FP1
{
	class Sim_FP1_029 : SimTemplate //dancingswords
	{

//    todesröcheln:/ euer gegner zieht eine karte.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardName.unknown, !m.own);
        }

	}
}