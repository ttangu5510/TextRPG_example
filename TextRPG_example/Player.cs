namespace TextRPG_example
{ 
    public class Player
    {
        private int level;
        public int Level { get { return level; } set { level = value; } }
        private int exp;
        public int Exp { get { return exp; } set { exp = value; } }
        private int defence;
        public int Defence { get { return defence; } set { defence = value; } }
        private int power;
        public int Power { get { return power; } set { power = value; } }
        private int speed;
        public int Speed
        { get { return speed; } set { speed = value; } }
        private int gold;

        public int Gold { get { return gold; } set { gold = value; } }
        private int critical;
        public int Critical { get { return critical; } set { critical = value; } }
        
        private List<Item.Item> inventory;
        public List<Item.Item> Inventory { get { return inventory; } set { inventory = value; } }

        private Equipments equipments = new Equipments();
        public Equipments Equipments
        {
            get {  return equipments; }
            set { equipments = value; }
        }

        public Player()
        {
            Inventory = new List<Item.Item>();
            Level = 1;
            Exp = 0;
            Power = 5;
            Defence = 3;
            Speed = 5;
            critical = 10;
            Gold = 1000;
            equipments[EquipPart.Head] = new Item.EquipNohead();
            equipments[EquipPart.TopWear] = new Item.EquipNoTop();
            equipments[EquipPart.BottomWear] = new Item.EquipNoBottom();
            equipments[EquipPart.Weapon] = new Item.EquipNoWeapon();            
        }
        public void Equip(Item.EquipItem equips)
        {
            //TODO : nullcheck, 인벤토리에서 제거, null 이 아닐 경우, 인벤토리로 낀 장비 옮기기
            equipments[equips.type] = equips;
        }
        public void UnEquip(Item.EquipItem equips)
        {
            Inventory.Add(equips);
            //TODO : nullcheck, 인벤토리에서 제거, null 이 아닐 경우, 인벤토리로 낀 장비 옮기기
            switch(equips.type)
            {
                case EquipPart.Head:
                    equipments[equips.type] = new Item.EquipNohead();
                    break;
                case EquipPart.TopWear:
                    equipments[equips.type] = new Item.EquipNoTop();
                    break;
                case EquipPart.BottomWear:
                    equipments[equips.type] = new Item.EquipNoBottom();
                    break;
                case EquipPart.Weapon:
                    equipments[equips.type] = new Item.EquipNoWeapon();
                    break;
            }
                
        }
        public int playerAttack()
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 100 + Critical);
            if (randNum > 100)
            {
                Util.Print("크리티컬!!!\n플레이어의 공격!", ConsoleColor.Red);
                return Power * 150 / 100;
            }
            else
            {
                Console.WriteLine("플레이어의 공격!");
                return Power;
            }
        }
        public void InventoryCheck()
        {
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"{Inventory[i].Name}");
            }
        }
    }
}
