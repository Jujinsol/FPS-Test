using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBarController : MonoBehaviour
{
    PlayerStat _playerStat;

    void Start()
    {
        
    }

    void Update()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        _playerStat = go.GetComponent<PlayerStat>();
        float ratio = (float)_playerStat.Hp / (float)_playerStat.MaxHp;
        SetValue(ratio);
    }

    public void SetValue(float ratio)
    {
        transform.GetComponent<Slider>().value = ratio;
    }
}
