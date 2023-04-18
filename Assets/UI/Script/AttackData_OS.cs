using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Attack", menuName = "Attack/Attack Data")]
public class AttackData_OS : ScriptableObject
{
    public int minDamage;
    public int maxDamage;
    // needed if have any skill that need cool down
    // public int coolDown;
}
