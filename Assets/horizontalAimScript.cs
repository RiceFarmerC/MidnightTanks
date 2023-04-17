using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class horizontalAimScript : MonoBehaviour
{
    public float rotationSpeed = 5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;

        // Step 2: Convert mouse cursor position to world coordinates
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPosition.x, mouseScreenPosition.y, Camera.main.transform.position.z));

        // Step 3: Calculate rotation angle
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        float rotationAngle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        float rotationStep = rotationSpeed * Time.deltaTime;

        // Step 4: Rotate towards the target position
        float newAngle = Mathf.MoveTowardsAngle(transform.eulerAngles.z, rotationAngle, rotationStep);
        // Step 4: Apply rotation to the object
        transform.rotation = Quaternion.Euler(new Vector3(-90f, 0f, rotationAngle));
    }
}
