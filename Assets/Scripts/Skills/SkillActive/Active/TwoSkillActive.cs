using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ActiveSkills/Two", fileName = "Two_active")]
public class TwoSkillActive : SkillActiveSample
{
    public override void Init()
    {
        Debug.Log("Two Skill Active");
    }
}
