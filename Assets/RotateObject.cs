using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{ 
    private void OnMouseDrag()
    {
        float y = Input.GetAxis("Mouse Y");
        float x = Input.GetAxis("Mouse X");
        float  speed = 5 ;
        gameObject.transform.Rotate(x * speed, y * speed, 0);
    }
}
