using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/ParamsSample", fileName = "ParamsSample")]
public class SkillsAsset : SkillsParamsSample
{
    public override AllParams UseSkill()
    {
        var param = new AllParams()
        {
            healthBuff = this.healthBuff,
            attackBuff = this.attackBuff,
            speedBuff = this.speedBuff,
            buffDelay = this.buffDelay
        };

        _skillActive.Init();

        return param;
    }
}
