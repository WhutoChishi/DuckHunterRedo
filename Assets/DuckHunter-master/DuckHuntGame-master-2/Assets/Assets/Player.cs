using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    // Update is called once per frame
    void Update()
    {
       

        //MOUSE LOOK

        float mouseX = Input.GetAxis("Mouse X");

        float mouseY = Input.GetAxis("Mouse Y");

        transform.rotation = Quaternion.Euler(0, mouseX * mouseSensitivity, 0) * transform.rotation;

        Camera cam = GetComponentInChildren<Camera>();

        cam.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * cam.transform.localRotation;
    }


}
/*float rotateHorizontal = Input.GetAxis("Mouse X");

float rotateVertical = Input.GetAxis("Mouse Y");

transform.Rotate(transform.up * rotateHorizontal * sensitivity);

transform.Rotate(-transform.right * rotateVertical * sensitivity);*/
