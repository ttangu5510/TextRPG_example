namespace TextRPG_example.Item
{
    public class RedPotion : Item, IUsable
    {
        private int hpHeal = 50;
        public int HpHeal
        {
            get { return hpHeal; }
        }
        public RedPotion()
        {
            Name = "포션";
            Description = "포션이다. 사용하면 체력을 회복한다";
            ItemNumber = 1;
            ItemId = 0;
        }
        public int ItemUse()
        {
            return HpHeal;
        }
    }
}
