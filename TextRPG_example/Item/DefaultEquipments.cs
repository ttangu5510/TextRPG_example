using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Item
{
    public class EquipNohead : EquipItem
    {
        public EquipNohead() 
        {
            Name = "없음";
            Description = $"머리가 점점 빠진다..";           
            ItemNumber = 1;
            ItemId = 101;
        }
        public override void Equip()
        {
            throw new NotImplementedException();
        }

        public override void UnEquip()
        {
            throw new NotImplementedException();
        }
    }
    public class EquipNoWeapon : EquipItem
    {
        public EquipNoWeapon()
        {
            Name = "맨 손";
            Description = $"보드란 맨손";
            ItemNumber = 1;
            ItemId = 102;
        }
        public override void Equip()
        {
            throw new NotImplementedException();
        }

        public override void UnEquip()
        {
            throw new NotImplementedException();
        }
    }
    public class EquipNoTop : EquipItem
    {
        public EquipNoTop()
        {
            Name = "구멍뚫린 셔츠";
            Description = $"땀에 젖으면 안쪽이 살짝 보인다";
            ItemNumber = 1;
            ItemId = 103;
            defence = 1;
        }
        public override void Equip()
        {
            throw new NotImplementedException();
        }

        public override void UnEquip()
        {
            throw new NotImplementedException();
        }
    }
    public class EquipNoBottom : EquipItem
    {
        public EquipNoBottom()
        {
            Name = "헌 바지";
            Description = $"낡아빠진 바지다";
            ItemNumber = 1;
            ItemId = 104;
            defence = 1;
        }    
        public override void Equip()
        {
            throw new NotImplementedException();
        }

        public override void UnEquip()
        {
            throw new NotImplementedException();
        }
    }

}
