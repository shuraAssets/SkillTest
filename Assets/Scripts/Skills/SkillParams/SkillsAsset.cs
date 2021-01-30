using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/ParamsSample", fileName = "ParamsSample")]
public class SkillsAsset : SkillsParamsSample
{
    public override AllParams UseSkill()
    {
        var param = new AllParams();
        param.healthBuff = healthBuff;
        param.attackBuff = attackBuff;
        param.speedBuff = speedBuff;
        param.buffDelay = buffDelay;

        _skillActive.Init();

        return param;
    }
}
