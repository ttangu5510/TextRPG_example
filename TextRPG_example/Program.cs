namespace TextRPG_example
{

    // 게임 만들기 순서
    // 1. 깃 - 백업은 숨쉬는거다
    // 2. 간이 기획 - 어떤 게임을 만들지, 시스템은 어떻게 해야될지
    // 3. 프로젝트 구조 전체적인 설계  - 객체지향은 설계가 필요하다
    //  - Text RPG

    public class Program
    {
        static void Main(string[] args)
        {
            Game.Start();
            Game.Run();
            Game.End();
        }
    }
}
