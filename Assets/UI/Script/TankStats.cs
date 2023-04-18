using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStats : MonoBehaviour
{
    public event Action<int, int> UpdateHealthBarOnAttack; 
    public TankData_SO tankData;
    public AttackData_OS attackData;

    #region Read from Data_SO

    public int MaxHealth
    {
        get
        {
            if (tankData != null) return tankData.maxHealth;
            else return 0;
        }
        set { tankData.maxHealth = value; }

    }

    public int CurrentHealth
    {
        get
        {
            if (tankData != null) return tankData.currentHealth;
            else return 0;
        }
        set { tankData.currentHealth = value; }

    }

    public int BaseDefence
    {
        get
        {
            if (tankData != null) return tankData.baseDefence;
            else return 0;
        }
        set { tankData.baseDefence = value; }

    }

    public int CurrentDefence
    {
        get
        {
            if (tankData != null) return tankData.currentDefence;
            else return 0;
        }
        set { tankData.currentDefence = value; }

    }

    #endregion

    #region Tank Combat

    public void TakeDamage(TankStats attacker, TankStats defender)
    {
        int damage = Mathf.Max(attacker.CurrentDamage() - defender.CurrentDefence, 0);
        CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);
        
        //TODO: update UI
        UpdateHealthBarOnAttack?.Invoke(CurrentHealth, MaxHealth);
    }

    private int CurrentDamage()
    {
        float coreDamage = UnityEngine.Random.Range(attackData.minDamage, attackData.maxDamage);
        return (int)coreDamage;
    }


#endregion
    
}
