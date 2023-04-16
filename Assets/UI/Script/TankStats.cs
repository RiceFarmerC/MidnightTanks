using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStats : MonoBehaviour
{
    public TankData_SO TankData;

    #region Read from Data_SO
    public int MaxHealth
    {
        get{ if (TankData != null) return TankData.maxHealth; else return 0; }
        set{ TankData.maxHealth = value; }
        
    }
       public int CurrentHealth
    {
        get{ if (TankData != null) return TankData.currentHealth; else return 0; }
        set{ TankData.maxHealth = value; }
        
    }
    public int BaseDefence
    {
        get{ if (TankData != null) return TankData.baseDefence; else return 0; }
        set{ TankData.maxHealth = value; }
        
    }
    public int CurrentDefence
    {
        get{ if (TankData != null) return TankData.currentDefence; else return 0; }
        set{ TankData.maxHealth = value; }
        
    }
    #endregion
    
}
