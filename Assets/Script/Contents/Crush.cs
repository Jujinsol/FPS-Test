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
        Transform _camera = GameObject.Find("Main Camera").transform;
        transform.Translate(_camera.GetComponent<Transform>().forward * 0.2f, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("monster"))
        {
            GameObject go = GameObject.FindGameObjectWithTag("monster");
            _stat = go.GetComponent<Stat>();
            _playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();

            _playerStat.PlayerAttack(_stat);
        }
    }
}
