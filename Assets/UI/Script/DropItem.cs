using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public enum ItemType
    {
        Health,
        Attack, // exp
        Defense //exp
    }
    public ItemType itemType;
    // public int value = 5;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger drop item");
        if (other.CompareTag("Player"))
        {
            TankStats tankStats = other.GetComponent<TankStats>();

            if (tankStats != null)
            {
                switch (itemType)
                {
                    case ItemType.Health:
                        int healthToAdd = UnityEngine.Random.Range(10, 21); 
                        tankStats.CurrentHealth += healthToAdd;
                        break;
                    case ItemType.Attack:
                        // tankStats.Attack += value;
                        break;
                    case ItemType.Defense:
                        // tankStats.Defense += value;
                        break;
                }

                Destroy(gameObject);
            }
        }
    }
}
