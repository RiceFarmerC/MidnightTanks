using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float movementSpeed = 25f;
    public float rotationSpeed = 200f;

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontalInput * Time.deltaTime * rotationSpeed, 0);

        transform.Translate(verticalInput * movementSpeed * Time.deltaTime, 0, 0);

     
    }
}
