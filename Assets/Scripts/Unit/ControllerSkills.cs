using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSkills : MonoBehaviour
{
    [SerializeField] private int _maxHelath;
    [SerializeField] private int _maxAttack;
    [SerializeField] private int _maxSpeed;

    private float _buffDelay = 0;

    [SerializeField] private SkillsParamsSample[] _skills;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            var param = _skills[0].UseSkill();

            _maxHelath += param.healthBuff;
            _maxAttack += param.attackBuff;
            _maxSpeed += param.speedBuff;
            _buffDelay = param.buffDelay;


            StartCoroutine(ResetBuff(param.healthBuff, param.attackBuff, param.speedBuff));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var param = _skills[1].UseSkill();

            _maxHelath += param.healthBuff;
            _maxAttack += param.attackBuff;
            _maxSpeed += param.speedBuff;
            _buffDelay = param.buffDelay;

            StartCoroutine(ResetBuff(param.healthBuff, param.attackBuff, param.speedBuff));
        }

    }

    private IEnumerator ResetBuff(int a, int b, int c)
    {
        yield return new WaitForSeconds(_buffDelay);

        _maxHelath -= a;
        _maxAttack -= b;
        _maxSpeed -= c;

        Debug.Log("reset");
    }


}
