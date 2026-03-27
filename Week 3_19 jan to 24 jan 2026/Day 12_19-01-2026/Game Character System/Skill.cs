using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System
{
    internal class Skill
    {
        public string SkillName;
        public int Power;

        public Skill(string name, int power)
        {
            SkillName = name;
            Power = power;
        }
    }
}
