using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example
{
    public class TitleScene : Scene
    {

        public override void Next()
        {
            // TODO 주석 - 할 일 목록으로 추가됨
            // 보기 - 작업 목록 을 보면 알 수 있음
            // TODO : 다음 씬으로 전환 구현 필요
        }

        public override void Render()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*           TxeTexT         *");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void SelectChoice()
        {
            Console.WriteLine(" 1. 시작");
            Console.WriteLine(" 2. 불러오기");
            Console.WriteLine(" 3. 종료");
        }

        public override void Wait() { }
    }
}
