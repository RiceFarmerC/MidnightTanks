using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHPUI : MonoBehaviour
{
    public TankStats bossStats;
    public GameObject healthBarPrefab;
    public float visibleTime;

    private Image healthSlider;
    private float timeLeft;

    void Start()
    {
        bossStats.CurrentHealth = bossStats.MaxHealth;

        // 实例化生命值条 GameObject，并将其设置为敌人的子对象
        var healthBarObj = Instantiate(healthBarPrefab, transform);
        healthSlider = healthBarObj.transform.GetChild(0).GetComponent<Image>();

        // 将敌人的 TankStats 组件分配给生命值条的 BossHPUI 脚本
        var bossHealthUI = healthBarObj.GetComponent<BossHPUI>();
        bossHealthUI.bossStats = bossStats;

        // 隐藏生命值条
        healthBarObj.SetActive(false);
    }

    void UpdateHealth(int currentHealth, int maxHealth)
    {
        float sliderPercent = (float)currentHealth / maxHealth;
        healthSlider.fillAmount = sliderPercent;

        // 显示生命值条
        timeLeft = visibleTime;
        healthSlider.transform.parent.gameObject.SetActive(true);
    }

    void UpdateVisibleTime()
    {
        // 隐藏生命值条
        healthSlider.transform.parent.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        bossStats.UpdateHealthBarOnAttack += UpdateHealth;
    }

    void OnDisable()
    {
        bossStats.UpdateHealthBarOnAttack -= UpdateHealth;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                UpdateVisibleTime();
            }
        }
    }
}