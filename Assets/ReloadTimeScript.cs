using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadTimeScript : MonoBehaviour
{
    public Text reloadText;
    private float reload;
    public bool reloadStart = false;
    Shooting time;

    // Start is called before the first frame update
    void Start()
    {
        time = FindObjectOfType<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        if (reloadStart == false)
        {
            reload = time.reload;
            reloadText.color = Color.green;
            reloadText.text = reload.ToString("F2");
        }
        else
        {
            reload = reload - Time.deltaTime;
            reloadText.color = Color.red;
            reloadText.text = reload.ToString("F2");
        }
    }
}
