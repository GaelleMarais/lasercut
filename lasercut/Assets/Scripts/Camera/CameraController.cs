using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject scene;
    public float sensitivity = 0.4f;


    void Update()
    {
        MouseInput();
    }

    void MouseInput()
    {
        if (Input.GetMouseButton(1))        
            MouseRightClick();
        else if (Input.GetAxis("Mouse ScrollWheel") != 0)
            MouseWheeling();
    }

    void MouseWheeling()
    {
        Vector3 pos = transform.position;
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            pos = pos - transform.forward;
            transform.position = pos;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            pos = pos + transform.forward;
            transform.position = pos;
        }
    }

    void MouseRightClick()
    {
        float rotateVertical = Input.GetAxis("Mouse Y");      
        transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);
    }
}
