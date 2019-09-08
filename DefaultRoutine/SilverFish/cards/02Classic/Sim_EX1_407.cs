using HREngine.Bots;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_407 : SimTemplate //* Brawl
	{
        // Destroy all minions except one. (chosen randomly)

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            bool hasWinner = false;
            foreach (Minion m in p.enemyMinions)
            {
                if ((m.name == CardDB.CardName.darkironbouncer || m.name == CardDB.CardName.corendirebrew) && !hasWinner)
                {
                    hasWinner = true;
                    continue;
                }
                p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.ownMinions)
            {
                if ((m.name == CardDB.CardName.darkironbouncer || m.name == CardDB.CardName.corendirebrew) && !hasWinner)
                {
                    hasWinner = true;
                    continue;
                }
                p.minionGetDestroyed(m);
            }
		}
	}
}