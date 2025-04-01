using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("마을에는 사람들이 북적거린다" +
                "\n마을 주민들이 수레에 물건들이 싣고나르고 있다.\n상인들은 물건들을 팔기 위해 열심히 호객행위를 한다." +
                "\n 건물 사이 골목 앞에는 수상한 사람이 쳐다보고 있다.\n");
            
        }

        public override void SelectChoice()
        {
            Console.WriteLine("1. 상인에게 호객당한다");
            Console.WriteLine("2. 골목 앞을 지나간다");
            Console.WriteLine("3. 구경은 끝났으니 사냥하러 나간다");
        }

        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n\"어서오시게! 뭐든지 다 있다네!\"\n당신은 상인을 찾았다\n");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\n골목 앞을 지나가다 깡패들이 말을 걸어옵니다\"어이 꼬마야! 잠시 형들 좀 볼까?\"\n");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\n마을 밖 사냥터로 나갑니다.\n");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.\n");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무 키나 입력해주세요");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    //Game.ChangeScene("");
                    break;
                case ConsoleKey.D3:
                    //Game.ChangeScene("");
                    break;
            }
        }

    }
}
