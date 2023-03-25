using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPos : MonoBehaviour
{
    //keeps track of what the gun holder is
    public Transform gunPos;
    public Transform orient;

    float xRot;
    float yRot;
    private void Update()
    {
        //moves the cam position to the alocated spot
        transform.position = gunPos.position;

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime;

        yRot += mouseX;
        xRot -= mouseY;

        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        orient.rotation = Quaternion.Euler(0, yRot, 0);
    }
}

