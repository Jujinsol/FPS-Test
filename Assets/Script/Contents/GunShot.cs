using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public AudioClip shottingAudio;
    public GameObject bullet;
    public Transform FirePos;
    public GameObject Player;

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

        Vector3 _bulletPos = Player.transform.position + FirePos.transform.position;

        Instantiate(bullet, _bulletPos, Player.transform.rotation);
        Debug.Log(Player.transform.rotation);

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
