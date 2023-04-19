using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    float fireCharge;
    public float maxCharge;
    public float chargeRate;
    public Transform spawn;
    public Rigidbody arrowObj;

    private void Update()
    {
        if (Input.GetButton("Fire1") && fireCharge < maxCharge)
        {
            fireCharge += Time.deltaTime * chargeRate;
            Debug.Log(fireCharge.ToString());
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody arrow = Instantiate(arrowObj, spawn.position, spawn.rotation) as Rigidbody;
            arrow.AddForce(spawn.forward * fireCharge, ForceMode.Impulse);
            fireCharge = 0f;
        }
    }
}
