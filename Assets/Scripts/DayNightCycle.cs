using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Transform Sun;
    public float sunCycleSpeed = 0.002f;


    // Update is called once per frame
    void Update()
    {
        Sun.transform.Rotate(sunCycleSpeed, 0, 0);
    }
}
