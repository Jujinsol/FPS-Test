using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float _speed = 7.0f;


    void Start()
    {
        
    }

    void LateUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.right * h + Vector3.forward * v;
        dir = Camera.main.transform.TransformDirection(dir);
        dir.Normalize();

        transform.position += dir * _speed * Time.deltaTime;
    }
}
