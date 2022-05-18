using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigMonStat : Stat
{
    void Start()
    {
        _hp = 300;
        _maxhp = 300;
        _attack = 50;
    }

    void Update()
    {
        if (_hp <= 0)
            IsDead = true;
    }
    public void BigMonAttack(Stat victim)
    {
        victim._hp -= _attack;

        if (victim._hp <= 0)
            victim._hp = 0;
    }
}
