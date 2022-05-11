using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    public AudioClip shottingAudio;
    public GameObject bullet;
    public AnimationClip shootingAnim;

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

        Instantiate(bullet);
        Animation shotAnim = bullet.GetComponentInChildren<Animation>();
        shotAnim.Play();

        Destroy();
    }

    private void Destroy()
    {
        GameObject clone = GameObject.Find("Fire(Clone)");
        if (clone == null)
            return;
        Destroy(clone, 0.2f);
    }
}
