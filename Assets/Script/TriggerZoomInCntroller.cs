using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
  public Collider Bola;
  public CameraController cameraController;
  public float length;

  private void OnTriggerEnter(Collider other)
  {
    if (other == Bola)
    {
        cameraController.FollowTarget(Bola.transform, length);
    }
  }
}