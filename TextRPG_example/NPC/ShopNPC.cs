using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.NPC
{
    public class ShopNPC : NPC
    {
        Item.RedPotion redPotion = new Item.RedPotion();
        Item.ShortKnife shortknife = new Item.ShortKnife();
        public ShopNPC()
        {
            Name = "상점 주인";
            Items = [redPotion, shortknife ];
        }
        public override void Conversation()
        {
            Util.Print($"{Name} : ");
            Util.Print("정말 싸게 팔고 있다네! 마음껏 구경하게나!");
        }

    }
}
