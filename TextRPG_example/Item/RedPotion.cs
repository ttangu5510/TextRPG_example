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
            Name = "빨간 포션";
            Description = $"사용하면 체력을 {HpHeal}만큼 회복한다";
            ItemNumber = 1;
            ItemId = 0;
            BuyPrice = 150;
            SellPrice = 50;
        }
        public int ItemUse()
        {
            return HpHeal;
        }
    }
}
