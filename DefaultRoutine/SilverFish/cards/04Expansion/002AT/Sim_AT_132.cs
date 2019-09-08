using HREngine.Bots;

namespace SilverFish.cards._04Expansion._002AT
{
	class Sim_AT_132 : SimTemplate //* Justicar Trueheart
	{
		//Battlecry: Replace your starting Hero Power with a better one.
		
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            TAG_CLASS HeroStartClass = (m.own) ? p.ownHeroStartClass : p.enemyHeroStartClass;
			CardIdEnum tmp = CardIdEnum.None;

            switch (HeroStartClass)
            {
                case TAG_CLASS.WARRIOR:
					tmp = CardIdEnum.AT_132_WARRIOR; //Tank Up!
					break;
                case TAG_CLASS.WARLOCK:
					tmp = CardIdEnum.AT_132_WARLOCK; //Soul Tap
                    break;
                case TAG_CLASS.ROGUE:
					tmp = CardIdEnum.AT_132_ROGUE; //Poisoned Daggers
					break;
                case TAG_CLASS.SHAMAN:
					tmp = CardIdEnum.AT_132_SHAMAN; //Totemic Slam
					break;
                case TAG_CLASS.PRIEST:
					tmp = CardIdEnum.AT_132_PRIEST; //Heal
					break;
                case TAG_CLASS.PALADIN:
					tmp = CardIdEnum.AT_132_PALADIN; //The Silver Hand
					break;
                case TAG_CLASS.MAGE:
					tmp = CardIdEnum.AT_132_MAGE; //Fireblast Rank 2
					break;
                case TAG_CLASS.HUNTER:
					tmp = CardIdEnum.AT_132_HUNTER; //Ballista Shot
					break;
                case TAG_CLASS.DRUID:
					tmp = CardIdEnum.AT_132_DRUID; //Dire Shapeshift
                    break;
				//default:
			}

            if (tmp != CardIdEnum.None) p.setNewHeroPower(tmp, m.own);
		}
	}
}