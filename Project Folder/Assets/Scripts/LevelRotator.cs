using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotator : MonoBehaviour {
    public float rotationSensitivity;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnMove(InputValue value) {
        var rotation = value.Get<Vector2>();

        var xRotation = rotation.y * rotationSensitivity * 1.5f * Time.deltaTime;
        var yRotation = -rotation.x * rotationSensitivity * Time.deltaTime;

        transform.Rotate(new Vector3(xRotation, 0, yRotation));
    }
}
