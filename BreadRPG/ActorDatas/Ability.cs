using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadRPG.ActorDatas
{
    [Serializable]
    struct Ability
    {
        /// <summary>
        /// 근력
        /// </summary>
        /// <remarks>
        /// 체력, 근접 공격력에 영향.
        /// 체력: 1
        /// 물리 공격력: 0.1
        /// </remarks>
        public int Strength;
        /// <summary>
        /// 지구력
        /// </summary>
        /// <remarks>
        /// 체력 회복속도, 피로도에 영향.
        /// 체력 회복속도: 1
        /// 피로도: 1
        /// </remarks>
        public int Endurance;
        /// <summary>
        /// 지성
        /// </summary>
        /// <remarks>
        /// 매지카, 마법 공격력에 영향.
        /// 매지카: 1
        /// 마법 공격력: 0.1
        /// </remarks>
        public int Inteligence;
        /// <summary>
        /// 지혜
        /// </summary>
        /// <remarks>
        /// 매지카 회복속도, 전투 기회에 영향.
        /// 매지카 회복속도: 1
        /// 전투 기회: 0.1
        /// </remarks>
        public int Wisdom;
        /// <summary>
        /// 솜씨
        /// </summary>
        /// <remarks>
        /// 회피 확률, 약점 타격 확률에 영향.
        /// 회피 확률: 0.1
        /// 약점 타격 확률: 0.1
        /// </remarks>
        public int Dexterity;
    }
}
