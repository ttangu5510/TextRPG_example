using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_example.Scenes
{
    // TODO : 전투 필드 구현필요
    public class Field : Scene
    {
        public override void Render()
        {
            Random rand = new Random();
            int randCase = rand.Next(1, 6);
            switch(randCase)
            {

                case 1:
                    // TODO : 퀘스트 구현
                    Util.Print("마을 밖을 나서자 경비병이 불러 세운다");
                    Util.Print("\"혹시 마을 밖으로 나갈 예정인가요? 모험가처럼 보이시는데, 부탁 하나 드려도 되겠습니까?\"");
                    Console.WriteLine("[경비병의 부탁]\n1. 수락\n2. 거절");
                    
                    break;
                default:
                Util.Print("마을 밖으로 나왔다. 어디로 갈까?");
                    break;
            }
        }
        public override void SelectChoice()
        {
            Console.WriteLine("");
        }
        public override void Result()
        {
            throw new NotImplementedException();
        }
        public override void Wait()
        {
            throw new NotImplementedException();
        }
        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
}
