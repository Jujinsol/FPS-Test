using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float turnSpeed = 1.0f;
    private float xRotate = 0.0f;
    
    [SerializeField]
    GameObject _player = null;

    void LateUpdate()
    {
        MouseRotation();
        PlayerView();
    }

    void MouseRotation()
    {
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;

        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -30, 80);

        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        _player.transform.eulerAngles = transform.eulerAngles;
    }
    void PlayerView()
    {
        transform.position = _player.transform.position + new Vector3(0.0f, 0.5f, 0.0f);
    }
}
