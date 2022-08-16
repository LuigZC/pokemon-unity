using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform player;
    private Vector3 cameraOffset;
    [Range(.01f, 1f)]
    public float smoothness = .5f;

    void Start() {
        cameraOffset = transform.position - player.transform.position;
    }

    void Update() {
        Vector3 newPosition = player.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothness);
    }
}