using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {
    public Camera camera;
    private float cameraFieldOfView;
    public float zoomSpeed;
    private float mouseScrollInput;

    void Start() {
        cameraFieldOfView = camera.fieldOfView;
    }

    void Update() {
        mouseScrollInput = Input.GetAxis("Mouse ScrollWheel");
        cameraFieldOfView -= mouseScrollInput*zoomSpeed;
        cameraFieldOfView = Mathf.Clamp(cameraFieldOfView, 30, 60);
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, cameraFieldOfView, zoomSpeed);
    }
}