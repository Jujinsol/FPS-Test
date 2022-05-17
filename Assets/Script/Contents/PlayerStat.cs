using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : Stat
{
    private void Start()
    {
        _hp = 200;
        _maxhp = 200;
        _attack = 20;
    }

    public void PlayerAttack(Stat victim)
    {
        victim._hp -= _attack;

        if (victim._hp <= 0)
            victim._hp = 0;
    }
}
