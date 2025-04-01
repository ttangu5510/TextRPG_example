namespace TextRPG_example
{
    public class ShopScene : Scene
    {
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D5:
                    Game.ChangeScene("Town");
                    break;
            }
        }

        public override void Render()
        {
            Console.WriteLine("\"그래서 뭘 원하시나?\"");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D5:
                    Console.WriteLine("\"다음에 또 오게나~\"\n마을로 돌아갑니다.");
                    break;

            }
        }

        public override void SelectChoice()
        {
            Console.WriteLine("\n1. 사기\n2. 팔기\n3. 대화\n4. 갈취\n5. 돌아가기\n");
        }

        public override void Wait()
        {
        }
    }
}
