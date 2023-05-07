using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject theBullet;
    public Transform barrelEnd;
    ReloadTimeScript timer;

    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float reload = 3f;
    
    public bool isGamePaused = false;
    // Add these lines
    public AudioClip shootingSound;
    private AudioSource audioSource;
    
    private TankStats tankStats; 
    

    private void Awake()
    {
        tankStats = GetComponent<TankStats>();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        timer = FindFirstObjectByType<ReloadTimeScript>();
    }


    private void Update ()
    {
        if (Input.GetKey (KeyCode.Mouse0))
        {
            if (isGamePaused) return;
            if (shootAble)
            {
                shootAble = false;
                timer.reloadStart = true;
                Shoot ();
                StartCoroutine (ShootingYield ());
            }
        }
    }

    IEnumerator ShootingYield ()
    {
        yield return new WaitForSeconds (reload);
        timer.reloadStart = false;
        shootAble = true;
    }
    void Shoot ()
    {
        

        var bullet = Instantiate (theBullet, barrelEnd.position, barrelEnd.rotation);
        bullet.GetComponent<Rigidbody> ().velocity = barrelEnd.transform.forward * bulletSpeed;
        
        bullet.GetComponent<ShellCollision>().attacker = tankStats;
        
        Destroy (bullet, despawnTime);

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
