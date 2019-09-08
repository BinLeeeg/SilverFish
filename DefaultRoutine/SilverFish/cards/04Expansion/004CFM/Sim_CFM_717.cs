using HREngine.Bots;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._004CFM
{
    /// <summary>
    /// Jade Claws
    /// ����֮צ
    /// </summary>
	public class Sim_CFM_717 : SimTemplate
	{
        
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardIdEnum.CFM_717);

        /// <summary>
        /// "LocStringEnUs": "<b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.\n<b><b>Overload</b>:</b> (1)@<b>Battlecry:</b> Summon a <b>Jade Golem</b>.
        /// "LocStringZhCn": "<b>ս��</b>�ٻ�һ��{0}��<b>����ħ��</b>��\n<b>���أ�</b>��1��@<b>ս��</b>�ٻ�һ��<b>����ħ��</b>��\n<b>���أ�</b>��1��",
        /// </summary>
        /// <param name="p"></param>
        /// <param name="ownplay"></param>
        /// <param name="target"></param>
        /// <param name="choice"></param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.CallKid(p.getNextJadeGolem(ownplay), place, ownplay);
        }
    }
}