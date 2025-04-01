using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Item
{
    public interface IEquiptable { public void Equip(); }
    public interface IUnEquiptable { public void UnEquip(); }

    public abstract class EquipItem : Item, IEquiptable
    {
        protected int power;
        public int Power
        {
            get { return power; }
            set { power = value; } 
        }
        protected int defence;
        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }
        protected int durability;
        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }
        public EquipItem()
        {
            power = 0;
            defence = 0;
            durability = 100;
        }

        public abstract void Equip();
        // TODO : Action 다시 배워와서 사고 팔때, 장비 탈착을 할 때 발동되게 하기
        public abstract void UnEquip();
    }
}
