using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skills
{
    public abstract class Skill : MonoBehaviour, ICastingSkill
    {
        public abstract void Excute(); // 技能触发入口
        public abstract void Cancel(); // 取消技能
        public abstract void Indicate(); // 范围指示
    }
}
