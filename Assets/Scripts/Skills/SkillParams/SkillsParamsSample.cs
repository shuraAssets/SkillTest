using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillsParamsSample : ScriptableObject
{
    public float buffDelay;

    public int healthBuff;
    public int attackBuff;
    public int speedBuff;

    public SkillActiveSample _skillActive;

    public abstract AllParams UseSkill();
}
