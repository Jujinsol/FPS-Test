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
        _bullet.transform.forward = FirePos.forward;

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
