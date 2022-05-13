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
        //transform.Translate(Vector3.forward * 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("monster"))
        {
            GameObject go = GameObject.FindGameObjectWithTag("monster");
            _stat = go.GetComponent<Stat>();
            _playerStat = gameObject.GetComponentInParent<PlayerStat>();

            _playerStat.PlayerAttack(_stat);
        }
    }
}
