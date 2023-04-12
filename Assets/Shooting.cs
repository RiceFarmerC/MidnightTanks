using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject theBullet;
    public Transform barrelEnd;

    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 20.0f;
    
    public bool isGamePaused = false;
    // Add these lines
    public AudioClip shootingSound;
    private AudioSource audioSource;

    private void Awake()
    {
        // Add this line
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }


    private void Update ()
    {
        if (Input.GetKey (KeyCode.Mouse0))
        {
            if (isGamePaused) return;
            if (shootAble)
            {
                shootAble = false;
                Shoot ();
                StartCoroutine (ShootingYield ());
            }
        }
    }

    IEnumerator ShootingYield ()
    {
        yield return new WaitForSeconds (waitBeforeNextShot);
        shootAble = true;
    }
    void Shoot ()
    {
        var bullet = Instantiate (theBullet, barrelEnd.position, barrelEnd.rotation);
        bullet.GetComponent<Rigidbody> ().velocity = -barrelEnd.transform.forward * bulletSpeed;

        Destroy (bullet, despawnTime);
        // Add this line
        PlayShootingSound();
    }
       // Add this method
    void PlayShootingSound()
    {
        if (shootingSound != null)
        {
            audioSource.PlayOneShot(shootingSound);
        }
    }
}
