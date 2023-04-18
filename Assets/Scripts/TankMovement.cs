using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float movementSpeed = 25f;
    public float rotationSpeed = 200f;
    // public bool isDead =false;
    // private TankStats tankStats;
    // private void Awake()
    // {
    //     tankStats = GetComponent<TankStats>();
    // }
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, horizontalInput * Time.deltaTime * rotationSpeed);

<<<<<<< Updated upstream
        transform.Translate(verticalInput * movementSpeed * Time.deltaTime,0, 0 );
=======
        transform.Translate(0, 0, verticalInput * movementSpeed * Time.deltaTime);

     
>>>>>>> Stashed changes
    }
}
