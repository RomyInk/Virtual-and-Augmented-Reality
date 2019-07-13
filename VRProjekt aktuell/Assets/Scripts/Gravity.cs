using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Gravity : MonoBehaviour
{
    public SteamVR_Action_Boolean ballAction;
    public SteamVR_Input_Sources handType;

    public Rigidbody m_RigidBody;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballAction.GetLastStateUp(handType))
        {
            DisableRagdoll();
        }
        else EnableRagdoll();
    }

    void EnableRagdoll()
    {
        m_RigidBody.isKinematic = false;
        m_RigidBody.detectCollisions = true;
    }

    // Let animation control the rigidbody and ignore collisions.
    void DisableRagdoll()
    {
        m_RigidBody.isKinematic = true;
        m_RigidBody.detectCollisions = false;
    }

}
