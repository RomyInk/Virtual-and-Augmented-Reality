using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring_area : MonoBehaviour
{

    public GameObject effectObject;
    public GameObject schlaeger;

    void Start()
    {
        effectObject.SetActive(false);
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        Ball bObj = otherCollider.GetComponent<Ball>();
        if (bObj != null)
        {
            effectObject.SetActive(true);
            bObj.gameObject.SetActive(false);
            schlaeger.SetActive(true);
        }
    }
}
