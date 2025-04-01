namespace TextRPG_example
{
    public enum EquipPart { Head, TopWear, BottomWear, Weapon }
    public class Equipments
    {
        private Item.Item head;
        private Item.Item topWear;
        private Item.Item bottomWear;
        private Item.Item weapon;

        public Item.Item this[EquipPart part]
        {
            get
            {
                switch (part)
                {
                    case EquipPart.Head: 
                        return head;
                    case EquipPart.TopWear: 
                        return topWear;
                    case EquipPart.BottomWear: 
                        return bottomWear;
                    case EquipPart.Weapon: 
                        return weapon;
                    default:
                        return null;
                }
            }
            set
            {
                switch (part)
                {
                    case EquipPart.Head:
                        head = value;
                        break;
                    case EquipPart.TopWear:
                        topWear = value;
                        break;
                    case EquipPart.BottomWear:
                        bottomWear = value;
                        break;
                    case EquipPart.Weapon:
                        weapon = value;
                        break;
                }
            }
        }
    }
}
