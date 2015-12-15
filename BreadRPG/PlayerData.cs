using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreadRPG.ActorDatas;

namespace BreadRPG
{
    [Serializable]
    class PlayerData
    {
        static PlayerData currentPlayerData;
        public static PlayerData CurrentData
        {
            get
            {
                return currentPlayerData;
            }
        }
        public static void Initialize()
        {
            currentPlayerData = new PlayerData();
        }
        public string Name;
        public Gender Gender;
        public Status Status;
        public Ability Ability;
        public Born Born;
        public string Description;

        public Status MaxStatus
        {
            get
            {
                return new Status()
                {
                    Health = Ability.Strength,
                    Magicka = Ability.Inteligence,
                    Fatigue = Ability.Endurance
                };
            }
        }
    }
}
