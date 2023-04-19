using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // The thing being rotated
    public Transform thing;

    // Update is called once per frame
    void Update()
    {
        thing.transform.Rotate(0, 0.9f * Time.deltaTime, 0);
    }
}
