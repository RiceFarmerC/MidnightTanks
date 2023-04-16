using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("you quit the game");
    }
}
