using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{

  public string resetTag;
  public bool shutdown;

  private void OnTriggerExit(Collider other) {
    if (other.CompareTag(resetTag)) {
      if (!shutdown) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      } else {
        Application.Quit(0);
      }
    }
  }
}
