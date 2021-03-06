﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BreadRPG.Scenes;

namespace BreadRPG
{
    class Program
    {
        public static SceneManager SceneManager
        {
            get
            {
                return sceneManager;
            }
        }
        public static bool IsExit
        {
            get
            {
                return isExit;
            }
        }
        static bool isExit=false;
        static SceneManager sceneManager;
        static void Main(string[] args)
        {
            Console.Title = "BreadRPG";
            Console.WindowWidth = 80;
            Console.WindowHeight = 30;
            Console.Clear();
            sceneManager = new SceneManager(new MainScene());
            
            while (!IsExit)
            {
                Thread.Sleep(100);
            }
        }
        public static void Exit()
        {
            isExit = true;
            Console.WriteLine();
            Console.WriteLine("종료중입니다.");
        }
    }
}
