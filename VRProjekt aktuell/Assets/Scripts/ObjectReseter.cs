using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReseter : MonoBehaviour {

  public bool testActive = false;

  // Update is called once per frame
  void Update() {
    if (testActive) {
      ResetChildren();
      testActive = false;
    }
  }

  private void ResetChildren() {

    // is called on every Behaivor? ... might cause problems
    BroadcastMessage("ResetObject");
  }
}
