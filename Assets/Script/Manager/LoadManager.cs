using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("FirstStage");
    }

    public void Exit()
    {
        Application.Quit(); 
    }
}
