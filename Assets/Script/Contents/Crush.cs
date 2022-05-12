using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crush : MonoBehaviour
{
    Stat _stat;
    PlayerStat _playerStat;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("monster"))
        {
            _playerStat = GetComponentInParent<PlayerStat>();
            GameObject go = GameObject.FindGameObjectWithTag("monster");

            _stat = go.GetComponent<Stat>();
            _stat._hp -= _playerStat.Attack;

            if (_stat.Hp <= 0)
                _stat._hp = 0;
        }
    }
}
