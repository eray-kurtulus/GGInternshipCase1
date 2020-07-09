using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    // This function is called when the player hits an object
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") {
            // stop player movement (user input)
            GetComponent<PlayerMovement>().enabled = false;
            // end the game
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
