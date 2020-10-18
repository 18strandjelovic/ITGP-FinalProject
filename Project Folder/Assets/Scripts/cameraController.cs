using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject player;           // player object

    private Vector3 offset;             // camera offset

    void Start()
    {
        offset = transform.position - player.transform.position;        // updateing the position of the camera based off ofset
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    // function to orbit camera around player's sphere
    // need to fix track rotation to use this tho
    public void orbit(float y)
    {
        var postion = player.transform.position + offset;
        transform.SetPositionAndRotation(postion, Quaternion.Euler(new Vector3(0, y, 0)));
    }
}