using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crush : MonoBehaviour
{
    PlayerStat _playerStat;
    Stat _stat;
    BigMonStat _bigStat;

    void Start()
    {
    }

    void Update()
    {
        Transform _camera = GameObject.Find("Main Camera").transform;
        transform.Translate(_camera.GetComponent<Transform>().forward * 0.2f, Space.World);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        //GameObject go = GameObject.FindGameObjectWithTag("monster");
        _playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();

        if (SceneManager.GetActiveScene().name == "FinalStage")
        {
            _bigStat = GameObject.Find("BigMonster").GetComponent<BigMonStat>();
            _playerStat.PlayerAttack(_bigStat);
        }
        else
        {
            _stat = GameObject.Find("Monster").GetComponent<Stat>();
            _playerStat.PlayerAttack(_stat);
        }
    }
}
