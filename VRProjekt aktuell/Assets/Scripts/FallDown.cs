using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    public Vector3 anfangsposition;
    private float distanz = 0.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        anfangsposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Vector3.zero) < distanz)
        {
            transform.position = anfangsposition;
        }
    }
}
