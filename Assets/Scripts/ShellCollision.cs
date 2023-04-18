using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ShellCollision : MonoBehaviour
{
    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("tank"))
    //     {
    //         Debug.Log("Bullet hit the target!");
    //         Destroy(gameObject);
    //     }
    //     
    // }
    
    public TankStats attacker;
    private void OnCollisionEnter(Collision collision)
    {
        var target = collision.gameObject.GetComponent<TankStats>();
        if (target != null)
        {
            Debug.Log("hit");
            Debug.Log("attack " + target);
            Debug.Log("Attacker " + attacker);
            target.TakeDamage(attacker, target);
        }

        Destroy(gameObject);
    }
    
}
