using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public Transform _firePos;
    Animation anim;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim = GetComponent<Animation>();
            Shooting();
        }
    }

    void Shooting()
    {
        anim.Play("FireAnim");
    }


}
