using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstStageManager : MonoBehaviour
{
    public GameObject MonPrefab;
    public GameObject PlayerPrefab;
    int _monsterNum;
    PlayerStat _playerStat;

    void Start()
    {
        PlayerMake();
        MonsterMake(1);
        _playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();
        _playerStat._hp = 200;
    }

    void Update()
    {
        NextStage();
    }

    void MonsterMake(int num)
    {
        GameObject go = Instantiate(MonPrefab, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
        go.name = MonPrefab.name;
    }

    void PlayerMake()
    {
        GameObject go = Instantiate(PlayerPrefab, new Vector3(0, 0, -11), Quaternion.Euler(new Vector3(0, 0, 0)));
        go.name = PlayerPrefab.name;
        Camera.main.gameObject.GetComponent<CameraController>().SetPlayer(go);
    }

    void NextStage()
    {
        _monsterNum = GameObject.FindGameObjectsWithTag("monster").Length;
        if (_monsterNum == 0)
            SceneManager.LoadScene("SecondStage");
        else
            return;
    }
}
