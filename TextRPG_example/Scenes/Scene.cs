using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_example.NPC;
using TextRPG_example.Item;

// 씬 들이 많아질 테니 폴더로 관리
namespace TextRPG_example.Scenes
{
    // 상황마다 다 다른 상황이기에 오버라이드 함수로 구현
    public abstract class Scene
    {
        // 모든 상황에서 같은 input 변수를 쓰기 때문에 부모에서 설정
        protected ConsoleKey input;
        /// <summary>
        /// 상황 설명
        /// </summary>
        public abstract void Render();

        /// <summary>
        /// 선택지 제시
        /// </summary>
        public abstract void SelectChoice();
        /// <summary>
        /// 선택지 입력
        /// </summary>
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        /// <summary>
        /// 결과출력
        /// </summary>
        public abstract void Result();

        /// <summary>
        /// 결과 이후 다음으로 넘어가기 전에 대기 상황
        /// </summary>
        public abstract void Wait();

        /// <summary>
        /// 다음 상황으로 전환
        /// </summary>
        public abstract void Next();
    }
}
