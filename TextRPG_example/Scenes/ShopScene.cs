using TextRPG_example.NPC;
namespace TextRPG_example.Scenes
{
    public class ShopScene : Scene
    {
        public override void Render()
        {
            Util.Print("\"그래서 뭘 원하시나?\"");
        }
        public override void SelectChoice()
        {
            Console.WriteLine("\n1. 산다\n2. 판다\n3. 대화\n4. 갈취\n5. 돌아가기\n");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    Util.Print("\"그래 이제 막 모험을 시작한 신참이구만? 앞으로도 자주 볼 수 있길 바라네!\"");
                    break;
                case ConsoleKey.D4:
                    Util.Print("\"마을에 처음왔나 보구만?\"\n");
                    break;
                case ConsoleKey.D5:
                    Util.Print("\"다음에 또 오게나~\"\n마을로 돌아갑니다.");
                    break;

            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속 하려면 아무키나 입력해주세요");
            Console.ReadKey();
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("ShopBuy");
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    Game.GameOver("상점 주인은 전직 모험가였다...");
                    break;
                case ConsoleKey.D5:
                    Game.ChangeScene("Town");
                    break;
            }
        }


    }
}
