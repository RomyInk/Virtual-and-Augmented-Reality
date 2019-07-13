using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceStuff : MonoBehaviour
{

    public string bounceTag;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(bounceTag))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, body.velocity, out hit, 1))
            {
                body.velocity = Vector3.Reflect(body.velocity, hit.normal);
            }
        }

       
    }
}
