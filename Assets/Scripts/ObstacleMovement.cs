using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Rigidbody rb;
    public Vector3 movementVelocity = new Vector3(0, 0, -10);

    void Start() {
        // let the obstacle move at a certain velocity
        // note that the obstacle should have drag=0 or it will stop
        // because we're not updating the velocity every frame
        rb.velocity = movementVelocity;
    }

    public void Stop() {
        // stop the movement
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
