
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauseLook : MonoBehaviour
{
    float mouseX;
    float mouseY;

    [SerializeField] private float sensitivity = 250f;
    [SerializeField] private Transform player;
    float rotation = 0.0f; 
    
    [SerializeField] private float minAngle = -90f;
    [SerializeField] private float maxAngle = 90f;

    // Update is called once per frame
    void Update()
    {
        MauseXY();
        RotationMouse();
        
        
    }

    private void RotationMouse ()
{
        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, minAngle, maxAngle);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);

        player.Rotate(Vector3.up * mouseX);

}

    private void MauseXY()
       { 
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
       }
}
