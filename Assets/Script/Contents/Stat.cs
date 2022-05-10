using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    PlayerStat _playerStat;

    [SerializeField]
    protected int _hp;
    [SerializeField]
    protected int _maxhp;
    [SerializeField]
    protected int _attack;

    public int Hp { get { return _hp; } }
    public int MaxHp { get { return _maxhp; } }
    public int Attack { get { return _attack; } }

    private void Start()
    {
        _hp = 100;
        _maxhp = 100;
        _attack = 5;
    }

    public void OnHit()
    {
    }
}
