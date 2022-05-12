using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStageManager : MonoBehaviour
{
    public GameObject MonPrefab;
    public GameObject PlayerPrefab;
    int _monsterNum;

    void Start()
    {
        PlayerMake();
    }

    void Update()
    {
        MonsterMake(1);
    }

    void MonsterMake(int _monsterNum)
    {
        for (int i = 0; i < _monsterNum; i++)
        {
            if (GameObject.FindGameObjectsWithTag("monster").Length < _monsterNum)
            {
                Instantiate(MonPrefab, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
            }
        }
    }

    void PlayerMake()
    {
        Instantiate(PlayerPrefab, new Vector3(0, 0, -11), Quaternion.Euler(new Vector3(0, 0, 0)));
    }
}
