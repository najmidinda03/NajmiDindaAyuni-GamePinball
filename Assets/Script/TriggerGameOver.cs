using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
  public Collider Bola;
  public GameObject gameOverCanvas;

  private void OnTriggerEnter(Collider other)
  {
    if (other == Bola)
    {
	     gameOverCanvas.SetActive(true);
    }
  }
}