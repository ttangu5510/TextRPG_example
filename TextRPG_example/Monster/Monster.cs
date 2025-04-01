namespace TextRPG_example.Monster
{
    public interface MonsterAttack
    {
        public int MonsterAttack();
    }
    public class Monster : MonsterAttack
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }
        protected int level;
        public int Level { get { return level; } set { level = value; } }
        protected int hp;
        protected int exp;
        public int Exp { get { return exp; } set { exp = value; } }
        public int Hp { get { return hp; } set { hp = value; } }
        protected int monsterId;
        public int MonsterId { get { return monsterId; } set { monsterId = value; } }
        protected List<Item.Item> dropItems;
        protected int power;
        public int Power { get { return power; } set { power = value; } }
        public List<Item.Item> DropItems { get { return dropItems; } set { dropItems = value; } }
        protected int defence;
        public int Defence { get { return defence; } set { defence = value; } }
        protected int gold;
        protected int Gold { get { return gold; } set { gold = value; } }
        public int MonsterAttack()
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 120);
            if(randNum > 100)
            {
                Util.Print($"크리티컬 !!!\n{Name}이 공격했다!",ConsoleColor.Red,30);
                return Power*130/100;
            }
            else
            {                
                Util.Print($"{Name}이 공격했다!");
                return Power;
            }
        }
    }
}
