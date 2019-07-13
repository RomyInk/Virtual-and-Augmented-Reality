using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField]
    string strTag;
    public Vector3 anfangsposition;

    private Rigidbody thisBody;

    private void Awake()
    {
        thisBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag) {
            transform.localPosition = anfangsposition;
            thisBody.angularVelocity = Vector3.zero;
            thisBody.velocity = Vector3.zero;
        }
    }
}
