using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Scenes
{
    public class TownScene : Scene
    {
        public override void Render()
        {
            string[] text = {"마을에는 사람들이 북적거린다",
            "농민처럼 보이는 사람이 수레에 물건을 실어 나르고 있다.",
            "상인들은 물건들을 팔기 위해 열심히 호객행위를 한다.",
            "건물 사이 골목 앞에는 수상한 사람이 쳐다보고 있다.\n" };
            for (int i = 0; i < text.Length; i++)
            {
                Util.Print(text[i], ConsoleColor.White,25);
                Thread.Sleep(500);
            }
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
                    Util.Print("\n골목 앞을 지나가다 깡패들이 말을 걸어옵니다\n\"어이 꼬마야! 잠시 형들 좀 볼까?\"\n",ConsoleColor.Red,25);
                    if (Game.Player.Speed >= 10)
                    {
                        Console.WriteLine("당신은 재빠르게 골목에서 도망쳤습니다.");
                    }
                    else
                    {
                        Console.WriteLine("당신은 골목으로 끌려가 죽을때까지 맞고 모든 돈을 뺏겼습니다...");
                    }
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
                    Game.GameOver("스피드가 부족했다. 요구 스피드 : 10");
                    break;
                case ConsoleKey.D3:
                    //Game.ChangeScene("");
                    break;
            }
        }

    }
}
