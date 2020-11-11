using UnityEngine;

public class checkpointController : MonoBehaviour {
    public fallManager fm;

    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            if (fm.spawn.position != transform.position) {
                fm.spawn = transform;
            }
        }
    }
}
