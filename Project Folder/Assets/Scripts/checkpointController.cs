using UnityEngine;

public class checkpointController : MonoBehaviour {
    public fallManager fm;

    // changes the spawn point to the check point for when the player falls
    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            if (fm.spawn.position != transform.position) {
                fm.spawn = transform;
            }
        }
    }
}
