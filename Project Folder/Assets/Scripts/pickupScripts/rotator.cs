using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour
{
    private int multiplier;                 // speed multiplier for rotation

    public bool reverse = false;            // for reverse rotation cubes in pickup
    public bool horizontal = false;         // for reverse horizontal rotation cubes in pickup



    private void Start()
    {
        multiplier = 3;
    }
    // Before rendering each frame..
    void Update()
    {
        // each cube in pickup will rotate differtnly base on bool selection
        if (reverse) {
            if (horizontal) {
                transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * -1 * multiplier);
            } else{
                transform.Rotate(new Vector3(45, 30, 15) * Time.deltaTime * -1 * multiplier);
            }
        } else {
            if (horizontal){
                transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * multiplier);
            } else{
                transform.Rotate(new Vector3(45, 30, 15) * Time.deltaTime * multiplier);
            }
        }
    }
}