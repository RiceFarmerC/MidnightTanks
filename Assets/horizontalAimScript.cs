using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class horizontalAimScript : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        // Get the position of the mouse on the screen
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Step 2: Convert mouse cursor position to world coordinates
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPosition.x, mouseScreenPosition.y, Camera.main.transform.position.y - transform.position.y));

        // Step 3: Calculate rotation angle
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        float rotationAngle = Mathf.Atan2(targetDirection.x, targetDirection.z) * Mathf.Rad2Deg;
        float rotationStep = rotationSpeed * Time.deltaTime;

        // Step 4: Rotate towards the target position
        float newAngle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, rotationAngle, rotationStep);
        // Step 4: Apply rotation to the object
        transform.rotation = Quaternion.Euler(new Vector3(-90f, 90f, rotationAngle));

    }
}
