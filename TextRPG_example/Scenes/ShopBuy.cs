using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_example.NPC;

namespace TextRPG_example.Scenes
{
    public class ShopBuy : Scene
    {
        ShopNPC shopNPC = new ShopNPC();
        public override void Render()
        {
            Util.Print("마음껏 골라보게! 최고의 품질이라구!"); 
        }

        public override void SelectChoice()
        {
            for (int i = 0; i < shopNPC.Items.Count; i++)
            {
                Console.WriteLine($"{i+1}. {shopNPC.Items[i].Name}\t 가격 : {shopNPC.Items[i].BuyPrice}");
            }
            Console.WriteLine("3. 돌아간다");
        }
        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Util.Print($"{shopNPC.Items[0].Name}을 구매했다!");
                    break;
                case ConsoleKey.D2:
                    Game.Player.Equipments[EquipPart.Weapon] = new Item.ShortKnife();
                    Util.Print($"{shopNPC.Items[1].Name}을 구매했다!");
                    Util.Print($"{shopNPC.Items[1].}")
                    break;
                case ConsoleKey.D3:
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요");
            Console.ReadKey();
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:                    
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Shop");
                    break;
            }
        }

    }
}
