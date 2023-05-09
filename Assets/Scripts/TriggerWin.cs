using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    public Win winScript;

    private void OnTriggerEnter(Collider other)
    {
        winScript.WinGame();
    }
}
