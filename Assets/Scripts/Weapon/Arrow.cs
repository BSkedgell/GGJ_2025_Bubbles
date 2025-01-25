using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider bx;
    bool disableRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bx = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.linearVelocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
        disableRotation = true;
        rb.isKinematic = true;
        bx.isTrigger = true;
        }
    }


}
