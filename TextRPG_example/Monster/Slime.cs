namespace TextRPG_example.Monster
{
    public class Slime : Monster
    {
        Item.RedPotion redPotion = new Item.RedPotion();
        public Slime()
        {
            Name = "슬라임";
            MonsterId = 1;
            power = 2;
            defence = 1;
            Level = 2;
            exp = 3;
            Hp = 15;
            DropItems = [redPotion];
            Gold = 15;
        } 
    }
}
