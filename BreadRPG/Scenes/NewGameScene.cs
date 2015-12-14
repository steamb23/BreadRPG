using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreadRPG.ActorDatas;

namespace BreadRPG.Scenes
{
    class NewGameScene : IScene
    {
        public void Run()
        {
            Console.WriteLine("새로 게임을 시작하기 전에 먼저 영웅의 과거사를 만들어야 합니다.");
            Console.WriteLine();
            PlayerData.Initialize();
            RETRY:
            Console.WriteLine("영웅의 이름을 결정해주십시오. 가급적이면 한글로 써주십시오.");
            PlayerData.CurrentData.Name = ConsoleEx.ReadText(true);
            Console.Write("영웅의 이름은 {0}[이]군요.", PlayerData.CurrentData.Name);
            ConsoleEx.ColorChange(PlayerData.CurrentData.Name, 14, ConsoleColor.Yellow);
            Console.WriteLine();

            Console.WriteLine("그렇다면 {0}의 성별은 무엇입니까?", PlayerData.CurrentData.Name);
            ConsoleEx.SelectElement('M', "남자");
            ConsoleEx.SelectElement('F', "여자");
            GENDER_SELECT:
            switch (ConsoleEx.Select().Key)
            {
                case ConsoleKey.M:
                    PlayerData.CurrentData.Gender = Gender.Male;
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                    ConsoleKo.WriteLine("{0}[은는] 남성이군요.", PlayerData.CurrentData.Name);
                    break;
                case ConsoleKey.F:
                    PlayerData.CurrentData.Gender = Gender.Female;
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                    ConsoleKo.WriteLine("{0}[은는] 여성이군요.", PlayerData.CurrentData.Name);
                    break;
                default:
                    goto GENDER_SELECT;
            }
            
        }
    }
}
