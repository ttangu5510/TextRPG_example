using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Item
{
    public class ShortKnife : EquipItem
    {

        public ShortKnife()
        {
            Power = 10;
            Name = "단검";
            BuyPrice = 500;
            SellPrice = 200;
            type = EquipPart.Weapon;
        }
    }
}
