using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotator : MonoBehaviour {
    public float rotationSensitivity;       // how sensative the track rotion should be
    public float rotationSpeed;             // how fast to rotate y axis
    public float yRotation;                 // how far to rotate in the y axis
    public GameObject camera;               // camera object to counter rotate with y axis
    public bool testing;                    // if you are testing something, this is disable x and z track rotation
        
    private Keyboard k;                     // keyboard for getting key presses

    // Start is called before the first frame update
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        k = Keyboard.current;               // gets current keyboard
        yRotation = 0;                      // initializes yRotation to 0
    }

    private void LateUpdate()
    {
        //rotateY();
    }

    // currently not in use, need to figure out how to correctly rotate x and z with mouse but how y be done with keyboard
    // function to rotate track on y axis based on key presses
    void rotateY()
    {
        if (k.dKey.isPressed)
        {
            yRotation += rotationSpeed * Time.deltaTime;                // sets y rotation to be positive based on frame time and rotation speed
            if (yRotation > 360f)                                       // if its somehow greater than 360, will be steped down by 360
                yRotation -= 360f;
        }
        if (k.aKey.isPressed)
        {
            yRotation -= rotationSpeed * Time.deltaTime;                // sets y rotation to be negative based on frame time and rotation speed
            if (yRotation < -360f)                                      // if its somehow less than -360, will be steped up by 360
                yRotation += 360f;
        }

        transform.Rotate(new Vector3(0, yRotation, 0));                 // rotates the track by yRotation
        camera.GetComponent<cameraController>().orbit(-yRotation);      // calls function in camera to orbit around the player by -yRotation
        yRotation = 0;                                                  // resets yRotation so it dosent continously rotate
    }

    // rotates track based on mouse movement
    void OnMove(InputValue value) {
        var rotation = value.Get<Vector2>();

        var xRotation = rotation.y * rotationSensitivity * 1.5f * Time.deltaTime;
        var zRotation = -rotation.x * rotationSensitivity * Time.deltaTime;

        if (!testing)
            transform.Rotate(new Vector3(xRotation, 0, zRotation));
    }
    
}
