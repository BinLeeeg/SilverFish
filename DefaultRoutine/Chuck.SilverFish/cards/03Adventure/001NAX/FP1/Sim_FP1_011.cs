using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._03Adventure._001NAX.FP1
{
	class Sim_FP1_011 : SimTemplate //* webspinner
	{

//    todesröcheln:/ fügt eurer hand ein zufälliges wildtier hinzu.
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardName.rivercrocolisk, m.own, true);
        }
	}
}