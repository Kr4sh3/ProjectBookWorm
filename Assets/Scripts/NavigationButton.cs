using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NavigationButton : MonoBehaviour, IPointerEnterHandler
{
    private CameraController camController;
    public Vector3 cameraPosition;
    private void Start()
    {
        camController = Camera.main.GetComponent<CameraController>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        camController.SetTargetPosition(cameraPosition);
    }
}
