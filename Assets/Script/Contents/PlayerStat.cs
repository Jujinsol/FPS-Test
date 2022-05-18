using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStat : Stat
{

    private void Start()
    {
        _hp = 200;
        _maxhp = 200;
        _attack = 20;
    }

    private void Update()
    {
        if (_hp <= 0)
            SceneManager.LoadScene("YouDied");
    }

    public void PlayerAttack(Stat victim)
    {
        victim._hp -= _attack;

        if (victim._hp <= 0)
            victim._hp = 0;
    }
}
