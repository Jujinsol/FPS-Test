using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalStageManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject BigMonPrefab;
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
        GameObject go = Instantiate(BigMonPrefab, new Vector3(0, 0, -3), Quaternion.Euler(new Vector3(0, 180, 0)));
        go.name = BigMonPrefab.name;
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
        {
            SceneManager.LoadScene("YouWin");
        }
        else
            return;
    }
}
