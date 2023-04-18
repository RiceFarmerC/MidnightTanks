using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{

     // public GameObject playerHealthUIPrefeb;
     public TankStats tankStats;
     
     Image healthSlider;
     
     void Awake()
     {
         // tankStats = GetComponent<TankStats>();
         healthSlider = transform.GetChild(0).GetChild(0).GetComponent<Image>();
     }
     
     void Update()
     {
        UpdateHealth();
     }
     
     void UpdateHealth()
     {
         Debug.Log("Player Health UI "+tankStats);
         float sliderPercent = (float)tankStats.CurrentHealth / tankStats.MaxHealth;
         healthSlider.fillAmount = sliderPercent;
     }
}
