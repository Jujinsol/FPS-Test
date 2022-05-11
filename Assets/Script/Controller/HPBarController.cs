using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour
{
    Stat _stat;

    void Start()
    {

    }

    void Update()
    {
        Transform parent = transform.parent;
        transform.position = parent.position + Vector3.up * (transform.parent.GetComponent<BoxCollider>().bounds.size.y);

        _stat = GetComponentInParent<Stat>();
        float ratio = (float)_stat.Hp / (float)_stat.MaxHp;
        SetValue(ratio);
    }

    public void SetValue(float ratio)
    {
        transform.GetComponentInChildren<Slider>().value = ratio;
    }    
}
