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

        //Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        transform.Translate(0, 0, verticalInput * movementSpeed * Time.deltaTime);
    }
}
