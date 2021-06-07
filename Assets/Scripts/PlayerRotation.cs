using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Mouse X");
        float yAxis = Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(0,xAxis,0)*transform.rotation;
        Camera cam = GetComponentInChildren<Camera>();
        cam.transform.localRotation = Quaternion.Euler(-yAxis, 0, 0) * cam.transform.localRotation;
    }
}
