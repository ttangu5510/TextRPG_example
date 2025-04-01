using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 씬 들이 많아질 테니 폴더로 관리
namespace TextRPG_example.Scenes
{
    // 상황마다 다 다른 상황이기에 오버라이드 함수로 구현
    public abstract class Scene
    {
        // 모든 상황에서 같은 input 변수를 쓰기 때문에 부모에서 설정
        protected ConsoleKey input;
        // 상황 설명
        public abstract void Render();

        //선택지 제시
        public abstract void SelectChoice();
        //선택지 입력
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        // 결과출력
        public abstract void Result();

        //다음으로 넘어가기
        public abstract void Wait();

        //다음 상황으로 전환
        public abstract void Next();
    }
}
