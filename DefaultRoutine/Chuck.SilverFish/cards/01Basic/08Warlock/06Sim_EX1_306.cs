namespace Chuck.SilverFish.cards._01Basic._08Warlock
{
    /// <summary>
    /// Felstalker
    /// ħȮ
    /// </summary>
    class Sim_EX1_306 : SimTemplate
	{
        /// <summary>
        /// Battlecry: Discard a random card.
        /// ս�� �����һ���ơ�
        /// </summary>
        /// <param name="p"></param>
        /// <param name="own"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.discardCards(1, own.own);
		}
	}
}