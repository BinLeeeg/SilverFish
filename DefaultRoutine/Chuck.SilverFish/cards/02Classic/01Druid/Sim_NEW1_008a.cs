using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._02Classic._01Druid
{
    class Sim_NEW1_008a : SimTemplate //* Ancient Teachings
	{
        //Draw a card.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardName.unknown, ownplay);
        }
    }
}