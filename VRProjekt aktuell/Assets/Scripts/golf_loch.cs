using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golf_loch : MonoBehaviour
{
    public GameObject effectObject;

    void Start()
    {
        effectObject.SetActive(false);
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        GolfBall bObj = otherCollider.GetComponent<GolfBall>();
        
            effectObject.SetActive(true);
            
        
    }
}
