using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationButton : MonoBehaviour
{
    private CameraController camController;
    public Vector3 cameraPosition;
    private void Start()
    {
        camController = Camera.main.GetComponent<CameraController>();
    }
    public void Navigate()
    {
        camController.SetTargetPosition(cameraPosition);
    }
}
