using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondStageManager : MonoBehaviour
{
    public GameObject MonPrefab;
    public GameObject PlayerPrefab;
    int _monsterNum;

    void Start()
    {
        PlayerMake();
        MonsterMake();
    }

    void Update()
    {
        NextStage();
    }

    void MonsterMake()
    {
        GameObject go = Instantiate(MonPrefab, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
        GameObject go1 = Instantiate(MonPrefab, new Vector3(-7, 0, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
        GameObject go2 = Instantiate(MonPrefab, new Vector3(7, 0, 0), Quaternion.Euler(new Vector3(0, 180, 0)));
        GameObject go3 = Instantiate(MonPrefab, new Vector3(-3, 0, -3), Quaternion.Euler(new Vector3(0, 180, 0)));
        GameObject go4 = Instantiate(MonPrefab, new Vector3(3, 0, -3), Quaternion.Euler(new Vector3(0, 180, 0)));
        go.name = MonPrefab.name;
        go1.name = MonPrefab.name;
        go2.name = MonPrefab.name;
        go3.name = MonPrefab.name;
        go4.name = MonPrefab.name;
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
            SceneManager.LoadScene("FinalStage");
        else
            return;
    }
}
