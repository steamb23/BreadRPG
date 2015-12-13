using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadRPG.Scenes
{
    class MainScene : IScene
    {
        public void Run()
        {
            const char borderText = '=';
            Console.SetCursorPosition(2, 0);
            Console.Write(new string(borderText, 76));
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(28, 2);
            Console.Write("B");
            Console.SetCursorPosition(31, 2);
            Console.Write("r");
            Console.SetCursorPosition(34, 2);
            Console.Write("e");
            Console.SetCursorPosition(37, 2);
            Console.Write("a");
            Console.SetCursorPosition(40, 2);
            Console.Write("d");
            Console.SetCursorPosition(43, 2);
            Console.Write("R");
            Console.SetCursorPosition(46, 2);
            Console.Write("P");
            Console.SetCursorPosition(49, 2);
            Console.Write("G");
            Console.ResetColor();
            Console.SetCursorPosition(2, 4);
            Console.Write(new string(borderText, 76));
            Console.WriteLine();
            ConsoleEx.SelectElement('N', "새로시작");
            ConsoleEx.SelectElement('L', "불러오기");
            ConsoleEx.SelectElement('X', "종료");
            MAIN_SELECT:
            switch (ConsoleEx.Select().Key)
            {
                case ConsoleKey.N:
                    Program.SceneManager.ChangeScene(new NewGameScene());
                    return;
                case ConsoleKey.L:
                case ConsoleKey.X:
                    Program.Exit();
                    break;
                default:
                    goto MAIN_SELECT;
            }
        }
    }
}
