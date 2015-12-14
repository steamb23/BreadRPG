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
        enum Childhood
        {

        }
        public void Run()
        {
            Console.WriteLine("새로 게임을 시작하기 전에 먼저 영웅의 과거사를 만들어야 합니다.");
            Console.WriteLine();
            PlayerData.Initialize();
            RETRY:
            Console.WriteLine("영웅의 이름을 결정해주십시오. 반드시 한글로 써주십시오.");
            PlayerData.CurrentData.Name = ConsoleEx.ReadText(true);
            ConsoleKo.Write("영웅의 이름은 {0}[이]군요.", PlayerData.CurrentData.Name);
            ConsoleEx.ColorChange(PlayerData.CurrentData.Name, 14, ConsoleColor.Yellow);
            Console.WriteLine();
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
                    ConsoleKo.Write("{0}[은는] 남성이군요.", PlayerData.CurrentData.Name);
                    ConsoleEx.ColorChange("남성", PlayerData.CurrentData.Name.Length * 2 + 3, ConsoleColor.Cyan);
                    break;
                case ConsoleKey.F:
                    PlayerData.CurrentData.Gender = Gender.Female;
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                    ConsoleKo.Write("{0}[은는] 여성이군요.", PlayerData.CurrentData.Name);
                    ConsoleEx.ColorChange("여성", PlayerData.CurrentData.Name.Length * 2 + 3, ConsoleColor.Magenta);
                    break;
                default:
                    goto GENDER_SELECT;
            }
            Console.WriteLine();
            Console.WriteLine();

            ConsoleKo.WriteLine("유년 시절의 {0}[은는] 무엇을 하며 지냈습니까?", PlayerData.CurrentData.Name);
            ConsoleEx.SelectElement('1', "주먹을 잘 쓰는 골목 대장이었다.");
            ConsoleEx.SelectElement('2', "농부인 아버지를 따라 일을 하였다.");
            ConsoleEx.SelectElement('3', "마법사의 심부름꾼 역할을 하였다.");
            ConsoleEx.SelectElement('4', "틈만 나면 책을 읽었다.");
            ConsoleEx.SelectElement('5', "온 도시를 누비던 장난꾸러기였다.");
            switch (ConsoleEx.Select().Key)
            {
            }
        }
    }
}
