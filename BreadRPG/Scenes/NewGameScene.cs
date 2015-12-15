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
            Console.WriteLine("새로 게임을 시작하기 전에 먼저 영웅의 정보에 대해서 작성을 해야합니다.");
            Console.WriteLine();
            PlayerData.Initialize();
            RETRY:
            Console.WriteLine("영웅의 이름을 결정해주십시오. 띄어쓰기를 하면 첫 글자를 제외한 나머지 글자들은 성이됩니다. 반드시 한글로 써주세요.");
            PlayerData.CurrentData.Name = ConsoleEx.ReadText(true);
            // 한글여부, 띄어쓰기 여부 체크 추가 필요.
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
                    ConsoleEx.ClearMultipleLines(2);
                    Console.Write("남성이군요.", PlayerData.CurrentData.Name);
                    ConsoleEx.ColorChange("남성", 0, ConsoleColor.Cyan);
                    break;
                case ConsoleKey.F:
                    PlayerData.CurrentData.Gender = Gender.Female;
                    ConsoleEx.ClearMultipleLines(2);
                    Console.Write("여성이군요.", PlayerData.CurrentData.Name);
                    ConsoleEx.ColorChange("여성", 0, ConsoleColor.Magenta);
                    break;
                default:
                    goto GENDER_SELECT;
            }
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("{0}의 출신을 결정해주십시오.", PlayerData.CurrentData.Name)
            if (PlayerData.CurrentData.Gender = Gender.Male)
            {
                ConsoleEx.SelectElement('1', "기사의 아들");
                ConsoleEx.SelectElement('2', "농부의 아들");
                ConsoleEx.SelectElement('3', "마법사의 조수");
                ConsoleEx.SelectElement('4', "교회의 고아");
                ConsoleEx.SelectElement('5', "사냥꾼의 아들");
            }
            else
            {
                ConsoleEx.SelectElement('1', "기사의 딸");
                ConsoleEx.SelectElement('2', "농부의 딸");
                ConsoleEx.SelectElement('3', "마법사의 조수");
                ConsoleEx.SelectElement('4', "교회의 고아");
                ConsoleEx.SelectElement('5', "사냥꾼의 딸");
            }
            BORN_SELECT:
            switch (ConsoleEx.Select().Key)
            {
                case ConsoleKey.D1:
                    PlayerData.CurrentData.Born = Born.Knight;
                    ConsoleEx.ClearMultipleLines(5);
                    if (PlayerData.CurrentData.Gender = Gender.Male)
                    {
                        Console.WriteLine("기사의 아들이군요.");
                        PlayerData.CurrentData.Description = "";
                    }
                    else
                    {
                        Console.WriteLine("기사의 딸이군요.");
                        PlayerData.CurrentData.Description = "";
                    }
                    break;
                case ConsoleKey.D2:
                    PlayerData.CurrentData.Born = Born.Farmer;
                    ConsoleEx.ClearMultipleLines(5);
                    if (PlayerData.CurrentData.Gender = Gender.Male)
                    {
                        Console.WriteLine("농부의 아들이군요.");
                        PlayerData.CurrentData.Description = "";
                    }
                    else
                    {
                        Console.WriteLine("농부의 딸이군요.");
                        PlayerData.CurrentData.Description = "";
                    }
                    break;
                case ConsoleKey.D3:
                    PlayerData.CurrentData.Born = Born.Mage;
                    ConsoleEx.ClearMultipleLines(5);
                    Console.WriteLine("마법사의 조수군요.");
                    if (PlayerData.CurrentData.Gender = Gender.Male)
                    {
                        PlayerData.CurrentData.Description = "";
                    }
                    else
                    {
                        PlayerData.CurrentData.Description = "";
                    }
                    break;
                case ConsoleKey.D4:
                    PlayerData.CurrentData.Born = Born.Priest;
                    ConsoleEx.ClearMultipleLines(5);
                    Console.WriteLine("교회의 고아군요.");
                    if (PlayerData.CurrentData.Gender = Gender.Male)
                    {
                        PlayerData.CurrentData.Description = "";
                    }
                    else
                    {
                        PlayerData.CurrentData.Description = "";
                    }
                    break;
                case ConsoleKey.D5:
                    PlayerData.CurrentData.Born = Born.Hunter;
                    ConsoleEx.ClearMultipleLines(5);
                    if (PlayerData.CurrentData.Gender = Gender.Male)
                    {
                        Console.WriteLine("사냥꾼의 아들이군요.");
                        PlayerData.CurrentData.Description = "";
                    }
                    else
                    {
                        Console.WriteLine("사냥꾼의 딸이군요.");
                        PlayerData.CurrentData.Description = "";
                    }
                    break;
                default:
                    goto BORN_SELECT;
            }
        }
    }
}
