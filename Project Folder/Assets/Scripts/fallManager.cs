using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class fallManager : MonoBehaviour {
    public GameObject marble;
    public Transform spawn;
    public Transform level;
    public float minY;

    private Quaternion startingRotation;
    // Start is called before the first frame update
    void Start() {
        startingRotation = level.rotation;
    }

    // Update is called once per frame
    void Update() {
        if (marble.transform.position.y < minY) {
            resetLevel();
        }
    }


    private void resetLevel() {
        marble.transform.position = spawn.position;
        level.rotation = startingRotation;

        var marbleRigidBody = marble.GetComponent<Rigidbody>();

        marbleRigidBody.angularVelocity = Vector3.zero;
        marbleRigidBody.velocity = Vector3.zero;
    }
}
