using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skills
{
    public abstract class Skill : MonoBehaviour, ICastingSkill
    {
        public abstract void Excute(); // ���ܴ������
        public abstract void Cancel(); // ȡ������
        public abstract void Indicate(); // ��Χָʾ
    }
}
