using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public bool gameEnded;

    public void WinGame() {
        if(!gameEnded){
            gameEnded=true;
        }
        
    }
}
