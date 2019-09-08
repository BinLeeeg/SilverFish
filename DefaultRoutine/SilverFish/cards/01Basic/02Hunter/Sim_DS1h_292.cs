using HREngine.Bots;

namespace SilverFish.cards._01Basic._02Hunter
{
    /// <summary>
    /// Steady Shot
    /// �ȹ����
    /// </summary>
	public class Sim_DS1h_292 : SimTemplate
    {
        protected virtual int Damage { get; set; } = 2;

        /// <summary>
        /// Hero Power Deal 2 damage.
        /// Ӣ�ۼ��� ���2���˺���
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = ownplay ? p.getHeroPowerDamage(Damage) : p.getEnemyHeroPowerDamage(Damage);
            if (target == null)
            {
                target = ownplay ? p.enemyHero : p.ownHero;
            }
            p.minionGetDamageOrHeal(target, dmg);
		}
	}

    public class Sim_DS1h_292_H1 : Sim_DS1h_292
    {
    }

    /// <summary>
    /// Ballista Shot
    /// �������
    /// </summary>
    public class Sim_DS1h_292_H1_AT_132 : Sim_DS1h_292
    {
        /// <summary>
        /// Hero Power Deal 3 damage.
        /// Ӣ�ۼ��� ���3���˺���
        /// </summary>
        protected override int Damage { get; set; } = 3;
    }
}