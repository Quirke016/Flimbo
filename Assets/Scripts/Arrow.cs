using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damage;
    Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
    }
}
