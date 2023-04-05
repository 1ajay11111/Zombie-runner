using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 25f;
    [SerializeField] float zoomoutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;


    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle ==false)
            {
                ZoomIn();

            }
            else
            {
                ZoomOut();
            }
        }

    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomoutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomoutSensitivity;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }
}
