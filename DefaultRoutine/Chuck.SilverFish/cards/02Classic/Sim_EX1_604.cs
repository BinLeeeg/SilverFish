using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_604 : SimTemplate //* frothingberserker
	{
        // Whenever a minion takes damage, gain +1 Attack.
        // if will be increase attack trigger in the game - rebuild it

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            p.minionGetBuffed(m, anzOwnMinionsGotDmg + anzEnemyMinionsGotDmg - anzOwnHeroGotDmg - anzEnemyHeroGotDmg, 0);
        }

	}
}