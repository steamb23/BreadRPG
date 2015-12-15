using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteamB23.KoreanUtility.Grammar;

namespace BreadRPG
{
    static class ConsoleEx
    {
        public static void SelectElement(char selectChar, string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(selectChar);
            Console.ResetColor();
            Console.WriteLine("){0}", text);
        }
        public static ConsoleKeyInfo Select()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(">");
            Console.ResetColor();
            var result = Console.ReadKey(true);
            ClearLine();
            return result;
        }
        public static void ClearMultipleLines(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                ConsoleEx.CursorUp();
                ConsoleEx.ClearLine();
            }
        }
        public static string ReadText(bool clear)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(">");
            Console.ResetColor();
            var result = Console.ReadLine();
            if (clear)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearLine();
            }
            return result;
        }
        public static string ReadText()
        {
            return ReadText(true);
        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', 80));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public static void CursorUp()
        {
            Console.CursorTop--;
        }
        public static void ColorChange(string text, int left, ConsoleColor color)
        {
            Console.SetCursorPosition(left, Console.CursorTop);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
    static class ConsoleKo
    {
        public static void Write(string text)
        {
            Console.Write(조사.문자처리(text));
        }
        public static void Write(string text, params object[] args)
        {
            Console.Write(조사.문자처리(text, args));
        }
        public static void WriteLine(string text)
        {
            Console.WriteLine(조사.문자처리(text));
        }
        public static void WriteLine(string text, params object[] args)
        {
            Console.WriteLine(조사.문자처리(text, args));
        }
    }
}
