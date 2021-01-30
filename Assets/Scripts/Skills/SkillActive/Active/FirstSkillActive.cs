using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ActiveSkills/First", fileName = "First_active")]
public class FirstSkillActive : SkillActiveSample
{
    public override void Init()
    {
        Debug.Log("First Skill Active");
    }
}
