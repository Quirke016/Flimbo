using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Billbord : MonoBehaviour
{
    public Camera cam;
public void Update()
    {
        transform.LookAt(cam.transform.position);
    }
}
