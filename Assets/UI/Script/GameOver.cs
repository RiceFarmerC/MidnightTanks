using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public TankStats tankStats;
    public GameObject gameOverMenu;
    public bool isDead;
    public Shooting Shooting;

    // public TankMovement TankMovement;
    // private void Awake()
    // {
    //     tankStats = GameObject.Find("PlayTank").GetComponent<TankStats>();
    // }

    void Update()
    {
        if (tankStats.CurrentHealth == 0)
        {
             tankStats.CurrentHealth = 100;
             
             GameOver1();
        }
           
    }
    
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        
    }
    
    public void Restart()
    {
        // tankStats.CurrentHealth == 100;
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
        
    }
    
    private void GameOver1()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        isDead = true;
        Shooting.isGamePaused = true;

    }
}
