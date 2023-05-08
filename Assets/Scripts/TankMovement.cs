using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float movementSpeed = 25f;
    public float rotationSpeed = 200f;
    
    // public LayerMask whatIsGround;
    // void Update()
    // {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");
    //
    //     // Rotate the tank left or right
    //     transform.Rotate(0, horizontalInput * Time.deltaTime * rotationSpeed, 0);
    //
    //     // Move the tank forward or backward
    //     Vector3 movement = transform.forward * verticalInput * movementSpeed * Time.deltaTime;
    //     movement.y = -10f;  // Apply gravity
    //     transform.position += movement;
    //
    //     // Check if the tank is on the ground
    //     if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 1f, whatIsGround))
    //     {
    //         transform.position = hit.point + Vector3.up * 0.5f;  // Keep the tank slightly above the ground
    //     }
    // }
    // void Awake()
    // {
    //     // Make sure the tank is on the ground
    //     if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 10f, whatIsGround))
    //     {
    //         transform.position = hit.point + Vector3.up * 0.5f;  // Keep the tank slightly above the ground
    //     }
    // }

    void Update()
    {
    
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    
        // transform.Rotate(0, horizontalInput * Time.deltaTime * rotationSpeed, 0);
        transform.Rotate(0, 0, horizontalInput * Time.deltaTime * rotationSpeed);
    
        transform.Translate(verticalInput * movementSpeed * Time.deltaTime, 0, 0);
    
    }
}