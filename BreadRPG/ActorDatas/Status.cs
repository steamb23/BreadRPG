using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadRPG.ActorDatas
{
    [Serializable]
    struct Status
    {
        /// <summary>
        /// 체력
        /// </summary>
        public int Health;
        /// <summary>
        /// 매지카
        /// </summary>
        public int Magicka;
        /// <summary>
        /// 피로도
        /// </summary>
        /// <remarks>
        /// 최대치에 도달하면 쓰러짐.
        /// </remarks>
        public int Fatigue;
    }
}
