using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    bool enabled = true;
    public float horizontalForce = 80f;

    // Update is called once per frame
    void FixedUpdate() {
        if(Input.GetKey("a") && enabled) {
            // push player to left
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("d") && enabled) {
            // push player to right
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1) {
            // player has fallen off the edge
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
