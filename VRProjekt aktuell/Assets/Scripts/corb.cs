using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corb : MonoBehaviour
{
    public GameObject effectObject;

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
            bObj.changeForGoal();
        }
    }
}
