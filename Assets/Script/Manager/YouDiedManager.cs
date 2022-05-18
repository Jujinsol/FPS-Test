using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDiedManager : MonoBehaviour
{
    public GameObject _play;
    public GameObject _exit;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {

    }
    public void Play()
    {
        SceneManager.LoadScene("FirstStage");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
