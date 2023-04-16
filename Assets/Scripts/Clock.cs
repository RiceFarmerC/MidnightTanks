using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Text clock;
    private float timer = 0.0f;
    private bool isTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        isTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            timer = timer + Time.deltaTime;
            DisplayTime();
        }
    }

    void DisplayTime()
    {
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        clock.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
