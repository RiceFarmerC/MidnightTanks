using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStats : MonoBehaviour
{
    public TankData_SO TankData;
    public AttackData_OS attackData;

    #region Read from Data_SO

    public int MaxHealth
    {
        get
        {
            if (TankData != null) return TankData.maxHealth;
            else return 0;
        }
        set { TankData.maxHealth = value; }

    }

    public int CurrentHealth
    {
        get
        {
            if (TankData != null) return TankData.currentHealth;
            else return 0;
        }
        set { TankData.currentHealth = value; }

    }

    public int BaseDefence
    {
        get
        {
            if (TankData != null) return TankData.baseDefence;
            else return 0;
        }
        set { TankData.baseDefence = value; }

    }

    public int CurrentDefence
    {
        get
        {
            if (TankData != null) return TankData.currentDefence;
            else return 0;
        }
        set { TankData.currentDefence = value; }

    }

    #endregion

    #region Tank Combat

    public void TakeDamage(TankStats attacker, TankStats defender)
    {
        int damage = Mathf.Max(attacker.CurrentDamage() - defender.CurrentDefence, 0);
        CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);
        
        //TODO: update UI
    }

    private int CurrentDamage()
    {
        float coreDamage = UnityEngine.Random.Range(attackData.minDamage, attackData.maxDamage);
        return (int)coreDamage;
    }


#endregion
    
}
