using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Ball : MonoBehaviour
{
    
    private Material mat;
    private Rigidbody body;
    private ResetScript reset;

    // Start is called before the first frame update
    void Awake()
    {
        mat = GetComponent<Renderer>().material;
        body = GetComponent<Rigidbody>();
        reset = GetComponent<ResetScript>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void changeForGoal() {
        mat.color = new Color(1.0f, 1.0f, 1.0f);
        body.constraints = RigidbodyConstraints.None;
        reset.useTag = false;
    }
}
