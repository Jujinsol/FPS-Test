using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonoBehaviour
{
    PlayerStat _playerStat;
    Stat _stat;

    void Init()
    {
        StartCoroutine("Attack", 1.0f);
    }


    IEnumerator Attack(float time)
    {
        yield return new WaitForSeconds(time);

        _playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();
        _stat = GameObject.Find("Monster").GetComponent<Stat>();

        _stat.MonsterAttack(_playerStat);
    }
}
