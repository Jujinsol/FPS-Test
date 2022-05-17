using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public AudioClip shottingAudio;
    public GameObject bulletFactory;
    public Transform FirePos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.volume = 0.1f;
        source.PlayOneShot(shottingAudio);

        GameObject _bullet = Instantiate(bulletFactory);
        _bullet.transform.position = FirePos.position;

        Transform Rot = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _bullet.transform.rotation = Rot.transform.rotation;

        _bullet.transform.forward = Rot.forward;

        //Destroy();
    }

    private void Destroy()
    {
        GameObject clone = GameObject.Find("Fire(Clone)");
        if (clone == null)
            return;
        Destroy(clone);
    }
}
