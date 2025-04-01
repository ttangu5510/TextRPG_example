using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Item
{
    public interface IEquiptable { public void Equip(); }
    public interface IUnEquiptable { public void UnEquip(); }

    public class EquipItem : Item, IEquiptable
    {
        public EquipPart type;
        public EquipItem()
        {
            durability = 100;
        }

        public virtual void Equip()
        {

        }
        // TODO : Action 다시 배워와서 사고 팔때, 장비 탈착을 할 때 발동되게 하기
        public virtual void UnEquip()
        {

        }

        // Equip : 인벤을 불러와서, 장비를 선택하고, 장비 선택지 : 장비하기(if - 현재 장비를 입고있을경우 교체, 없으면 그냥 입기) , 설명 보기
        // Equip, UnEquip 
        // UnEquip : 장비창을 불러와서 장비를 선택하고 장비선택지 :
    }
}
