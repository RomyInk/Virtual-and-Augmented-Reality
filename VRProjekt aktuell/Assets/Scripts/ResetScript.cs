using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour {

  public bool resetPosition = true;
  public bool resetRotation = true;
  public bool resetScale = true;
  public bool resetPhysic = true;

  public bool useTag;
  public string contactTag;

  public bool useLowBoarder = true;
  public float lowBoarderY = -10f;

  private Rigidbody ownBody;
  private Vector3 resetPointPosition;
  private Quaternion resetPointRotation;
  private Vector3 resetPointScale;

  // Start is called before the first frame update
  private void Awake() {
    ownBody = GetComponent<Rigidbody>();
    resetPointPosition = transform.localPosition;
    resetPointRotation = transform.localRotation;
    resetPointScale = transform.localScale;
  }



  // Update is called once per frame
  private void Update() {
    if (useLowBoarder && lowBoarderY > transform.position.y) {
      ResetObject();
    }
  }

  private void OnCollisionEnter(Collision collision) {
    if (useTag && collision.collider.tag.Equals(contactTag)) {
      ResetObject();
    }
  }

  private bool resetTrue;

  public void ResetObject() {
    resetTrue = true;
  }

  public void FixedUpdate() {
    if (resetTrue) {
      if (resetPosition) {
        transform.localPosition = resetPointPosition;
      }
      if (resetRotation) {
        transform.localRotation = resetPointRotation;
      }
      if (resetScale) {
        transform.localScale = resetPointScale;
      }
      if (resetPhysic) {
        ownBody.angularVelocity = Vector3.zero;
        ownBody.velocity = Vector3.zero;
      }
      resetTrue = false;
    }
  }
}
