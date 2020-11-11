using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotator : MonoBehaviour {
    public float rotationSensitivity;       // how sensative the track rotion should be
    public bool testing;                    // if you are testing something, this is disable x and z track rotation
    public float xMultiplier = 1.25f;
    public float zMultiplier = 1.5f;

    private Keyboard k;                     // keyboard for getting key presses
    private float _xRotation;
    private float _zRotation;

    // Start is called before the first frame update
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        k = Keyboard.current;               // gets current keyboard
    }

    void LateUpdate() {
        if (!testing)
            transform.Rotate(new Vector3(_xRotation, 0, _zRotation));
        //rotateY();
    }

    // rotates track based on mouse movement
    void OnMove(InputValue value) {
        var rotation = value.Get<Vector2>();

        _xRotation = rotation.y * rotationSensitivity * xMultiplier * Time.deltaTime;
        _zRotation = -rotation.x * rotationSensitivity * zMultiplier * Time.deltaTime;
    }
}
