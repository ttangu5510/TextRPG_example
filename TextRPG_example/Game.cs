using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example
{
    // 게임을 스테틱으로 구성
    // 스테틱은 인스턴스 생성이 안된다
    public static class Game
    {
        // 게임에 필요한 정보들
        // 1. 상황들
        // 2. 인벤토리
        // 3. 플레이어
        // 4. 몬스터
        private static bool gameOver;
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;
        // 게임에 필요한 기능들
        // 1. 게임시작
        public static void Start()
        {
            // 게임 시작 시에 필요한 작업들
            // 1. 게임 설정
            // 딕셔너리로 씬들 저장하고 관리
            // 자주 추가 삭제 하지 않기 때문에, 적합함
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());  
            sceneDic.Add("Shop", new ShopScene());

            // 첫 씬
            // 딕셔너리 인덱서로 접근
            curScene = sceneDic["Title"];
        }
        // 2. 게임종료
        public static void End()
        {
            // 게임 종료시에 필요한 작업들
        }
        // 3. 게임동작
        public static void Run()
        {
            // 게임 동작시에 필요한 작업들
            while(gameOver == false)
            {
                Console.Clear();

                curScene.Render();
                curScene.SelectChoice();
                curScene.Input();
                curScene.Result();
                curScene.Wait();
                curScene.Next();
            }
        }
        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*         Game Over         *");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine($"이유 : {reason}");
            gameOver = true;
        }
    }
}
